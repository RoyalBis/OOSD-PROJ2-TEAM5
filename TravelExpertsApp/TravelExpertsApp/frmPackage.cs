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
using TravelExpertsDB.TravelExpertsDataSetTableAdapters;
using System.Xml;

namespace TravelExpertsApp
{
    public partial class frmPackage : Form
    {
        public frmPackage()
        {
            InitializeComponent();
        }

        public static Package MyPackage;

        //initialize DataSet, TableAdapters
        TravelExpertsDataSet travelExpertsDataSet = new TravelExpertsDataSet();
        PackagesTableAdapter packagesTableAdapter = new PackagesTableAdapter();
        Packages_Products_SuppliersTableAdapter packages_Products_SuppliersTableAdapter = new Packages_Products_SuppliersTableAdapter();

        //initialize Package list
        List<Package> packagelist = new List<Package>();
        private const string path = @"..\..\XML\PSID_Packages.xml"; //save the productsupplierID list in project folder

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

            packagesTableAdapter.Fill(travelExpertsDataSet.Packages);
            packages_Products_SuppliersTableAdapter.Fill(travelExpertsDataSet.Packages_Products_Suppliers);

            var packages = from package in travelExpertsDataSet.Packages //LinQ statemenet for join tables
                           //join package_product_supplier in travelExpertsDataSet.Packages_Products_Suppliers
                           //on package.PackageId equals package_product_supplier.PackageId
                           //orderby package_product_supplier ascending
                           select new
                           {
                               package.PackageId,
                               package.PkgName,
                               package.PkgDesc,
                               package.PkgStartDate,
                               package.PkgEndDate,
                               package.PkgBasePrice,
                               package.PkgAgencyCommission,
                               //package_product_supplier.ProductSupplierId,
                           };
            string packageId = "";
            int i = 0;
            foreach (var package in packages) //generate orders
            {
                if (package.PackageId.ToString() != packageId)
                {
                    lsvPackage_Supplier.Items.Add(package.PackageId.ToString());
                    packageId = package.PackageId.ToString();
                }
                else
                {
                    lsvPackage_Supplier.Items.Add("");
                }
                //add column members to the listview
                lsvPackage_Supplier.Items[i].SubItems.Add(package.PkgName.ToString());
                lsvPackage_Supplier.Items[i].SubItems.Add(package.PkgDesc.ToString());
                lsvPackage_Supplier.Items[i].SubItems.Add(package.PkgStartDate.ToShortDateString());
                lsvPackage_Supplier.Items[i].SubItems.Add(package.PkgEndDate.ToShortDateString());
                lsvPackage_Supplier.Items[i].SubItems.Add(package.PkgBasePrice.ToString("C"));
                lsvPackage_Supplier.Items[i].SubItems.Add(package.PkgAgencyCommission.ToString());
                //lsvPackage_Supplier.Items[i].SubItems.Add(package.ProductSupplierId.ToString());

                //create objects
                Package pack = new Package();
                pack.PackageId = package.PackageId;
                pack.PkgName = package.PkgName;
                pack.PkgDesc = package.PkgDesc;
                pack.PkgStartDate = package.PkgStartDate;
                pack.PkgEndDate = package.PkgEndDate;
                pack.PkgBasePrice = package.PkgBasePrice;
                pack.PkgAgencyCommission = package.PkgAgencyCommission;
                //pack.ProductSupplierId = package.ProductSupplierId;

                //add to the list
                packagelist.Add(pack);

                i++;
            }
        }

        private void btnXML_Click(object sender, EventArgs e)
        {
            SaveOrder(packagelist);  //method to save data into xml
        }

        public static void SaveOrder(List<Package> pl)
        {
            //XmlWriterSettings object
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.IndentChars = ("   ");

            //XmlWriter object
            XmlWriter xmlOut = XmlWriter.Create(path, settings);

            //start tag for root element
            xmlOut.WriteStartDocument();
            xmlOut.WriteStartElement("Packages");

            //write orders to the xml file
            foreach (Package p in pl)
            {
                xmlOut.WriteStartElement("Package");
                xmlOut.WriteAttributeString("PackageId",
                    p.PackageId.ToString());
                xmlOut.WriteElementString("PkgName",
                    p.PkgName);
                xmlOut.WriteElementString("PkgDesc",
                    p.PkgDesc);
                xmlOut.WriteElementString("PkgStartDate",
                    p.PkgStartDate.ToShortDateString());
                xmlOut.WriteElementString("PkgEndDate",
                    p.PkgEndDate.ToShortDateString());
                xmlOut.WriteElementString("pack.PkgBasePrice",
                    p.PkgBasePrice.ToString());
                xmlOut.WriteElementString("PkgAgencyCommission",
                    p.PkgAgencyCommission.ToString());
                //insert more xml out here

                xmlOut.WriteEndElement();
            }

            //end tage for root element
            xmlOut.WriteEndElement();
            MessageBox.Show("The xml file has been saved.");

            //close
            xmlOut.Close();
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
