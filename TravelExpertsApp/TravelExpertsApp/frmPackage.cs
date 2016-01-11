using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityLayer;
using TravelExpertsDB;
using Validation;

namespace TravelExpertsApp
{
    public partial class frmPackage : Form
    {
        public frmPackage()
        {
            InitializeComponent();
        }

        public static Package MyPackage;

        private void DisplayPackage()
        {
            txtPackageId.Text = MyPackage.PackageId.ToString();
            txtPkgName.Text = MyPackage.PkgName;
            rtxtPkgDesc.Text = MyPackage.PkgDesc;
            txtPkgStartDate.Text = MyPackage.PkgStartDate.ToString("MMMM dd, yyyy");
            txtPkgEndDate.Text = MyPackage.PkgEndDate.ToString("MMMM dd, yyyy");
            txtPkgBasePrice.Text = MyPackage.PkgBasePrice.ToString("C");
            txtPkgAgencyCommission.Text = MyPackage.PkgAgencyCommission.ToString("C");
        }

        private void readOnly()
        {
            txtPkgName.ReadOnly = true;
            rtxtPkgDesc.ReadOnly = true;
            txtPkgStartDate.ReadOnly = true;
            txtPkgEndDate.ReadOnly = true;
            txtPkgBasePrice.ReadOnly = true;
            txtPkgAgencyCommission.ReadOnly = true;
        }

        private void enableButtons()
        {
            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;
        }

        private void clearForm()
        {
            txtPackageId.Clear();
            txtPkgName.Clear();
            rtxtPkgDesc.Clear();
            txtPkgStartDate.Clear();
            txtPkgEndDate.Clear();
            txtPkgBasePrice.Clear();
            txtPkgAgencyCommission.Clear();
        }

        private void frmPackage_Load(object sender, EventArgs e)
        {
            readOnly();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //validate
            if (Validator.IsPresent(txtPackageId) == true)
            {
                int packageId = int.Parse(txtPackageId.Text);
                MyPackage = PackagesTable.SearchPackage(packageId);
                if (MyPackage == null)
                {
                    MessageBox.Show("No package found with this ID, try again!");
                    txtPackageId.Clear();
                }
                else
                {
                    DisplayPackage(); //pass, display results
                    enableButtons(); //enable update and delete
                }
            }
            else clearForm();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //create new package form: add
            frmPackageEntry addPackageFrm = new frmPackageEntry();
            addPackageFrm.AddPackage = true;
            DialogResult result = addPackageFrm.ShowDialog();
            //display the new package after it is added
            try
            {
                MyPackage = addPackageFrm.package;
                txtPackageId.Text = MyPackage.PackageId.ToString();
                this.DisplayPackage();
                enableButtons();
            }
            catch (Exception) { } //**
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //create new package form: add
            frmPackageEntry updatePackageFrm = new frmPackageEntry();
            updatePackageFrm.AddPackage = false;
            DialogResult result = updatePackageFrm.ShowDialog();
            //display the new package after it is added
            try
            {
                MyPackage = updatePackageFrm.package;
                txtPackageId.Text = MyPackage.PackageId.ToString();
                this.DisplayPackage();
            }
            catch (Exception) { } //**
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MyPackage != null) //check in case there is nothing to delete
            {
                //confirmation box
                DialogResult result = MessageBox.Show("You are about to delete " + MyPackage.PkgName,
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try //delete
                    {
                        PackagesTable.DeletePackage(MyPackage);
                        clearForm();
                        MessageBox.Show("Package <" + MyPackage.PkgName + "> has been deleted!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error:  <" + MyPackage.PkgName + "> -> " + ex);
                    }
                }
            }
            else MessageBox.Show("There is nothing to delete, please search a package first!");
        }
    }
}
