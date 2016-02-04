﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityLayer;
using MaterialSkin.Controls;
using TravelExpertsApp.Annotations;
using TravelExpertsApp.Properties;
using TravelExpertsDB;

namespace TravelExpertsApp
{
    public partial class frmMain : MaterialForm, IPkgViewerDocker
    {
        private int activePkgId;

        public frmMain()
        {
            InitializeComponent();
            MyPkgViewer = null;
            frmSplashStart start = new frmSplashStart();
            DialogResult splash = start.ShowDialog();
            if ( splash == DialogResult.OK )
            {
                DialogResult started = start.ShowDialog();

                if ( started == DialogResult.OK )
                {
                    frmLogin agtLogin = new frmLogin();

                    //hide panel
                    Panel hidePanel = DisplayHidePanel();
                    DialogResult result = agtLogin.ShowDialog();

                    if ( result != DialogResult.None )
                    {
                        hidePanel.Dispose();
                        if ( result == DialogResult.OK )
                        {
                            //get the user that just logged in here.
                        }
                    }
                }
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            FillPackages();
            FillProductSuppliers();
        }

        private void FillProductSuppliers()
        {
            //adding columns for Products search
            mlvProd.Columns.Add("ID", 60, HorizontalAlignment.Right);
            mlvProd.Columns.Add("Product Name", 300, HorizontalAlignment.Right);
            //adding columns for Suppliers search
            mlvSupp.Columns.Add("ID", 60, HorizontalAlignment.Right);
            mlvSupp.Columns.Add("Suppliers Name", 285, HorizontalAlignment.Right);
            //adding columns for Suppliers search
            mlvProdSupp.Columns.Add("ID", 60, HorizontalAlignment.Right);
            mlvProdSupp.Columns.Add("Product",100, HorizontalAlignment.Right);
            mlvProdSupp.Columns.Add("Supplier", 200, HorizontalAlignment.Right);
        }

        public void FillPackages()
        {
            MyPackageList = PackagesTable.GetAllPackages();
            lvPackages.Items?.Clear();
            foreach (Package pkg in MyPackageList)
            {
                string[] row =
                {
                    pkg.PackageId.ToString(),
                    pkg.PkgName,
                    pkg.PkgDesc,
                    pkg.PkgStartDate.ToShortDateString(),
                    pkg.PkgEndDate.ToShortDateString(),
                    pkg.PkgBasePrice.ToString("c"),
                    pkg.PkgAgencyCommission.ToString("c")
                };
                lvPackages.Items.Add(new ListViewItem(row));
            }
        }

        private void mbtnAdd_Click(object sender, EventArgs e)
        {
            //hide panel
            Panel hidePanel = DisplayHidePanel();

            //create new package form: add
            frmPkgAddModify addPkgForm = new frmPkgAddModify();
            addPkgForm.PkgIn = null;
            addPkgForm.Add = true;
            DialogResult result = addPkgForm.ShowDialog();

            if ( result != DialogResult.None )
            {
                hidePanel.Dispose();
                if ( result == DialogResult.OK )
                {
                    FillPackages();
                    ActivePkgId = MyPackageList.Count - 1;
                }
            }
        }

        private Panel DisplayHidePanel()
        {
            Panel hidePanel = new Panel();
            hidePanel.Size = this.Size;
            hidePanel.BackColor = Color.FromArgb(200, 0, 0, 0);
            this.Controls.Add(hidePanel);
            hidePanel.BringToFront();

            return hidePanel;
        }

        private void lvPackages_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ( MyPkgViewer == null  || MyPkgViewer.IsDisposed)
            {
                MyPkgViewer = new DockPkgViewer(this.panDock);
            }
            if ( lvPackages.FocusedItem != null )
            {
                ActivePkgId = lvPackages.FocusedItem.Index;
            }
        }

        private void lvPackages_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if ( e.Button != MouseButtons.Left )
            {
                return;
            }
            MaterialListView thisListView = (MaterialListView)sender;
            //create new package form: add
            frmPkgAddModify modifyPkgForm = new frmPkgAddModify();
            modifyPkgForm.PkgIn = MyPackageList[thisListView.FocusedItem.Index];
            modifyPkgForm.Add = false;
            //Panel hidePanel = new Panel();
            //hidePanel.Size = this.Size;
            //hidePanel.BackColor = Color.FromArgb(200, 0, 0, 0);
            //this.Controls.Add(hidePanel);
            //hidePanel.BringToFront();
            DialogResult result = modifyPkgForm.ShowDialog();
        }

        public DockPkgViewer MyPkgViewer { get; set; }
        public PackageList MyPackageList { get; set; }
        public Panel PanDock => panDock;
        public Panel PanForm => panForm;
        public Form FormInstance => this;

        public int ActivePkgId
        {
            get { return activePkgId; }
            set
            {
                activePkgId = value;
                activePkgId = ActivePkgId < MyPackageList.Count
                                  ? ((ActivePkgId >= 0) ? activePkgId : MyPackageList.Count - 1)
                                  : 0;
                UpdateActivePackage();
            }
        }

        private void UpdateActivePackage()
        {
            if (MyPkgViewer != null) MyPkgViewer?.DisplayActivePkg();
            if ( lvPackages.FocusedItem?.Index != ActivePkgId )
            {
                lvPackages.Items[ActivePkgId].Focused = true;
                lvPackages.Items[ActivePkgId].Selected = true;
            }
        }

        private void SearchProdSupps(string searchStr)
        {
            //refreshes and clears the listview
            this.mlvProdSupp.Items.Clear();
            this.mlvProdSupp.Update();  // In case there is databinding
            this.mlvProdSupp.Refresh(); // Redraw items

            //
            try
            {
                List<ProductSupplier> allProductSuppliers = ProductSupplierTable.SearchAllProdSups(searchStr);
                DisplayProdSups(allProductSuppliers);
            }
            catch (Exception ex)
            {
                string failMessage = $"Unable to retrieve Product Suppliers from the Database, {Environment.NewLine} Error: {ex.GetType()} {Environment.NewLine} {ex.Message}";
                MaterialMessageBox.Show(this, false, failMessage);
            }
        }

        private void DisplayProdSups(List<ProductSupplier> allProductSuppliers)
        {
            string[] arr = new string[3];
            foreach (ProductSupplier ProductSupplier in allProductSuppliers)
            {
                //Add items in an array
                arr[0] = ProductSupplier.ProductSupplierId.ToString();
                arr[1] = ProductSupplier.MyProduct.ProductId + " - " + ProductSupplier.MyProduct.ProdName;
                arr[2] = ProductSupplier.MySupplier.SupplierId + " - " + ProductSupplier.MySupplier.SupName; ;

                //add items in the list
                var listViewItem = new ListViewItem(arr);

                //populates the listview
                mlvProdSupp.Items.Add(listViewItem);
            }
        }

        private void SearchSuppliers(string searchStr)
        {
            //refreshes and clears the listview
            this.mlvSupp.Items.Clear();
            this.mlvSupp.Update();  // In case there is databinding
            this.mlvSupp.Refresh(); // Redraw items

            //
            try
            {
                List<Supplier> allSuppliers = SuppliersTable.SearchAllSuppliers(searchStr);
                DisplaySuppliers(allSuppliers);
            }
            catch (Exception ex)
            {
                string failMessage = $"Unable to retrieve Suppliers from the Database, {Environment.NewLine} Error: {ex.GetType()} {Environment.NewLine} {ex.Message}";
                MaterialMessageBox.Show(this, false, failMessage);
            }
        }

        private void DisplaySuppliers(List<Supplier> allSuppliers)
        {
            string[] arr = new string[2];
            foreach (Supplier ValueSuppliers in allSuppliers)
            {
                //Add items in an array
                arr[0] = ValueSuppliers.SupplierId.ToString();
                arr[1] = ValueSuppliers.SupName.ToString();

                //add items in the list
                var listViewItem = new ListViewItem(arr);

                //populates the listview
                mlvSupp.Items.Add(listViewItem);
            }
        }

        private void SearchProducts(string searchStr)
        {
            //refreshes and clears the listview
            this.mlvProd.Items.Clear();
            this.mlvProd.Update();  // In case there is databinding
            this.mlvProd.Refresh(); // Redraw items

            //
            try
            {
                List<Product> allProducts = ProductsTable.SearchAllProducts(searchStr);
                DisplayProducts(allProducts);
            }
            catch (Exception ex)
            {
                string failMessage = $"Unable to retrieve Products from the Database, {Environment.NewLine} Error: {ex.GetType()} {Environment.NewLine} {ex.Message}";
                MaterialMessageBox.Show(this, false, failMessage);
            }
        }

        private void DisplayProducts(List<Product> allProducts )
        {
            string[] arr = new string[2];
            foreach (Product ValueType in allProducts)
            {
                //Add items in an array
                arr[0] = ValueType.ProductId.ToString();
                arr[1] = ValueType.ProdName;

                //add items in the list
                var listViewItem = new ListViewItem(arr);

                //populates the listview
                mlvProd.Items.Add(listViewItem);
            }
        }

        private void mtxtSearch_TextChanged(object sender, EventArgs e)
        {
            SearchAll();
        }

        private void SearchAll()
        {
            SearchProducts(mtxtSearch.Text);
            SearchSuppliers(mtxtSearch.Text);
            SearchProdSupps(mtxtSearch.Text);
        }

        private void mbtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mlvProd_SelectedIndexChanged(object sender, EventArgs e)
        {
            mbtnProdEdit.Enabled = (mlvProd.SelectedItems.Count > 0);
        }

        private void mlvSupp_SelectedIndexChanged(object sender, EventArgs e)
        {
            mbtnSuppEdit.Enabled = (mlvSupp.SelectedItems.Count > 0);
        }

        private void mlvProdSupp_SelectedIndexChanged(object sender, EventArgs e)
        {
            mbtnProdSuppEdit.Enabled = (mlvProdSupp.SelectedItems.Count > 0);
        }

        private void mtxtSearch_Enter(object sender, EventArgs e)
        {
            pbSearch.Image = Resources.magnifier_24_lightblue;
        }

        private void mtxtSearch_Leave(object sender, EventArgs e)
        {
            pbSearch.Image = Resources.magnifier_24__bluegrey;
        }

        private void mbtnProdSuppAdd_Click(object sender, EventArgs e)
        {
            Panel hidePanel = DisplayHidePanel();

            frmProductSupplier myFrmProductSupplier = new frmProductSupplier(this);
            myFrmProductSupplier.Add = true;
            DialogResult result = myFrmProductSupplier.ShowDialog();
            if ( result != DialogResult.None )
            {
                hidePanel.Dispose();
                SearchAll();
            }
        }

        private void mbtnProdSuppEdit_Click(object sender, EventArgs e)
        {
            Panel hidePanel = DisplayHidePanel();

            int myProdSupId = Convert.ToInt32(mlvProdSupp.SelectedItems[0].SubItems[0].Text);
            ProductSupplier myProdSupp = ProductSupplierTable.GetProductSupplier(myProdSupId);
            frmProductSupplier myFrmProductSupplier = new frmProductSupplier(this);
            myFrmProductSupplier.Add = false;
            myFrmProductSupplier.ProdSuppIn = myProdSupp;
            DialogResult result = myFrmProductSupplier.ShowDialog();
            if (result != DialogResult.None)
            {
                hidePanel.Dispose();
                SearchAll();
            }
        }

        private void mbtnProdAdd_Click(object sender, EventArgs e)
        {
            Panel hidePanel = DisplayHidePanel();

            frmProduct myFrmProduct = new frmProduct(this);
            myFrmProduct.Add = true;
            DialogResult result = myFrmProduct.ShowDialog();
            if (result != DialogResult.None)
            {
                hidePanel.Dispose();
                SearchAll();
            }
        }

        private void mbtnProdEdit_Click(object sender, EventArgs e)
        {
            Panel hidePanel = DisplayHidePanel();

            int myProdId = Convert.ToInt32(mlvProd.SelectedItems[0].SubItems[0].Text);
            Product myProd = ProductsTable.GetProduct(myProdId);
            frmProduct myFrmProduct = new frmProduct(this);
            myFrmProduct.Add = false;
            myFrmProduct.ProdIn = myProd;
            DialogResult result = myFrmProduct.ShowDialog();
            if (result != DialogResult.None)
            {
                hidePanel.Dispose();
                SearchAll();
            }
        }

        private void mbtnSuppAdd_Click(object sender, EventArgs e)
        {
            Panel hidePanel = DisplayHidePanel();

            frmSupplier myFrmSupplier = new frmSupplier(this);
            myFrmSupplier.Add = true;
            DialogResult result = myFrmSupplier.ShowDialog();
            if (result != DialogResult.None)
            {
                hidePanel.Dispose();
                SearchAll();
            }
        }

        private void mbtnSuppEdit_Click(object sender, EventArgs e)
        {
            Panel hidePanel = DisplayHidePanel();

            int mySuppId = Convert.ToInt32(mlvSupp.SelectedItems[0].SubItems[0].Text);
            Supplier mySupp = SuppliersTable.GetSupplier(mySuppId);
            frmSupplier myFrmSupplier = new frmSupplier(this);
            myFrmSupplier.Add = false;
            myFrmSupplier.SuppIn = mySupp;
            DialogResult result = myFrmSupplier.ShowDialog();
            if (result != DialogResult.None)
            {
                hidePanel.Dispose();
                SearchAll();
            }
        }

        private void mlvProdSupp_Leave(object sender, EventArgs e)
        {
            mbtnProdSuppEdit.Enabled = false;
        }

        private void mlvSupp_Leave(object sender, EventArgs e)
        {
            mbtnSuppEdit.Enabled = false;
        }

        private void mlvProd_Leave(object sender, EventArgs e)
        {
            mbtnProdEdit.Enabled = false;
        }
    }
}
