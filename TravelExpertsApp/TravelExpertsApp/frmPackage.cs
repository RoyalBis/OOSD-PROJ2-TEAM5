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
using MaterialSkin;
using MaterialSkin.Controls;

namespace TravelExpertsApp
{
    public partial class frmPackage : MaterialForm
    {
        private MaterialSkinManager materialSkinManager;
        private List<ColorScheme> mySchemes = new List<ColorScheme>(); 
        private int myScheme;

        public frmPackage()
        {
            InitializeComponent();

            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            ColorScheme Orange = new ColorScheme(Primary.DeepOrange800, Primary.DeepOrange900, Primary.DeepOrange500, Accent.Orange200, TextShade.WHITE);
            ColorScheme Purple = new ColorScheme(Primary.DeepPurple800, Primary.DeepPurple900, Primary.DeepPurple500, Accent.Purple200, TextShade.WHITE);
            ColorScheme Green = new ColorScheme(Primary.Green800, Primary.Green900, Primary.Green500, Accent.LightGreen200, TextShade.WHITE);
            ColorScheme Blue = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);
            ColorScheme Amber = new ColorScheme(Primary.Amber800, Primary.Amber900, Primary.Amber500, Accent.Amber100, TextShade.WHITE);
            ColorScheme Indigo = new ColorScheme(Primary.Indigo800, Primary.Indigo900, Primary.Indigo500, Accent.Indigo100, TextShade.WHITE);
            ColorScheme Brown = new ColorScheme(Primary.Brown800, Primary.Brown900, Primary.Brown500, Accent.Orange200, TextShade.WHITE);
            ColorScheme Grey = new ColorScheme(Primary.Grey800, Primary.Grey900, Primary.Grey500, Accent.Orange200, TextShade.WHITE);
            ColorScheme Red = new ColorScheme(Primary.Red800, Primary.Red900, Primary.Red500, Accent.Red100, TextShade.WHITE);
            ColorScheme Pink = new ColorScheme(Primary.Pink800, Primary.Pink900, Primary.Pink500, Accent.Pink100, TextShade.WHITE);
            ColorScheme Lime = new ColorScheme(Primary.Lime800, Primary.Lime900, Primary.Lime500, Accent.Lime700, TextShade.WHITE);
            ColorScheme Cyan = new ColorScheme(Primary.Cyan800, Primary.Cyan900, Primary.Cyan500, Accent.Cyan700, TextShade.WHITE);
            ColorScheme Teal = new ColorScheme(Primary.Teal800, Primary.Teal900, Primary.Teal500, Accent.Teal700, TextShade.WHITE);
            ColorScheme Yellow = new ColorScheme(Primary.Yellow800, Primary.Yellow900, Primary.Yellow500, Accent.Yellow700, TextShade.WHITE);
            ColorScheme BlueGrey = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey800, Accent.LightBlue700, TextShade.WHITE);
            ColorScheme BlueGreen = new ColorScheme(Primary.BlueGrey900, Primary.Green600, Primary.Blue900, Accent.Green700, TextShade.WHITE);
            ColorScheme GreyOrange = new ColorScheme(Primary.DeepOrange900, Primary.Grey900, Primary.Orange900, Accent.Orange700, TextShade.WHITE);
            mySchemes.Add(Orange); mySchemes.Add(Purple); mySchemes.Add(Green); mySchemes.Add(Blue); mySchemes.Add(Amber);
            mySchemes.Add(Indigo); mySchemes.Add(Brown); mySchemes.Add(Grey); mySchemes.Add(Red); mySchemes.Add(Pink); mySchemes.Add(Lime); mySchemes.Add(Cyan);
            mySchemes.Add(Teal); mySchemes.Add(Yellow); mySchemes.Add(BlueGrey); mySchemes.Add(BlueGreen); mySchemes.Add(GreyOrange);
            myScheme = mySchemes.Count - 1;
            //materialSkinManager.ColorScheme = mySchemes[myScheme];
            materialSkinManager.ColorScheme = GreyOrange;
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
            //packages_Products_SuppliersTableAdapter.Fill(travelExpertsDataSet.Packages_Products_Suppliers);

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

        private void btnSearch_Click_1(object sender, EventArgs e)
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

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            //create new package form: add
            frmPkgAddModify addPkgForm = new frmPkgAddModify();
            addPkgForm.PkgIn = null;
            addPkgForm.Add = true;
            DialogResult result = addPkgForm.ShowDialog();
            
            //KEVINS FORM///////////////////////////////////////////////////
            //frmPackageEntry addPackageFrm = new frmPackageEntry();
            //addPackageFrm.AddPackage = true;
            //DialogResult result = addPackageFrm.ShowDialog();
            ////display the new package after it is added
            //try
            //{
            //    MyPackage = addPackageFrm.package;
            //    txtPackageId.Text = MyPackage.PackageId.ToString();
            //    this.DisplayPackage();
            //    enableButtons();
            //}
            //catch (Exception) { } //**

            //travelExpertsDataSet.Clear();
            //packagesTableAdapter.Fill(travelExpertsDataSet.Packages);
            ////////////////////////////////////////////////////////////////

        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            //create new package form: add
            frmPkgAddModify modifyPkgForm = new frmPkgAddModify();
            modifyPkgForm.PkgIn = MyPackage;
            modifyPkgForm.Add = false;
            DialogResult result = modifyPkgForm.ShowDialog();
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
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
                        PackagesProductsSuppliersTable.DeletePkgProdSup(MyPackage.PackageId);
                        PackagesTable.DeletePackage(MyPackage);
                        clearForm();
                        MessageBox.Show("Package <" + MyPackage.PkgName + "> has been deleted!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error:  <" + MyPackage.PkgName + "> -> " + ex);
                    }

                    travelExpertsDataSet.Clear();
                    packagesTableAdapter.Fill(travelExpertsDataSet.Packages);
                }
            }
            else MessageBox.Show("There is nothing to delete, please search a package first!");
        }

        private void btnXML_Click_1(object sender, EventArgs e)
        {
            SaveOrder(packagelist);  //method to save data into xml
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            myScheme = myScheme + 1;
            if ( myScheme >= mySchemes.Count )
            {
                myScheme = 0;
            }
            MaterialSkinManager.Instance.ColorScheme = mySchemes[myScheme];
        }
    }
}
