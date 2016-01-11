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
    public partial class frmPackageEntry : Form
    {
        public frmPackageEntry()
        {
            InitializeComponent();

        }

        public bool AddPackage; //indicate addpackage form -> true, or update package form -> false;
        public Package package;

        private void frmPackageEntry_Load(object sender, EventArgs e)
        {
            if (AddPackage == true) //add form header
            {
                this.Text = "Add New Package";
            }
            else //update form header
            {
                this.Text = "Update Exiting Package";
                txtPkgName.Text = frmPackage.MyPackage.PkgName;
                rtxtPkgDesc.Text = frmPackage.MyPackage.PkgDesc;
                dtpPkgStartDate.Value = frmPackage.MyPackage.PkgStartDate;
                dtpPkgEndDate.Value = frmPackage.MyPackage.PkgEndDate;
                txtPkgBasePrice.Text = frmPackage.MyPackage.PkgBasePrice.ToString();
                txtPkgAgencyCommission.Text = frmPackage.MyPackage.PkgAgencyCommission.ToString();
            }
        }

        private void btnCommit_Click(object sender, EventArgs e)
        {
            if (IsValide()) //All sorts of validations, check below for details
            {
                if (AddPackage == true) //if add form, try add
                {
                    try
                    {
                        package = new Package();
                        package.PkgName = txtPkgName.Text;
                        package.PkgDesc = rtxtPkgDesc.Text;
                        package.PkgStartDate = DateTime.Parse(dtpPkgStartDate.Text);
                        package.PkgEndDate = DateTime.Parse(dtpPkgEndDate.Text);
                        package.PkgBasePrice = decimal.Parse(txtPkgBasePrice.Text);
                        package.PkgAgencyCommission = decimal.Parse(txtPkgAgencyCommission.Text);

                        package.PackageId = PackagesTable.AddPackage(package);
                        
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: Either the package ID already exist or: \n\n" + ex);
                    }
                }
                else //if update form, try update
                {
                    try
                    {
                        package = new Package();
                        package.PkgName = txtPkgName.Text;
                        package.PkgDesc = rtxtPkgDesc.Text;
                        package.PkgStartDate = DateTime.Parse(dtpPkgStartDate.Text);
                        package.PkgEndDate = DateTime.Parse(dtpPkgEndDate.Text);
                        package.PkgBasePrice = decimal.Parse(txtPkgBasePrice.Text);
                        package.PkgAgencyCommission = decimal.Parse(txtPkgAgencyCommission.Text);

                        package.PackageId = PackagesTable.UpdatePackage(frmPackage.MyPackage, package);
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex);
                    }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close(); //close add or update form
        }

        private bool IsValide()
        {
            return
                Validator.IsPresent(txtPkgName) && //check for data presence
                Validator.IsPresent(rtxtPkgDesc) &&
                Validator.IsPresent(dtpPkgStartDate) &&
                Validator.IsPresent(dtpPkgEndDate) &&
                Validator.IsPresent(txtPkgBasePrice) &&
                Validator.IsPresent(txtPkgAgencyCommission) &&
                Validator.NonNegDecimal(txtPkgBasePrice) && //check for non negative decimal
                Validator.NonNegDecimal(txtPkgAgencyCommission);
        }
    }
}

