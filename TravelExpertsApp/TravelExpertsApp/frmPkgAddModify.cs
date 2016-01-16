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

namespace TravelExpertsApp
{
    public partial class frmPkgAddModify : Form
    {
        private PackageList packages;
        private Package activePackage;

        public frmPkgAddModify()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            packages = PackagesTable.GetAllPackages();
            activePackage = packages[0];
            ProductSupplierTable.GetProductSuppliers(activePackage);
            int i = 0;
            foreach (ProductSupplier productsupplier in activePackage.PkgProductSuppliers)
            {
                lvPkgProductSuppliers.Items.Add(productsupplier.ProductSupplierId.ToString());
                lvPkgProductSuppliers.Items[i].SubItems.Add(productsupplier.ProdName.ToString());
                lvPkgProductSuppliers.Items[i].SubItems.Add(productsupplier.SupName.ToString());
                i++;
            }
        }

        private void txtPkgName_TextChanged(object sender, EventArgs e)
        {
            //search all the packages in the packages list and check if they match
            foreach (Package package in packages)
            {
                if ( activePackage.PkgName != txtPkgName.Text )
                {
                    txtPkgName.BackColor = Color.Chartreuse;
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
                    lblMessages.Text = "Package Name Already Exists";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnAddModify_Click(object sender, EventArgs e)
        {

        }
    }
}
