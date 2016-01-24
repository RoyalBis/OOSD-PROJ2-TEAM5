using System;
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
using TravelExpertsDB;
using Validation;

namespace TravelExpertsApp
{
    public partial class frmPkgAddModify : MaterialForm
    {
        private PackageList packages;
        public Package ActivePackage;
        public bool Add;
        private MaterialSkinManager materialSkinManager;

        public frmPkgAddModify()
        {
            InitializeComponent();

            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Dock myDock = new Dock();
            //this.panDock.Controls.Add(myDock);
            //myDock.Dock = DockStyle.Fill;

            packages = PackagesTable.GetAllPackages();
            if ( !Add )
            {
                ProductSupplierTable.GetProductSuppliers(ActivePackage);
                this.Text = "Modify Package " + ActivePackage.PackageId;
                btnAddModify.Text = "Update";
                SetActive();
            }
        }

        private void SetActive()
        {
            txtPkgName.Text = ActivePackage.PkgName;
            MaterialComboBoxItem cbItem1 = new MaterialComboBoxItem("Hello");
            MaterialComboBoxItem cbItem2 = new MaterialComboBoxItem("Royal");
            MaterialComboBoxItem cbItem3 = new MaterialComboBoxItem("Bissell");
            txtPkgName.Add(cbItem1);
            txtPkgName.Add(cbItem2);
            txtPkgName.Add(cbItem3);
            dtpStartDate.Value = ActivePackage.PkgStartDate;
            dtpEndDate.Value = ActivePackage.PkgEndDate;
            txtDesc.Text = ActivePackage.PkgDesc;
            txtBasePrice.Text = ActivePackage.PkgBasePrice.ToString("c");
            txtCommission.Text = ActivePackage.PkgAgencyCommission.ToString("c");
            pbPkgImage.Image = ActivePackage.ImageFromBytes();
            //For Some Reason I have to Write a File, then convert it into an image from a file.
            File.WriteAllBytes("myImage.jpg", ActivePackage.PkgImage);
            pbPkgImage.Image = Image.FromFile("myImage.jpg");

            //Fill the List view with the Product Suppliers
            var ps = ActivePackage.PkgProductSuppliers;
            for (int i = 0; i < ps.Count; i++)
            {
                //lvPkgProductSuppliers.Items.Add((ps[i]))
                lvPkgProductSuppliers.Items.Add(ps[i].ProductSupplierId.ToString());
                lvPkgProductSuppliers.Items[i].SubItems.Add(ps[i].MyProduct.ProdName);
                lvPkgProductSuppliers.Items[i].SubItems.Add(ps[i].MySupplier.SupName);
            }
        }

        private void txtPkgName_TextChanged(object sender, EventArgs e)
        {
            //search all the packages in the packages list and check if they match
            foreach (Package package in packages)
            {
                if ( ActivePackage.PkgName != txtPkgName.Text )
                {
                    
                }
            }
        }

        private void txtPkgName_Leave(object sender, EventArgs e)
        {
            //search all the packages in the packages list and check if they match
            foreach (Package package in packages)
            {
                if (package.PkgName.Contains(txtPkgName.Text))
                {
                    //lblMessages.Text = "Package Name Already Exists";
                }
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
            }
        }

        private void btnAddModify_Click(object sender, EventArgs e)
        {
            if ( isValid() )
            {
                ImageConverter converter = new ImageConverter();
                byte[] imgArray = (byte[])converter.ConvertTo(pbPkgImage.Image, typeof(byte[]));
                string basePrice = txtBasePrice.Text.Replace("$", "");
                string commission = txtCommission.Text.Replace("$", "");

                Package newPkg = new Package
                {
                    PkgName = txtPkgName.Text,
                    PkgStartDate = dtpStartDate.Value,
                    PkgEndDate = dtpEndDate.Value,
                    PkgDesc = txtDesc.Text,
                    PkgBasePrice = Convert.ToDecimal(basePrice),
                    PkgAgencyCommission = Convert.ToDecimal(commission),
                    PkgImage = imgArray
                };
                if (Add)
                {
                    PackagesTable.AddPackage(newPkg);
                }
                else
                {
                    PackagesTable.UpdatePackage(ActivePackage, newPkg);
                }
                ActivePackage = newPkg;
            }
            //this.Close();
        }

        private bool isValid()
        {
            return Validator.IsPresent(txtPkgName) &&
                   Validator.IsPresent(txtDesc) &&
                   Validator.IsPresent(txtBasePrice) &&
                   Validator.NonNegDecimal(txtBasePrice) &&
                   Validator.NonNegDecimal(txtCommission) &&
                   Validator.DateLessThan(dtpStartDate, dtpEndDate);
                   //Validator.InCharCount(txtPkgName) &&
                   //Validator.InCharCount(txtDesc) &&
                   //Validator.InCharCount(txtBasePrice) &&
                   //Validator.InCharCount(txtCommission);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DockProdSupSearch userCtrl = new DockProdSupSearch();
            userCtrl.Show();
            userCtrl.Dock = DockStyle.Fill;
            panDock.Width = userCtrl.Width;
            this.panDock.Controls.Add(userCtrl);
            this.Size = new Size(this.Width + userCtrl.Width, this.Height);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
