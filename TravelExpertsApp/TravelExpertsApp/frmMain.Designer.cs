namespace TravelExpertsApp
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.panMain = new System.Windows.Forms.Panel();
            this.mtabSelector = new MaterialSkin.Controls.MaterialTabSelector();
            this.mtabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPkgs = new System.Windows.Forms.TabPage();
            this.panPkgBtns = new System.Windows.Forms.Panel();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.mbtnAdd = new MaterialSkin.Controls.MaterialFlatButton();
            this.lvPackages = new MaterialSkin.Controls.MaterialListView();
            this.colId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDesc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStartDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colEndDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colBasePrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCommission = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabProductSuppliers = new System.Windows.Forms.TabPage();
            this.mtxtSearch = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.panProductSuppliers = new System.Windows.Forms.Panel();
            this.mlvProdSupp = new MaterialSkin.Controls.MaterialListView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.materialDivider5 = new MaterialSkin.Controls.MaterialDivider();
            this.mbtnProdSuppEdit = new MaterialSkin.Controls.MaterialFlatButton();
            this.mbtnProdSuppAdd = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.panSuppliers = new System.Windows.Forms.Panel();
            this.mlvSupp = new MaterialSkin.Controls.MaterialListView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.materialDivider4 = new MaterialSkin.Controls.MaterialDivider();
            this.mbtnSuppEdit = new MaterialSkin.Controls.MaterialFlatButton();
            this.mbtnSuppAdd = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.panProducts = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.materialDivider3 = new MaterialSkin.Controls.MaterialDivider();
            this.mbtnProdEdit = new MaterialSkin.Controls.MaterialFlatButton();
            this.mbtnProdAdd = new MaterialSkin.Controls.MaterialFlatButton();
            this.mlvProd = new MaterialSkin.Controls.MaterialListView();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.panMainInner = new System.Windows.Forms.Panel();
            this.panDock = new System.Windows.Forms.Panel();
            this.panForm = new System.Windows.Forms.Panel();
            this.panBtns = new System.Windows.Forms.Panel();
            this.materialDivider2 = new MaterialSkin.Controls.MaterialDivider();
            this.mbtnLogout = new MaterialSkin.Controls.MaterialRaisedButton();
            this.mbtnExit = new MaterialSkin.Controls.MaterialRaisedButton();
            this.pbSearch = new System.Windows.Forms.PictureBox();
            this.panMain.SuspendLayout();
            this.mtabControl.SuspendLayout();
            this.tabPkgs.SuspendLayout();
            this.panPkgBtns.SuspendLayout();
            this.tabProductSuppliers.SuspendLayout();
            this.panProductSuppliers.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panSuppliers.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panProducts.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panMainInner.SuspendLayout();
            this.panForm.SuspendLayout();
            this.panBtns.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // panMain
            // 
            this.panMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panMain.BackColor = System.Drawing.Color.White;
            this.panMain.Controls.Add(this.mtabSelector);
            this.panMain.Controls.Add(this.panMainInner);
            this.panMain.Location = new System.Drawing.Point(0, 64);
            this.panMain.Name = "panMain";
            this.panMain.Size = new System.Drawing.Size(1018, 680);
            this.panMain.TabIndex = 0;
            // 
            // mtabSelector
            // 
            this.mtabSelector.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mtabSelector.BaseTabControl = this.mtabControl;
            this.mtabSelector.Depth = 0;
            this.mtabSelector.Location = new System.Drawing.Point(0, 14);
            this.mtabSelector.MouseState = MaterialSkin.MouseState.HOVER;
            this.mtabSelector.Name = "mtabSelector";
            this.mtabSelector.Size = new System.Drawing.Size(1018, 60);
            this.mtabSelector.TabIndex = 0;
            this.mtabSelector.Text = "materialTabSelector1";
            // 
            // mtabControl
            // 
            this.mtabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mtabControl.Controls.Add(this.tabPkgs);
            this.mtabControl.Controls.Add(this.tabProductSuppliers);
            this.mtabControl.Depth = 0;
            this.mtabControl.Location = new System.Drawing.Point(3, 3);
            this.mtabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.mtabControl.Name = "mtabControl";
            this.mtabControl.SelectedIndex = 0;
            this.mtabControl.Size = new System.Drawing.Size(1012, 552);
            this.mtabControl.TabIndex = 1;
            // 
            // tabPkgs
            // 
            this.tabPkgs.BackColor = System.Drawing.Color.White;
            this.tabPkgs.Controls.Add(this.panPkgBtns);
            this.tabPkgs.Controls.Add(this.lvPackages);
            this.tabPkgs.Location = new System.Drawing.Point(4, 25);
            this.tabPkgs.Name = "tabPkgs";
            this.tabPkgs.Padding = new System.Windows.Forms.Padding(3);
            this.tabPkgs.Size = new System.Drawing.Size(1004, 523);
            this.tabPkgs.TabIndex = 0;
            this.tabPkgs.Text = "Packages";
            // 
            // panPkgBtns
            // 
            this.panPkgBtns.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panPkgBtns.Controls.Add(this.materialDivider1);
            this.panPkgBtns.Controls.Add(this.mbtnAdd);
            this.panPkgBtns.Location = new System.Drawing.Point(9, 478);
            this.panPkgBtns.Name = "panPkgBtns";
            this.panPkgBtns.Size = new System.Drawing.Size(988, 45);
            this.panPkgBtns.TabIndex = 12;
            // 
            // materialDivider1
            // 
            this.materialDivider1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(0, 0);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(988, 1);
            this.materialDivider1.TabIndex = 12;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // mbtnAdd
            // 
            this.mbtnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mbtnAdd.AutoSize = true;
            this.mbtnAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbtnAdd.Depth = 0;
            this.mbtnAdd.Location = new System.Drawing.Point(800, 6);
            this.mbtnAdd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mbtnAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbtnAdd.Name = "mbtnAdd";
            this.mbtnAdd.Primary = true;
            this.mbtnAdd.Size = new System.Drawing.Size(184, 36);
            this.mbtnAdd.TabIndex = 9;
            this.mbtnAdd.Text = "Add New Package...";
            this.mbtnAdd.UseVisualStyleBackColor = true;
            this.mbtnAdd.Click += new System.EventHandler(this.mbtnAdd_Click);
            // 
            // lvPackages
            // 
            this.lvPackages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvPackages.BackColor = System.Drawing.Color.White;
            this.lvPackages.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvPackages.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colId,
            this.colName,
            this.colDesc,
            this.colStartDate,
            this.colEndDate,
            this.colBasePrice,
            this.colCommission});
            this.lvPackages.Depth = 0;
            this.lvPackages.FullRowSelect = true;
            this.lvPackages.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvPackages.Location = new System.Drawing.Point(9, 7);
            this.lvPackages.Margin = new System.Windows.Forms.Padding(4);
            this.lvPackages.MouseLocation = new System.Drawing.Point(-1, -1);
            this.lvPackages.MouseState = MaterialSkin.MouseState.OUT;
            this.lvPackages.MultiSelect = false;
            this.lvPackages.Name = "lvPackages";
            this.lvPackages.OwnerDraw = true;
            this.lvPackages.Size = new System.Drawing.Size(988, 468);
            this.lvPackages.TabIndex = 8;
            this.lvPackages.UseCompatibleStateImageBehavior = false;
            this.lvPackages.View = System.Windows.Forms.View.Details;
            this.lvPackages.SelectedIndexChanged += new System.EventHandler(this.lvPackages_SelectedIndexChanged);
            this.lvPackages.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvPackages_MouseDoubleClick);
            // 
            // colId
            // 
            this.colId.Text = "ID";
            this.colId.Width = 50;
            // 
            // colName
            // 
            this.colName.Text = "Name";
            this.colName.Width = 200;
            // 
            // colDesc
            // 
            this.colDesc.Text = "Description";
            this.colDesc.Width = 300;
            // 
            // colStartDate
            // 
            this.colStartDate.Text = "Start Date";
            this.colStartDate.Width = 110;
            // 
            // colEndDate
            // 
            this.colEndDate.Text = "End Date";
            this.colEndDate.Width = 110;
            // 
            // colBasePrice
            // 
            this.colBasePrice.Text = "Base Price";
            this.colBasePrice.Width = 110;
            // 
            // colCommission
            // 
            this.colCommission.Text = "Commission";
            this.colCommission.Width = 108;
            // 
            // tabProductSuppliers
            // 
            this.tabProductSuppliers.BackColor = System.Drawing.Color.White;
            this.tabProductSuppliers.Controls.Add(this.mtxtSearch);
            this.tabProductSuppliers.Controls.Add(this.pbSearch);
            this.tabProductSuppliers.Controls.Add(this.panProductSuppliers);
            this.tabProductSuppliers.Controls.Add(this.panSuppliers);
            this.tabProductSuppliers.Controls.Add(this.panProducts);
            this.tabProductSuppliers.Location = new System.Drawing.Point(4, 25);
            this.tabProductSuppliers.Name = "tabProductSuppliers";
            this.tabProductSuppliers.Size = new System.Drawing.Size(1004, 523);
            this.tabProductSuppliers.TabIndex = 2;
            this.tabProductSuppliers.Text = "Products & Suppliers";
            // 
            // mtxtSearch
            // 
            this.mtxtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mtxtSearch.Depth = 0;
            this.mtxtSearch.Hint = "Search here...";
            this.mtxtSearch.Location = new System.Drawing.Point(686, 13);
            this.mtxtSearch.MaxLength = 32767;
            this.mtxtSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.mtxtSearch.Name = "mtxtSearch";
            this.mtxtSearch.PasswordChar = '\0';
            this.mtxtSearch.SelectedText = "";
            this.mtxtSearch.SelectionLength = 0;
            this.mtxtSearch.SelectionStart = 0;
            this.mtxtSearch.Size = new System.Drawing.Size(281, 28);
            this.mtxtSearch.TabIndex = 3;
            this.mtxtSearch.TabStop = false;
            this.mtxtSearch.UseSystemPasswordChar = false;
            this.mtxtSearch.Enter += new System.EventHandler(this.mtxtSearch_Enter);
            this.mtxtSearch.Leave += new System.EventHandler(this.mtxtSearch_Leave);
            this.mtxtSearch.TextChanged += new System.EventHandler(this.mtxtSearch_TextChanged);
            // 
            // panProductSuppliers
            // 
            this.panProductSuppliers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panProductSuppliers.Controls.Add(this.mlvProdSupp);
            this.panProductSuppliers.Controls.Add(this.panel3);
            this.panProductSuppliers.Controls.Add(this.materialLabel3);
            this.panProductSuppliers.Location = new System.Drawing.Point(686, 60);
            this.panProductSuppliers.Name = "panProductSuppliers";
            this.panProductSuppliers.Size = new System.Drawing.Size(370, 460);
            this.panProductSuppliers.TabIndex = 1;
            // 
            // mlvProdSupp
            // 
            this.mlvProdSupp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mlvProdSupp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mlvProdSupp.Depth = 0;
            this.mlvProdSupp.FullRowSelect = true;
            this.mlvProdSupp.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.mlvProdSupp.Location = new System.Drawing.Point(4, 28);
            this.mlvProdSupp.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mlvProdSupp.MouseState = MaterialSkin.MouseState.OUT;
            this.mlvProdSupp.MultiSelect = false;
            this.mlvProdSupp.Name = "mlvProdSupp";
            this.mlvProdSupp.OwnerDraw = true;
            this.mlvProdSupp.Size = new System.Drawing.Size(311, 385);
            this.mlvProdSupp.TabIndex = 6;
            this.mlvProdSupp.UseCompatibleStateImageBehavior = false;
            this.mlvProdSupp.View = System.Windows.Forms.View.Details;
            this.mlvProdSupp.SelectedIndexChanged += new System.EventHandler(this.mlvProdSupp_SelectedIndexChanged);
            this.mlvProdSupp.Leave += new System.EventHandler(this.mlvProdSupp_Leave);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.materialDivider5);
            this.panel3.Controls.Add(this.mbtnProdSuppEdit);
            this.panel3.Controls.Add(this.mbtnProdSuppAdd);
            this.panel3.Location = new System.Drawing.Point(6, 419);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(309, 38);
            this.panel3.TabIndex = 6;
            // 
            // materialDivider5
            // 
            this.materialDivider5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialDivider5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider5.Depth = 0;
            this.materialDivider5.Location = new System.Drawing.Point(1, 0);
            this.materialDivider5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider5.Name = "materialDivider5";
            this.materialDivider5.Size = new System.Drawing.Size(308, 1);
            this.materialDivider5.TabIndex = 2;
            this.materialDivider5.Text = "materialDivider5";
            // 
            // mbtnProdSuppEdit
            // 
            this.mbtnProdSuppEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mbtnProdSuppEdit.AutoSize = true;
            this.mbtnProdSuppEdit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbtnProdSuppEdit.Depth = 0;
            this.mbtnProdSuppEdit.Enabled = false;
            this.mbtnProdSuppEdit.Location = new System.Drawing.Point(201, 3);
            this.mbtnProdSuppEdit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mbtnProdSuppEdit.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbtnProdSuppEdit.Name = "mbtnProdSuppEdit";
            this.mbtnProdSuppEdit.Primary = false;
            this.mbtnProdSuppEdit.Size = new System.Drawing.Size(49, 36);
            this.mbtnProdSuppEdit.TabIndex = 1;
            this.mbtnProdSuppEdit.Text = "Edit";
            this.mbtnProdSuppEdit.UseVisualStyleBackColor = true;
            this.mbtnProdSuppEdit.Click += new System.EventHandler(this.mbtnProdSuppEdit_Click);
            // 
            // mbtnProdSuppAdd
            // 
            this.mbtnProdSuppAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mbtnProdSuppAdd.AutoSize = true;
            this.mbtnProdSuppAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbtnProdSuppAdd.Depth = 0;
            this.mbtnProdSuppAdd.Location = new System.Drawing.Point(258, 3);
            this.mbtnProdSuppAdd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mbtnProdSuppAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbtnProdSuppAdd.Name = "mbtnProdSuppAdd";
            this.mbtnProdSuppAdd.Primary = false;
            this.mbtnProdSuppAdd.Size = new System.Drawing.Size(47, 36);
            this.mbtnProdSuppAdd.TabIndex = 0;
            this.mbtnProdSuppAdd.Text = "Add";
            this.mbtnProdSuppAdd.UseVisualStyleBackColor = true;
            this.mbtnProdSuppAdd.Click += new System.EventHandler(this.mbtnProdSuppAdd_Click);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(3, 0);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(160, 24);
            this.materialLabel3.TabIndex = 4;
            this.materialLabel3.Text = "Product Suppliers";
            // 
            // panSuppliers
            // 
            this.panSuppliers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panSuppliers.Controls.Add(this.mlvSupp);
            this.panSuppliers.Controls.Add(this.panel2);
            this.panSuppliers.Controls.Add(this.materialLabel2);
            this.panSuppliers.Location = new System.Drawing.Point(345, 60);
            this.panSuppliers.Name = "panSuppliers";
            this.panSuppliers.Size = new System.Drawing.Size(335, 460);
            this.panSuppliers.TabIndex = 1;
            // 
            // mlvSupp
            // 
            this.mlvSupp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.mlvSupp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mlvSupp.Depth = 0;
            this.mlvSupp.FullRowSelect = true;
            this.mlvSupp.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.mlvSupp.Location = new System.Drawing.Point(3, 28);
            this.mlvSupp.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mlvSupp.MouseState = MaterialSkin.MouseState.OUT;
            this.mlvSupp.MultiSelect = false;
            this.mlvSupp.Name = "mlvSupp";
            this.mlvSupp.OwnerDraw = true;
            this.mlvSupp.Size = new System.Drawing.Size(326, 385);
            this.mlvSupp.TabIndex = 5;
            this.mlvSupp.UseCompatibleStateImageBehavior = false;
            this.mlvSupp.View = System.Windows.Forms.View.Details;
            this.mlvSupp.SelectedIndexChanged += new System.EventHandler(this.mlvSupp_SelectedIndexChanged);
            this.mlvSupp.Leave += new System.EventHandler(this.mlvSupp_Leave);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.materialDivider4);
            this.panel2.Controls.Add(this.mbtnSuppEdit);
            this.panel2.Controls.Add(this.mbtnSuppAdd);
            this.panel2.Location = new System.Drawing.Point(3, 419);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(328, 38);
            this.panel2.TabIndex = 5;
            // 
            // materialDivider4
            // 
            this.materialDivider4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialDivider4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider4.Depth = 0;
            this.materialDivider4.Location = new System.Drawing.Point(0, 0);
            this.materialDivider4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider4.Name = "materialDivider4";
            this.materialDivider4.Size = new System.Drawing.Size(328, 1);
            this.materialDivider4.TabIndex = 2;
            this.materialDivider4.Text = "materialDivider4";
            // 
            // mbtnSuppEdit
            // 
            this.mbtnSuppEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mbtnSuppEdit.AutoSize = true;
            this.mbtnSuppEdit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbtnSuppEdit.Depth = 0;
            this.mbtnSuppEdit.Enabled = false;
            this.mbtnSuppEdit.Location = new System.Drawing.Point(220, 3);
            this.mbtnSuppEdit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mbtnSuppEdit.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbtnSuppEdit.Name = "mbtnSuppEdit";
            this.mbtnSuppEdit.Primary = false;
            this.mbtnSuppEdit.Size = new System.Drawing.Size(49, 36);
            this.mbtnSuppEdit.TabIndex = 1;
            this.mbtnSuppEdit.Text = "Edit";
            this.mbtnSuppEdit.UseVisualStyleBackColor = true;
            this.mbtnSuppEdit.Click += new System.EventHandler(this.mbtnSuppEdit_Click);
            // 
            // mbtnSuppAdd
            // 
            this.mbtnSuppAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mbtnSuppAdd.AutoSize = true;
            this.mbtnSuppAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbtnSuppAdd.Depth = 0;
            this.mbtnSuppAdd.Location = new System.Drawing.Point(277, 3);
            this.mbtnSuppAdd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mbtnSuppAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbtnSuppAdd.Name = "mbtnSuppAdd";
            this.mbtnSuppAdd.Primary = false;
            this.mbtnSuppAdd.Size = new System.Drawing.Size(47, 36);
            this.mbtnSuppAdd.TabIndex = 0;
            this.mbtnSuppAdd.Text = "Add";
            this.mbtnSuppAdd.UseVisualStyleBackColor = true;
            this.mbtnSuppAdd.Click += new System.EventHandler(this.mbtnSuppAdd_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(3, 0);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(94, 24);
            this.materialLabel2.TabIndex = 3;
            this.materialLabel2.Text = "Suppliers:";
            // 
            // panProducts
            // 
            this.panProducts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panProducts.BackColor = System.Drawing.Color.White;
            this.panProducts.Controls.Add(this.panel1);
            this.panProducts.Controls.Add(this.mlvProd);
            this.panProducts.Controls.Add(this.materialLabel1);
            this.panProducts.Location = new System.Drawing.Point(4, 60);
            this.panProducts.Name = "panProducts";
            this.panProducts.Size = new System.Drawing.Size(335, 460);
            this.panProducts.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.materialDivider3);
            this.panel1.Controls.Add(this.mbtnProdEdit);
            this.panel1.Controls.Add(this.mbtnProdAdd);
            this.panel1.Location = new System.Drawing.Point(4, 419);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(328, 38);
            this.panel1.TabIndex = 4;
            // 
            // materialDivider3
            // 
            this.materialDivider3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialDivider3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider3.Depth = 0;
            this.materialDivider3.Location = new System.Drawing.Point(-2, 0);
            this.materialDivider3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider3.Name = "materialDivider3";
            this.materialDivider3.Size = new System.Drawing.Size(330, 1);
            this.materialDivider3.TabIndex = 2;
            this.materialDivider3.Text = "materialDivider3";
            // 
            // mbtnProdEdit
            // 
            this.mbtnProdEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mbtnProdEdit.AutoSize = true;
            this.mbtnProdEdit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbtnProdEdit.Depth = 0;
            this.mbtnProdEdit.Enabled = false;
            this.mbtnProdEdit.Location = new System.Drawing.Point(220, 3);
            this.mbtnProdEdit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mbtnProdEdit.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbtnProdEdit.Name = "mbtnProdEdit";
            this.mbtnProdEdit.Primary = false;
            this.mbtnProdEdit.Size = new System.Drawing.Size(49, 36);
            this.mbtnProdEdit.TabIndex = 1;
            this.mbtnProdEdit.Text = "Edit";
            this.mbtnProdEdit.UseVisualStyleBackColor = true;
            this.mbtnProdEdit.Click += new System.EventHandler(this.mbtnProdEdit_Click);
            // 
            // mbtnProdAdd
            // 
            this.mbtnProdAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mbtnProdAdd.AutoSize = true;
            this.mbtnProdAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbtnProdAdd.Depth = 0;
            this.mbtnProdAdd.Location = new System.Drawing.Point(277, 3);
            this.mbtnProdAdd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mbtnProdAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbtnProdAdd.Name = "mbtnProdAdd";
            this.mbtnProdAdd.Primary = false;
            this.mbtnProdAdd.Size = new System.Drawing.Size(47, 36);
            this.mbtnProdAdd.TabIndex = 0;
            this.mbtnProdAdd.Text = "Add";
            this.mbtnProdAdd.UseVisualStyleBackColor = true;
            this.mbtnProdAdd.Click += new System.EventHandler(this.mbtnProdAdd_Click);
            // 
            // mlvProd
            // 
            this.mlvProd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.mlvProd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mlvProd.Depth = 0;
            this.mlvProd.FullRowSelect = true;
            this.mlvProd.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.mlvProd.Location = new System.Drawing.Point(4, 28);
            this.mlvProd.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mlvProd.MouseState = MaterialSkin.MouseState.OUT;
            this.mlvProd.MultiSelect = false;
            this.mlvProd.Name = "mlvProd";
            this.mlvProd.OwnerDraw = true;
            this.mlvProd.Size = new System.Drawing.Size(326, 385);
            this.mlvProd.TabIndex = 3;
            this.mlvProd.UseCompatibleStateImageBehavior = false;
            this.mlvProd.View = System.Windows.Forms.View.Details;
            this.mlvProd.SelectedIndexChanged += new System.EventHandler(this.mlvProd_SelectedIndexChanged);
            this.mlvProd.Leave += new System.EventHandler(this.mlvProd_Leave);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(3, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(91, 24);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "Products:";
            // 
            // panMainInner
            // 
            this.panMainInner.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panMainInner.Controls.Add(this.panDock);
            this.panMainInner.Controls.Add(this.panForm);
            this.panMainInner.Location = new System.Drawing.Point(0, 74);
            this.panMainInner.Name = "panMainInner";
            this.panMainInner.Size = new System.Drawing.Size(1018, 605);
            this.panMainInner.TabIndex = 3;
            // 
            // panDock
            // 
            this.panDock.Dock = System.Windows.Forms.DockStyle.Right;
            this.panDock.Location = new System.Drawing.Point(1017, 0);
            this.panDock.Name = "panDock";
            this.panDock.Size = new System.Drawing.Size(1, 605);
            this.panDock.TabIndex = 14;
            // 
            // panForm
            // 
            this.panForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panForm.Controls.Add(this.panBtns);
            this.panForm.Controls.Add(this.mtabControl);
            this.panForm.Location = new System.Drawing.Point(0, 0);
            this.panForm.Name = "panForm";
            this.panForm.Size = new System.Drawing.Size(1015, 606);
            this.panForm.TabIndex = 13;
            // 
            // panBtns
            // 
            this.panBtns.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panBtns.BackColor = System.Drawing.Color.White;
            this.panBtns.Controls.Add(this.materialDivider2);
            this.panBtns.Controls.Add(this.mbtnLogout);
            this.panBtns.Controls.Add(this.mbtnExit);
            this.panBtns.Location = new System.Drawing.Point(3, 557);
            this.panBtns.Name = "panBtns";
            this.panBtns.Size = new System.Drawing.Size(1008, 45);
            this.panBtns.TabIndex = 2;
            // 
            // materialDivider2
            // 
            this.materialDivider2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialDivider2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider2.Depth = 0;
            this.materialDivider2.Location = new System.Drawing.Point(3, 0);
            this.materialDivider2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider2.Name = "materialDivider2";
            this.materialDivider2.Size = new System.Drawing.Size(1008, 1);
            this.materialDivider2.TabIndex = 3;
            this.materialDivider2.Text = "materialDivider2";
            // 
            // mbtnLogout
            // 
            this.mbtnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mbtnLogout.Depth = 0;
            this.mbtnLogout.Location = new System.Drawing.Point(779, 11);
            this.mbtnLogout.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbtnLogout.Name = "mbtnLogout";
            this.mbtnLogout.Primary = true;
            this.mbtnLogout.Size = new System.Drawing.Size(110, 31);
            this.mbtnLogout.TabIndex = 1;
            this.mbtnLogout.Text = "Logout";
            this.mbtnLogout.UseVisualStyleBackColor = true;
            // 
            // mbtnExit
            // 
            this.mbtnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mbtnExit.Depth = 0;
            this.mbtnExit.Location = new System.Drawing.Point(895, 11);
            this.mbtnExit.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbtnExit.Name = "mbtnExit";
            this.mbtnExit.Primary = true;
            this.mbtnExit.Size = new System.Drawing.Size(110, 31);
            this.mbtnExit.TabIndex = 0;
            this.mbtnExit.Text = "Exit";
            this.mbtnExit.UseVisualStyleBackColor = true;
            this.mbtnExit.Click += new System.EventHandler(this.mbtnExit_Click);
            // 
            // pbSearch
            // 
            this.pbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbSearch.Image = global::TravelExpertsApp.Properties.Resources.magnifier_24__bluegrey;
            this.pbSearch.Location = new System.Drawing.Point(973, 13);
            this.pbSearch.Name = "pbSearch";
            this.pbSearch.Size = new System.Drawing.Size(28, 28);
            this.pbSearch.TabIndex = 4;
            this.pbSearch.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1018, 744);
            this.Controls.Add(this.panMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "Travel Experts Package Editor";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panMain.ResumeLayout(false);
            this.mtabControl.ResumeLayout(false);
            this.tabPkgs.ResumeLayout(false);
            this.panPkgBtns.ResumeLayout(false);
            this.panPkgBtns.PerformLayout();
            this.tabProductSuppliers.ResumeLayout(false);
            this.panProductSuppliers.ResumeLayout(false);
            this.panProductSuppliers.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panSuppliers.ResumeLayout(false);
            this.panSuppliers.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panProducts.ResumeLayout(false);
            this.panProducts.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panMainInner.ResumeLayout(false);
            this.panForm.ResumeLayout(false);
            this.panBtns.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panMain;
        private System.Windows.Forms.Panel panBtns;
        private MaterialSkin.Controls.MaterialRaisedButton mbtnExit;
        private MaterialSkin.Controls.MaterialTabControl mtabControl;
        private System.Windows.Forms.TabPage tabPkgs;
        private MaterialSkin.Controls.MaterialTabSelector mtabSelector;
        private MaterialSkin.Controls.MaterialRaisedButton mbtnLogout;
        private MaterialSkin.Controls.MaterialListView lvPackages;
        private System.Windows.Forms.ColumnHeader colId;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colDesc;
        private System.Windows.Forms.ColumnHeader colStartDate;
        private System.Windows.Forms.ColumnHeader colEndDate;
        private System.Windows.Forms.ColumnHeader colBasePrice;
        private System.Windows.Forms.ColumnHeader colCommission;
        private MaterialSkin.Controls.MaterialFlatButton mbtnAdd;
        private System.Windows.Forms.Panel panMainInner;
        private System.Windows.Forms.Panel panPkgBtns;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialDivider materialDivider2;
        private System.Windows.Forms.Panel panForm;
        private System.Windows.Forms.Panel panDock;
        private System.Windows.Forms.TabPage tabProductSuppliers;
        private System.Windows.Forms.Panel panProducts;
        private System.Windows.Forms.Panel panProductSuppliers;
        private System.Windows.Forms.Panel panSuppliers;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.PictureBox pbSearch;
        private MaterialSkin.Controls.MaterialSingleLineTextField mtxtSearch;
        private System.Windows.Forms.Panel panel3;
        private MaterialSkin.Controls.MaterialFlatButton mbtnProdSuppEdit;
        private MaterialSkin.Controls.MaterialFlatButton mbtnProdSuppAdd;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialFlatButton mbtnSuppEdit;
        private MaterialSkin.Controls.MaterialFlatButton mbtnSuppAdd;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialFlatButton mbtnProdEdit;
        private MaterialSkin.Controls.MaterialFlatButton mbtnProdAdd;
        private MaterialSkin.Controls.MaterialListView mlvProd;
        private MaterialSkin.Controls.MaterialListView mlvProdSupp;
        private MaterialSkin.Controls.MaterialListView mlvSupp;
        private MaterialSkin.Controls.MaterialDivider materialDivider5;
        private MaterialSkin.Controls.MaterialDivider materialDivider4;
        private MaterialSkin.Controls.MaterialDivider materialDivider3;
    }
}

