﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityLayer;
using MaterialSkin;
using MaterialSkin.Controls;
using TravelExpertsApp.Properties;
using TravelExpertsDB;
using Validation;

namespace TravelExpertsApp
{
    public partial class frmPkgAddModify : MaterialForm
    {
        private PackageList packages;
        public Package PkgIn;
        public Package PkgOut = new Package();
        public bool Add;
        private bool imageChanged = false; 

        public frmPkgAddModify()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            packages = PackagesTable.GetAllPackages();
            if ( !Add )
            {
                ProductSupplierTable.AssignPkgProductSuppliers(PkgIn);
                this.Text = "Modify Package ID: " + PkgIn.PackageId;
                btnAddModify.Text = "Update";
                SetActive();
            }
            else
            {
                this.Text = "Add New Package";
                btnAddModify.Text = "Add";
            }
        }

        private void SetActive()
        {
            txtPkgName.Text = PkgIn.PkgName;
            dtpStartDate.Value = PkgIn.PkgStartDate;
            dtpEndDate.Value = PkgIn.PkgEndDate;
            txtDesc.Text = PkgIn.PkgDesc;
            txtBasePrice.Text = PkgIn.PkgBasePrice.ToString("c");
            txtCommission.Text = PkgIn.PkgAgencyCommission.ToString("c");

            //PLEASE FIX ME LATER AND USE EMILES IDEA. THANKS EMILE, TALK TO YOU SOON! SINCERLY ROYAL
            try
            {
                pbPkgImage.Image = PkgIn.ImageFromBytes();
                //For Some Reason I have to Write a File, then convert it into an image from a file.
                //File.WriteAllBytes("myImage.jpg", PkgIn.PkgImage);
                //pbPkgImage.Image = Image.FromFile("myImage.jpg");
                //File.Delete("myImage.jpg"); //just delete it when I am done with it
            }
            catch ( Exception)
            {
                pbPkgImage.Image = Resources.X_512_bluegrey;
            }

            //Fill the List view with the Product Suppliers
            var ps = PkgIn.PkgProductSuppliers;
            for (int i = 0; i < ps.Count; i++)
            {
                //lvPkgProductSuppliers.Items.Add((ps[i]))
                lvPkgProductSuppliers.Items.Add(ps[i].ProductSupplierId.ToString());
                lvPkgProductSuppliers.Items[i].SubItems.Add(ps[i].MyProduct.ProdName);
                lvPkgProductSuppliers.Items[i].SubItems.Add(ps[i].MySupplier.SupName);
            }
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            DialogResult result = ofdImage.ShowDialog();
            if ( result == DialogResult.OK )
            {
                string path = ofdImage.FileName;

                Image myImage = Image.FromFile(path);
                pbPkgImage.Image = myImage;
                pbPkgImage.Tag = path;
                imageChanged = true;
            }
        }

        private void btnAddModify_Click(object sender, EventArgs e)
        {
            Result message = isValid();
            if (message.Success )
            {
                if ( imageChanged == true )
                {
                    ImageConverter converter = new ImageConverter();
                    byte[] imgArray = (byte[])converter.ConvertTo(pbPkgImage.Image, typeof (byte[]));
                    PkgOut.PkgImage = imgArray;
                }
                else
                {
                    PkgOut.PkgImage = PkgIn?.PkgImage;
                }
                string basePrice = txtBasePrice.Text.Replace("$", "");
                string commission = txtCommission.Text.Replace("$", "");

                PkgOut.PkgName = txtPkgName.Text;
                PkgOut.PkgStartDate = dtpStartDate.Value;
                PkgOut.PkgEndDate = dtpEndDate.Value;
                PkgOut.PkgDesc = txtDesc.Text;
                PkgOut.PkgBasePrice = Convert.ToDecimal(basePrice);
                PkgOut.PkgAgencyCommission = Convert.ToDecimal(commission);
                int[] prodSupIds = new int[lvPkgProductSuppliers.Items.Count];
                if (lvPkgProductSuppliers.Items.Count > 0 )
                {
                    for (int i = 0; i < lvPkgProductSuppliers.Items.Count; i++)
                    {
                        prodSupIds[i] = Convert.ToInt32(lvPkgProductSuppliers.Items[i].Text);
                    }
                    PkgOut.PkgProductSuppliers.AddRange(ProductSupplierTable.GetRangeProductSuppliers(prodSupIds)); 
                }

                if (Add)
                {
                    PkgOut.PackageId = PackagesTable.AddPackage(PkgOut);
                    AddProductSuppliers(PkgOut);
                }
                else
                {
                    PackagesTable.UpdatePackage(PkgIn, PkgOut);
                    UpdateProductSuppliers(PkgIn, PkgOut);
                }
                PkgIn = PkgOut;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MaterialMessageBox.Show(this,message);
            }
        }

        private void UpdateProductSuppliers(Package PkgIn,Package PkgOut)
        {
            foreach (ProductSupplier prodsup in PkgIn.PkgProductSuppliers)
            {
                if ( !PkgOut.PkgProductSuppliers.Contains(prodsup) )
                {
                    PackagesProductsSuppliersTable.DeletePkgProdSup(PkgIn.PackageId, prodsup);
                }
            }

            foreach (ProductSupplier prodsup in PkgOut.PkgProductSuppliers)
            {
                if ( !PkgIn.PkgProductSuppliers.Contains(prodsup) )
                {
                    PackagesProductsSuppliersTable.AddPkgProdSup(PkgIn.PackageId, prodsup);
                }
            }
        }

        private void AddProductSuppliers(Package PkgOut)
        {
            foreach (ProductSupplier prodsup in PkgOut.PkgProductSuppliers)
            {
                PackagesProductsSuppliersTable.AddPkgProdSup(PkgOut.PackageId, prodsup);
            }
        }

        private Result isValid()
        {
            Result[] results = new Result[7];
            results[0] = Validator.IsPresent(txtPkgName);
            results[1] = Validator.IsPresent(txtDesc);
            results[2] = Validator.IsPresent(txtBasePrice);
            results[3] = Validator.NonNegDecimal(txtBasePrice);
            results[4] = Validator.NonNegDecimal(txtCommission);
            results[5] = Validator.DateLessThan(dtpStartDate, dtpEndDate);
            results[6] = Validator.ValueLessThan(txtCommission, txtBasePrice);

            foreach (Result result in results)
            {
                if ( !result.Success ) return result;
            }
            return new Result(true);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if ( this.panDock.Controls.Find("DockProdSupSearch",false).Length != 0 )
            {
                return;
            }
            DockProdSupSearch userCtrl = new DockProdSupSearch();
            
            userCtrl.UpdateControl = lvPkgProductSuppliers;
            userCtrl.Show();
            panDock.Width = userCtrl.Width;
            panForm.Width = panForm.Width - userCtrl.Width;
            this.Size = new Size(this.Width + userCtrl.Width, this.Height);
            this.panDock.Controls.Add(userCtrl);
            userCtrl.Dock = DockStyle.Fill;
            btnPSAdd.Enabled = false;
            if (this.Width + this.Left > Screen.PrimaryScreen.Bounds.Width)
            {
                this.Left = 0;
                //MyDocker.FormInstance.WindowState = FormWindowState.Maximized;
                int oversize = this.Width - Screen.PrimaryScreen.Bounds.Width;
                this.Width -= oversize;
                //SiblingFormPanel.Width -= oversize;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            string action = (this.Add) ? "adding" : "editing";
            string confirmMsg = $"Are you sure you want to cancel {action} this package?";
            DialogResult result= MaterialMessageBox.Show(this, true, confirmMsg);
            if ( result == DialogResult.OK )
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        private void btnPSDelete_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvPkgProductSuppliers.SelectedItems)
            {
                lvPkgProductSuppliers.Items.Remove(item);
            }
        }

        private void panDock_ControlRemoved(object sender, ControlEventArgs e)
        {
            btnPSAdd.Enabled = (e.Control.Name == "DockProdSupSearch") ? true : false;
        }
    }
}
