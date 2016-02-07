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
using TravelExpertsApp.Properties;
using TravelExpertsDB;
using Validation;

namespace TravelExpertsApp
{
    public partial class frmPkgAddModify : MaterialForm
    {
        public Package PkgIn;   //incoming package for modify actions
        public Package PkgOut = new Package();  //package with new properties for update or add
        public bool Add;    //true if the user is adding a package
        private bool imageChanged = false;  //an image changed flag to resolve image to byte array issues.

        public frmPkgAddModify()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if ( !Add )     //modifing a current action
            {
                //get the packages, productsuppliers
                ProductSupplierTable.AssignPkgProductSuppliers(PkgIn);
                //set the modify text
                this.Text = "Modify Package ID: " + PkgIn.PackageId;
                btnAddModify.Text = "Update";
                //display the incoming package so that data can be modified
                SetActive();
            }
            else        //adding a package
            {
                //just set the add text
                this.Text = "Add New Package";
                btnAddModify.Text = "Add";
            }
        }

        /// <summary>
        /// Display the Incoming Package on the form
        /// </summary>
        private void SetActive()
        {
            txtPkgName.Text = PkgIn.PkgName;
            dtpStartDate.Value = PkgIn.PkgStartDate;
            dtpEndDate.Value = PkgIn.PkgEndDate;
            txtDesc.Text = PkgIn.PkgDesc;
            txtBasePrice.Text = PkgIn.PkgBasePrice.ToString("c");
            txtCommission.Text = PkgIn.PkgAgencyCommission.ToString("c");

            try
            {
                //try to display the packages image
                pbPkgImage.Image = PkgIn.ImageFromBytes();
            }
            catch ( Exception)
            {
                //there was no image so display the no image graphic
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
            //open the dialog to choose an image
            DialogResult result = ofdImage.ShowDialog();
            if ( result == DialogResult.OK )
            {   
                //the user selected an image, so get the path
                string path = ofdImage.FileName;

                //turn this into an image
                Image myImage = Image.FromFile(path);
                //add the image to the package
                pbPkgImage.Image = myImage;
                //set the image flag to true,
                imageChanged = true;
            }
        }

        private void btnAddModify_Click(object sender, EventArgs e)
        {
            //check that the user input is valid and return the message
            Result message = isValid();
            //if the input is valid, we can make a new package for the package out property
            if (message.Success )
            {
                //check if the image has been changed
                if ( imageChanged )
                {
                    //image changed so turn the into a byte array and store it
                    ImageConverter converter = new ImageConverter();
                    byte[] imgArray = (byte[])converter.ConvertTo(pbPkgImage.Image, typeof (byte[]));
                    PkgOut.PkgImage = imgArray;
                }
                else
                {
                    //image was not changed, so if the pkg in had an image use that, else just use null.
                    PkgOut.PkgImage = PkgIn?.PkgImage;
                }
                //we need to reform the text for the money column inorder to input it into the database.
                string basePrice = txtBasePrice.Text.Replace("$", "");
                string commission = txtCommission.Text.Replace("$", "");

                //assign the rest of the input to the new package
                PkgOut.PkgName = txtPkgName.Text;
                PkgOut.PkgStartDate = dtpStartDate.Value;
                PkgOut.PkgEndDate = dtpEndDate.Value;
                PkgOut.PkgDesc = txtDesc.Text;
                PkgOut.PkgBasePrice = Convert.ToDecimal(basePrice);
                PkgOut.PkgAgencyCommission = Convert.ToDecimal(commission);
                //create an array of all the productsuppliers
                int[] prodSupIds = new int[lvPkgProductSuppliers.Items.Count];
                //if there are produt suppliers we need to get them and add them to the new package
                if (lvPkgProductSuppliers.Items.Count > 0 )
                {
                    for (int i = 0; i < lvPkgProductSuppliers.Items.Count; i++)
                    {
                        //add each productsupplier id to the array
                        prodSupIds[i] = Convert.ToInt32(lvPkgProductSuppliers.Items[i].Text);
                    }
                    //Get all the productsuppliers in the array of productsupplier ids and add them to the package 
                    PkgOut.PkgProductSuppliers.AddRange(ProductSupplierTable.GetRangeProductSuppliers(prodSupIds)); 
                }

                //This is an add action
                if (Add)
                {
                    //Add the new package
                    PkgOut.PackageId = PackagesTable.AddPackage(PkgOut);
                    //add the new product suppliers to the package
                    AddProductSuppliers(PkgOut);
                }
                //this is a modify action
                else
                {
                    //update the exisiting package
                    PackagesTable.UpdatePackage(PkgIn, PkgOut);
                    //update the productsuppliers for the package
                    UpdateProductSuppliers(PkgIn, PkgOut);
                }
                //set the dialog result and close
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                //input was not valid, so display the validation message
                MaterialMessageBox.Show(this,message);
            }
        }

        /// <summary>
        /// Updates an existing Packages Product Suppliers
        /// </summary>
        /// <param name="PkgIn">Package, old</param>
        /// <param name="PkgOut">Package, new</param>
        private void UpdateProductSuppliers(Package PkgIn,Package PkgOut)
        {
            //Loop through each product supplier in the old package
            foreach (ProductSupplier prodsup in PkgIn.PkgProductSuppliers)
            {
                //if the new package does not contain that product supplier delete that entry from the packages_products_suppliers table
                if ( !PkgOut.PkgProductSuppliers.Contains(prodsup) )
                {
                    PackagesProductsSuppliersTable.DeletePkgProdSup(PkgIn.PackageId, prodsup);
                }
            }

            //Loop through each product supplier in the new package
            foreach (ProductSupplier prodsup in PkgOut.PkgProductSuppliers)
            {
                //if the old package does not contain that product supplier, add that entry to the packages_products_suppliers table.
                if ( !PkgIn.PkgProductSuppliers.Contains(prodsup) )
                {
                    PackagesProductsSuppliersTable.AddPkgProdSup(PkgIn.PackageId, prodsup);
                }
            }
        }

        /// <summary>
        /// Add Product Suppliers to the new Package
        /// </summary>
        /// <param name="PkgOut"></param>
        private void AddProductSuppliers(Package PkgOut)
        {
            //Loop through and create an entry in the package_products_suppliers table for each product supplier
            foreach (ProductSupplier prodsup in PkgOut.PkgProductSuppliers)
            {
                PackagesProductsSuppliersTable.AddPkgProdSup(PkgOut.PackageId, prodsup);
            }
        }

        /// <summary>
        /// Validates Form Input
        /// </summary>
        /// <returns>a Result Message Object</returns>
        private Result isValid()
        {
            //make an array of valdiations to run and add each one
            Result[] results = new Result[11];
            results[0] = Validator.IsPresent(txtPkgName);
            results[1] = Validator.IsPresent(txtDesc);
            results[2] = Validator.IsPresent(txtBasePrice);
            results[3] = Validator.NonNegDecimal(txtBasePrice);
            results[4] = Validator.NonNegDecimal(txtCommission);
            results[5] = Validator.DateLessThan(dtpStartDate, dtpEndDate);
            results[6] = Validator.ValueLessThan(txtCommission, txtBasePrice);
            results[7] = Validator.InCharCount(txtPkgName, 50);
            results[8] = Validator.InCharCount(txtDesc, 50);
            results[9] = Validator.InCharCount(txtBasePrice, 8, true);
            results[10] = Validator.InCharCount(txtCommission, 8, true);
            
            //for each validation, return that message if it is false
            foreach (Result result in results)
            {
                if ( !result.Success ) return result;
            }
            //none of the valdiations returned false, so user input is good
            return new Result(true);
        }

        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            DisplayProdSupSearchDock();
        }

        /// <summary>
        /// Method to Display a new ProductSupplier Search Dock
        /// </summary>
        private void DisplayProdSupSearchDock()
        {
            //check if the pan dock has a search dock already
            if ( this.panDock.Controls.Find("DockProdSupSearch", false).Length != 0 )
            {
                //if it does, just return.
                return;
            }
            //make a new Dock
            DockProdSupSearch userCtrl = new DockProdSupSearch();
            //set the control that this dock will update to be the product supplier listview
            userCtrl.UpdateControl = lvPkgProductSuppliers;
            //show the dock
            userCtrl.Show();
            //resize everything
            panDock.Width = userCtrl.Width;
            panForm.Width = panForm.Width - userCtrl.Width;
            this.Size = new Size(this.Width + userCtrl.Width, this.Height);
            //add the dock and make it fill its parent
            this.panDock.Controls.Add(userCtrl);
            userCtrl.Dock = DockStyle.Fill;
            //make sure the dock dosn't make this form flow to a second monitor
            if ( this.Width + this.Left > Screen.PrimaryScreen.Bounds.Width )
            {
                this.Left = 0;
                //MyDocker.FormInstance.WindowState = FormWindowState.Maximized;
                int oversize = this.Width - Screen.PrimaryScreen.Bounds.Width;
                this.Width -= oversize;
                //SiblingFormPanel.Width -= oversize;
            }
            //finally disable the add button because we can't have two of these docks
            btnPSAdd.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //the user is attempting to cancel this dialog
            //string for the form action add/edit
            string action = (this.Add) ? "adding" : "editing";
            //confirmation message string
            string confirmMsg = $"Are you sure you want to cancel {action} this package?";
            DialogResult result= MaterialMessageBox.Show(this, true, confirmMsg);
            //if the said yes to cancel, then cancel and close this form
            if ( result == DialogResult.OK )
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        private void btnPSDelete_Click(object sender, EventArgs e)
        {
            //delete each selected item in the list view.
            foreach (ListViewItem item in lvPkgProductSuppliers.SelectedItems)
            {
                lvPkgProductSuppliers.Items.Remove(item);
            }
        }

        private void panDock_ControlRemoved(object sender, ControlEventArgs e)
        {
            //when the dock is removed from this form, renable this add button.
            btnPSAdd.Enabled = (e.Control.Name == "DockProdSupSearch") ? true : false;
        }
    }
}
