using System;
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

/**********************************************************************
Title:                frmMain.cs  
 Project:          Travel Experts Desktop App
Authors:         Royal Bissell, Kevin Liao, Annie Ali, Lee Harrold
Class:               OOSD Fall 2015 
Date:               2016/02/07
Description:  Applicaiton Entry Point. his form loads a splashpage, then a login page then 
                           itself if login was successful. It Implements the IPkgViewerDocker so it can hold 
                           a PkgViewerDock.
                           This is a Tabbed Page, it currently is the starting point for tasks that involve 
                           Packages and Product, Suppliers, and Product Suppliers.
**********************************************************************/

namespace TravelExpertsApp
{
    /// <summary>
    /// Main Form and Entry Point for the Travel Experts App
    /// The main window requires login (authentication to use).It starts with a splash screen to promote a healthier working environment for agents.
    /// Once logged in, agents can add, update and delete packages at will. That information will then be updated to the database, which then updates the packages page on the website.
    /// </summary>
    public partial class frmMain : MaterialForm, IPkgViewerDocker
    {
        #region IPkgViewerDocker Implemented Fields and Properties
        //IPkgViewerDocker backing field
        private int activePkgId;

        //IPkgViewerDocker Properties
        public DockPkgViewer MyPkgViewer { get; set; } = null;
        public PackageList MyPackageList { get; set; }
        public Panel PanDock => panDock;
        public Panel PanForm => panForm;
        public Form FormInstance => this;
        //integer for  controlling the active package
        public int ActivePkgId
        {
            get { return activePkgId; }
            set
            {
                activePkgId = value;
                //allows active package looing 
                activePkgId = ActivePkgId < MyPackageList.Count
                                  ? ((ActivePkgId >= 0) ? activePkgId : MyPackageList.Count - 1)
                                  : 0;
                UpdateActivePackage();
            }
        }
        #endregion

        /// <summary>
        /// Constructor
        /// </summary>
        public frmMain()
        {
            InitializeComponent();
            SplashScreen();
        }

        #region pre-Main Forms 
        /// <summary>
        /// Launches the SplashScreen
        /// </summary>
        public void SplashScreen()
        {
            //make a new splash screen
            frmSplashStart start = new frmSplashStart();
            DialogResult splash = start.ShowDialog();
            //when the splash screen completes, login the agent
            if (splash == DialogResult.OK)
            {
                Login();
            }
        }

        /// <summary>
        /// Launches the Login Form
        /// </summary>
        public void Login()
        {
            //new login form
            frmLogin agtLogin = new frmLogin();
            DialogResult result = agtLogin.ShowDialog();
            //Dialog result is ok so the agent logged in successfully
            if (result == DialogResult.OK)
            {
                //TODO:get the user that just logged in here.
            }
        }
        #endregion

        #region formLoad Event and Methods
        //When the Form loads, get the packages and create the columns for the Product Supplier Tab 
        private void frmMain_Load(object sender, EventArgs e)
        {
            FillPackages();
            FillProductSuppliersColumns();
        }

        /// <summary>
        /// Create the Columns for the Product Suppliers Tab
        /// </summary>
        private void FillProductSuppliersColumns()
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

        /// <summary>
        /// Get the Packages and Add them to the listview
        /// </summary>
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
        #endregion

        private void mbtnAdd_Click(object sender, EventArgs e)
        {
            //hide panel
            Panel hidePanel = DisplayHidePanel();

            //create new package form: add
            frmPkgAddModify addPkgForm = new frmPkgAddModify();
            addPkgForm.PkgIn = null;    //adding so no PkgIn
            addPkgForm.Add = true;      //adding so true
            DialogResult result = addPkgForm.ShowDialog();
            if ( result != DialogResult.None )
            {
                hidePanel.Dispose();
                if ( result == DialogResult.OK )
                {
                    //Just added a new Pkg show refresh
                    FillPackages();
                    //this should put the active package to the latest Pkg...
                    ActivePkgId = MyPackageList.Count - 1;
                }
            }
        }

        /// <summary>
        /// Creates a Panel to Shade the current form in grey when a new form is shown
        /// </summary>
        /// <returns>Panel, Hide Panel</returns>
        private Panel DisplayHidePanel()
        {
            //new panel
            Panel hidePanel = new Panel();
            //the panel should be the size of the current form
            hidePanel.Size = this.Size;
            //transparent black
            hidePanel.BackColor = Color.FromArgb(200, 0, 0, 0);
            this.Controls.Add(hidePanel);
            hidePanel.BringToFront();
            return hidePanel;
        }

        private void mbtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #region Packages Tab
        private void lvPackages_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if no Pkg view create one
            if ( MyPkgViewer == null  || MyPkgViewer.IsDisposed)
            {
                MyPkgViewer = new DockPkgViewer(this.panDock);
            }
            //otherwise, just change the active Pkg
            if ( lvPackages.FocusedItem != null )
            {
                //active package is the package that was clicked in the listview
                ActivePkgId = lvPackages.FocusedItem.Index;
            }
            //TODO: does not currently create a new PkgViewer if the selection is reselected...
        }

        private void lvPackages_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //if this  was a right mouse button click, do nothing
            if ( e.Button != MouseButtons.Left )
            {
                return;
            }
            if (MyPkgViewer?.ActivePackage != null) //check in case there is nothing to delete
            {
                //edit the current package
                EditPackage();
            }
        }

        /// <summary>
        /// Launches the PkgAddModify Form as a Modify Instance
        /// </summary>
        public void EditPackage()
        {
            //hide panel to grey out the parent form
            Panel hidePanel = new Panel();
            hidePanel.Size = this.Size;
            hidePanel.BackColor = Color.FromArgb(200, 0, 0, 0);
            this.Controls.Add(hidePanel);
            hidePanel.BringToFront();

            //create new package form: add
            frmPkgAddModify modifyPkgForm = new frmPkgAddModify();
            modifyPkgForm.PkgIn = MyPkgViewer.ActivePackage;    //set the AddModifyForm to have the Active Package
            modifyPkgForm.Add = false;  //This si not an add action, it is a modify
            DialogResult result = modifyPkgForm.ShowDialog();

            //If the Dialog comes back with any result, we need to dispose of the hide panel
            if (result != DialogResult.None)
            {
                hidePanel.Dispose();
                //If it came back with an OK, the Active Package was updated
                if (result == DialogResult.OK)
                {
                    //get the new list of Packages
                    FillPackages();
                    //This allows me to update The Active Package Info 
                    ActivePkgId = ActivePkgId;
                }
            }
        }

        /// <summary>
        /// Performs everything that is necessary to Update the ActivePackage to the new ActivePkgId
        /// </summary>
        private void UpdateActivePackage()
        {
                //if there is a PkgViewer, Display the Active Package
            MyPkgViewer?.DisplayActivePkg();
            //if there is a focused Item in the listview, make that the active package.
            //this allows active package to changes from the docking window to be reflected on the listview
            if (lvPackages.FocusedItem?.Index != ActivePkgId)
            {
                lvPackages.Items[ActivePkgId].Focused = true;
                lvPackages.Items[ActivePkgId].Selected = true;
            }
        }
        #endregion

        #region Products and Suppliers Tab
        #region Search and Display ProductSuppliers
        /// <summary>
        /// Searches Product Suppliers and displays the results
        /// </summary>
        /// <param name="searchStr">string</param>
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

        /// <summary>
        /// Displays ProductSuppliers on a list view
        /// </summary>
        /// <param name="allProductSuppliers">List of ProductSuppliers</param>
        private void DisplayProdSups(List<ProductSupplier> allProductSuppliers)
        {
            //store each item for the listview item in an array
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
        #endregion

        #region Search and Display Suppliers
        /// <summary>
        /// Searches  Suppliers and displays the results
        /// </summary>
        /// <param name="searchStr">string</param>
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

        /// <summary>
        /// Displays Suppliers on a list view
        /// </summary>
        /// <param name="allSuppliers">List of Suppliers</param>
        private void DisplaySuppliers(List<Supplier> allSuppliers)
        {
            //store each item for the listview in an array
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
        #endregion

        #region Search and Display Products
        /// <summary>
        /// Searches  Products and displays the results
        /// </summary>
        /// <param name="searchStr">string</param>
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

        /// <summary>
        /// Display Products in a list view
        /// </summary>
        /// <param name="allProducts">List of Products</param>
        private void DisplayProducts(List<Product> allProducts )
        {
            //store each item for the list view item in an array
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
        #endregion  

        private void mtxtSearch_TextChanged(object sender, EventArgs e)
        {
            //call the seach all method, so I can call perform these actions without this event firing
            SearchAll();
        }

        private void SearchAll()
        {
            //search the three Lists
            SearchProducts(mtxtSearch.Text);
            SearchSuppliers(mtxtSearch.Text);
            SearchProdSupps(mtxtSearch.Text);
        }

        #region ProductSupplier Buttons
        private void mbtnProdSuppAdd_Click(object sender, EventArgs e)
        {
            //show the hide panel
            Panel hidePanel = DisplayHidePanel();

            //new form and set the needed properties
            frmProductSupplier myFrmProductSupplier = new frmProductSupplier(this);
            myFrmProductSupplier.Add = true;    //this is an add action
            DialogResult result = myFrmProductSupplier.ShowDialog();

            //on any return dispose of the panel, and re-search in order to refresh the results
            if ( result != DialogResult.None )
            {
                hidePanel.Dispose();
                SearchAll();
            }
        }
        
        private void mbtnProdSuppEdit_Click(object sender, EventArgs e)
        {
            //show the hide panel
            Panel hidePanel = DisplayHidePanel();

            //new form and set the needed properties
            ListViewItem selectedItem =  mlvProdSupp.SelectedItems[0];
            int myProdSupId = Convert.ToInt32(selectedItem.SubItems[0].Text);
            //get the selected item in the listview and return the ProductSupplier
            ProductSupplier myProdSupp = ProductSupplierTable.GetProductSupplier(myProdSupId);

            frmProductSupplier myFrmProductSupplier = new frmProductSupplier(this);
            myFrmProductSupplier.Add = false;   //this is a modify action
            myFrmProductSupplier.ProdSuppIn = myProdSupp;   //we are modifying this ProductSupplier
            DialogResult result = myFrmProductSupplier.ShowDialog();

            //on any return dispose of the panel, and re-search in order to refresh the results
            if (result != DialogResult.None)
            {
                hidePanel.Dispose();
                SearchAll();
            }
            //we need to disable they Product Supplier Edit Btn, because we no longer have one selected
            mbtnProdSuppEdit.Enabled = false;
        }
        #endregion

        #region Product Buttons
        private void mbtnProdAdd_Click(object sender, EventArgs e)
        {
            //show the hide panel
            Panel hidePanel = DisplayHidePanel();

            //new form and set the needed properties
            frmProduct myFrmProduct = new frmProduct(this);
            myFrmProduct.Add = true;    //this is an add action
            DialogResult result = myFrmProduct.ShowDialog();

            //on any return dispose of the panel, and re-search in order to refresh the results
            if (result != DialogResult.None)
            {
                hidePanel.Dispose();
                SearchAll();
            }
        }

        private void mbtnProdEdit_Click(object sender, EventArgs e)
        {
            //show the hide panel
            Panel hidePanel = DisplayHidePanel();
            //get the selected item in the listview and return the Product
            int myProdId = Convert.ToInt32(mlvProd.SelectedItems[0].SubItems[0].Text);
            Product myProd = ProductsTable.GetProduct(myProdId);

            //new form and set the needed properties
            frmProduct myFrmProduct = new frmProduct(this);
            myFrmProduct.Add = false;   //this is a modify action
            myFrmProduct.ProdIn = myProd;   //modify this Product
            DialogResult result = myFrmProduct.ShowDialog();

            //on any return dispose of the panel, and re-search in order to refresh the results
            if (result != DialogResult.None)
            {
                hidePanel.Dispose();
                SearchAll();
            }
            //we need to disable they Product Edit Btn, because we no longer have one selected
            mbtnProdEdit.Enabled = false;
        }
        #endregion

        #region Supplier Buttons
        private void mbtnSuppAdd_Click(object sender, EventArgs e)
        {
            //show the hide panel
            Panel hidePanel = DisplayHidePanel();

            //new form and set the needed properties
            frmSupplier myFrmSupplier = new frmSupplier(this);
            myFrmSupplier.Add = true;   //this is an add event
            DialogResult result = myFrmSupplier.ShowDialog();

            //on any return dispose of the panel, and re-search in order to refresh the results
            if (result != DialogResult.None)
            {
                hidePanel.Dispose();
                SearchAll();
            }
        }

        private void mbtnSuppEdit_Click(object sender, EventArgs e)
        {
            //show the hide panel
            Panel hidePanel = DisplayHidePanel();

            //get the selected item in the listview and return the Supplier
            int mySuppId = Convert.ToInt32(mlvSupp.SelectedItems[0].SubItems[0].Text);
            Supplier mySupp = SuppliersTable.GetSupplier(mySuppId);

            //new form and set the needed properties
            frmSupplier myFrmSupplier = new frmSupplier(this);
            myFrmSupplier.Add = false;  //this is a modify action
            myFrmSupplier.SuppIn = mySupp;  //modify this supplier
            DialogResult result = myFrmSupplier.ShowDialog();

            //on any return dispose of the panel, and re-search in order to refresh the results
            if (result != DialogResult.None)
            {
                hidePanel.Dispose();
                SearchAll();
            }
            //we need to disable they Supplier Edit Btn, because we no longer have one selected
            mbtnSuppEdit.Enabled = false;
        }
        #endregion

        #region Listview Edit Enable Buttons
        //Events to handle enabling and disabling Edit Buttons\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
        private void mlvProdSupp_SelectedIndexChanged(object sender, EventArgs e)
        {
            //when there are selected items in the listview enable the edit button, else disable it
            mbtnProdSuppEdit.Enabled = (mlvProdSupp.SelectedItems.Count > 0);
        }

        private void mlvSupp_SelectedIndexChanged(object sender, EventArgs e)
        {
            //when there are selected items in the listview enable the edit button, else disable it
            mbtnSuppEdit.Enabled = (mlvSupp.SelectedItems.Count > 0);
        }

        private void mlvProd_SelectedIndexChanged(object sender, EventArgs e)
        {
            //when there are selected items in the listview enable the edit button, else disable it
            mbtnProdEdit.Enabled = (mlvProd.SelectedItems.Count > 0);
        }

        //The Leave Events handle situations where although we still have a selected item in the listview the user is no longer sure what is selected because highlighting disappears on lost focus
        private void mlvProdSupp_Leave(object sender, EventArgs e)
        {
            //When the listview loses focus, we need to disable its edit button, unless the new active control is the edit button
            if ( ActiveControl != mbtnProdSuppEdit )
            {
                mbtnProdSuppEdit.Enabled = false;
            }
        }

        //The Leave Events handle situations where although we still have a selected item in the listview the user is no longer sure what is selected because highlighting disappears on lost focus
        private void mlvSupp_Leave(object sender, EventArgs e)
        {
            //When the listview loses focus, we need to disable its edit button, unless the new active control is the edit button
            if ( ActiveControl != mbtnSuppEdit )
            {
                mbtnSuppEdit.Enabled = false;
            }
        }

        //The Leave Events handle situations where although we still have a selected item in the listview the user is no longer sure what is selected because highlighting disappears on lost focus
        private void mlvProd_Leave(object sender, EventArgs e)
        {
            //When the listview loses focus, we need to disable its edit button, unless the new active control is the edit button
            if ( ActiveControl != mbtnProdEdit )
            {
                mbtnProdEdit.Enabled = false;
            }
        }

        //Enter events counter act what happens in the leave events, and allows reactivating the edit buttons even when the same item is selected
        private void mlvProdSupp_Enter(object sender, EventArgs e)
        {
            mbtnProdSuppEdit.Enabled = (mlvProdSupp.SelectedItems.Count > 0);
        }

        //Enter events counter act what happens in the leave events, and allows reactivating the edit buttons even when the same item is selected
        private void mlvSupp_Enter(object sender, EventArgs e)
        {
            mbtnSuppEdit.Enabled = (mlvSupp.SelectedItems.Count > 0);
        }

        //Enter events counter act what happens in the leave events, and allows reactivating the edit buttons even when the same item is selected
        private void mlvProd_Enter(object sender, EventArgs e)
        {
            mbtnProdEdit.Enabled = (mlvProd.SelectedItems.Count > 0);
        }
        //\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
        #endregion
        #endregion

        #region Search Image Events
        private void mtxtSearch_Enter(object sender, EventArgs e)
        {
            //display focus icon for the search bar
            pbSearch.Image = Resources.magnifier_24_lightblue;
        }

        private void mtxtSearch_Leave(object sender, EventArgs e)
        {
            //display not focused icon for the search bar
            pbSearch.Image = Resources.magnifier_24__bluegrey;
        }
        #endregion
    }
}
