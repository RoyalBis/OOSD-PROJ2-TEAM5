﻿namespace TravelExpertsApp
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
            this.mbtnDelete = new MaterialSkin.Controls.MaterialFlatButton();
            this.mbtnEdit = new MaterialSkin.Controls.MaterialFlatButton();
            this.lvPackages = new MaterialSkin.Controls.MaterialListView();
            this.colId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDesc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStartDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colEndDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colBasePrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCommission = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.panMainInner = new System.Windows.Forms.Panel();
            this.panDock = new System.Windows.Forms.Panel();
            this.panForm = new System.Windows.Forms.Panel();
            this.panBtns = new System.Windows.Forms.Panel();
            this.materialDivider2 = new MaterialSkin.Controls.MaterialDivider();
            this.mbtnLogout = new MaterialSkin.Controls.MaterialRaisedButton();
            this.mbtnExit = new MaterialSkin.Controls.MaterialRaisedButton();
            this.tabProductSuppliers = new System.Windows.Forms.TabPage();
            this.panProducts = new System.Windows.Forms.Panel();
            this.panSuppliers = new System.Windows.Forms.Panel();
            this.panProductSuppliers = new System.Windows.Forms.Panel();
            this.materialSingleLineTextField1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panMain.SuspendLayout();
            this.mtabControl.SuspendLayout();
            this.tabPkgs.SuspendLayout();
            this.panPkgBtns.SuspendLayout();
            this.panMainInner.SuspendLayout();
            this.panForm.SuspendLayout();
            this.panBtns.SuspendLayout();
            this.tabProductSuppliers.SuspendLayout();
            this.panProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.panMain.Size = new System.Drawing.Size(1040, 680);
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
            this.mtabSelector.Size = new System.Drawing.Size(1040, 60);
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
            this.mtabControl.Controls.Add(this.tabSettings);
            this.mtabControl.Depth = 0;
            this.mtabControl.Location = new System.Drawing.Point(3, 3);
            this.mtabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.mtabControl.Name = "mtabControl";
            this.mtabControl.SelectedIndex = 0;
            this.mtabControl.Size = new System.Drawing.Size(1034, 552);
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
            this.tabPkgs.Size = new System.Drawing.Size(1026, 523);
            this.tabPkgs.TabIndex = 0;
            this.tabPkgs.Text = "Packages";
            // 
            // panPkgBtns
            // 
            this.panPkgBtns.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panPkgBtns.Controls.Add(this.materialDivider1);
            this.panPkgBtns.Controls.Add(this.mbtnAdd);
            this.panPkgBtns.Controls.Add(this.mbtnDelete);
            this.panPkgBtns.Controls.Add(this.mbtnEdit);
            this.panPkgBtns.Location = new System.Drawing.Point(9, 478);
            this.panPkgBtns.Name = "panPkgBtns";
            this.panPkgBtns.Size = new System.Drawing.Size(1010, 45);
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
            this.materialDivider1.Size = new System.Drawing.Size(1010, 1);
            this.materialDivider1.TabIndex = 12;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // mbtnAdd
            // 
            this.mbtnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mbtnAdd.AutoSize = true;
            this.mbtnAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbtnAdd.Depth = 0;
            this.mbtnAdd.Location = new System.Drawing.Point(959, 6);
            this.mbtnAdd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mbtnAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbtnAdd.Name = "mbtnAdd";
            this.mbtnAdd.Primary = true;
            this.mbtnAdd.Size = new System.Drawing.Size(47, 36);
            this.mbtnAdd.TabIndex = 9;
            this.mbtnAdd.Text = "Add";
            this.mbtnAdd.UseVisualStyleBackColor = true;
            this.mbtnAdd.Click += new System.EventHandler(this.mbtnAdd_Click);
            // 
            // mbtnDelete
            // 
            this.mbtnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mbtnDelete.AutoSize = true;
            this.mbtnDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbtnDelete.Depth = 0;
            this.mbtnDelete.Enabled = false;
            this.mbtnDelete.Location = new System.Drawing.Point(821, 6);
            this.mbtnDelete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mbtnDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbtnDelete.Name = "mbtnDelete";
            this.mbtnDelete.Primary = true;
            this.mbtnDelete.Size = new System.Drawing.Size(73, 36);
            this.mbtnDelete.TabIndex = 11;
            this.mbtnDelete.Text = "Delete";
            this.mbtnDelete.UseVisualStyleBackColor = true;
            // 
            // mbtnEdit
            // 
            this.mbtnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mbtnEdit.AutoSize = true;
            this.mbtnEdit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbtnEdit.Depth = 0;
            this.mbtnEdit.Enabled = false;
            this.mbtnEdit.Location = new System.Drawing.Point(902, 6);
            this.mbtnEdit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mbtnEdit.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbtnEdit.Name = "mbtnEdit";
            this.mbtnEdit.Primary = true;
            this.mbtnEdit.Size = new System.Drawing.Size(49, 36);
            this.mbtnEdit.TabIndex = 10;
            this.mbtnEdit.Text = "Edit";
            this.mbtnEdit.UseVisualStyleBackColor = true;
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
            this.lvPackages.Size = new System.Drawing.Size(1010, 468);
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
            this.colCommission.Width = 130;
            // 
            // tabSettings
            // 
            this.tabSettings.BackColor = System.Drawing.Color.White;
            this.tabSettings.Location = new System.Drawing.Point(4, 25);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabSettings.Size = new System.Drawing.Size(1026, 523);
            this.tabSettings.TabIndex = 1;
            this.tabSettings.Text = "Settings";
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
            this.panMainInner.Size = new System.Drawing.Size(1040, 605);
            this.panMainInner.TabIndex = 3;
            // 
            // panDock
            // 
            this.panDock.Dock = System.Windows.Forms.DockStyle.Right;
            this.panDock.Location = new System.Drawing.Point(1039, 0);
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
            this.panForm.Size = new System.Drawing.Size(1037, 606);
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
            this.panBtns.Size = new System.Drawing.Size(1030, 45);
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
            this.materialDivider2.Size = new System.Drawing.Size(1030, 1);
            this.materialDivider2.TabIndex = 3;
            this.materialDivider2.Text = "materialDivider2";
            // 
            // mbtnLogout
            // 
            this.mbtnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mbtnLogout.Depth = 0;
            this.mbtnLogout.Location = new System.Drawing.Point(801, 11);
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
            this.mbtnExit.Location = new System.Drawing.Point(917, 11);
            this.mbtnExit.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbtnExit.Name = "mbtnExit";
            this.mbtnExit.Primary = true;
            this.mbtnExit.Size = new System.Drawing.Size(110, 31);
            this.mbtnExit.TabIndex = 0;
            this.mbtnExit.Text = "Exit";
            this.mbtnExit.UseVisualStyleBackColor = true;
            // 
            // tabProductSuppliers
            // 
            this.tabProductSuppliers.BackColor = System.Drawing.Color.White;
            this.tabProductSuppliers.Controls.Add(this.panProductSuppliers);
            this.tabProductSuppliers.Controls.Add(this.panSuppliers);
            this.tabProductSuppliers.Controls.Add(this.panProducts);
            this.tabProductSuppliers.Location = new System.Drawing.Point(4, 25);
            this.tabProductSuppliers.Name = "tabProductSuppliers";
            this.tabProductSuppliers.Size = new System.Drawing.Size(1026, 523);
            this.tabProductSuppliers.TabIndex = 2;
            this.tabProductSuppliers.Text = "Products & Suppliers";
            // 
            // panProducts
            // 
            this.panProducts.BackColor = System.Drawing.Color.White;
            this.panProducts.Controls.Add(this.pictureBox1);
            this.panProducts.Controls.Add(this.materialSingleLineTextField1);
            this.panProducts.Location = new System.Drawing.Point(4, 4);
            this.panProducts.Name = "panProducts";
            this.panProducts.Size = new System.Drawing.Size(335, 516);
            this.panProducts.TabIndex = 0;
            // 
            // panSuppliers
            // 
            this.panSuppliers.Location = new System.Drawing.Point(345, 4);
            this.panSuppliers.Name = "panSuppliers";
            this.panSuppliers.Size = new System.Drawing.Size(335, 516);
            this.panSuppliers.TabIndex = 1;
            // 
            // panProductSuppliers
            // 
            this.panProductSuppliers.Location = new System.Drawing.Point(686, 4);
            this.panProductSuppliers.Name = "panProductSuppliers";
            this.panProductSuppliers.Size = new System.Drawing.Size(335, 516);
            this.panProductSuppliers.TabIndex = 1;
            // 
            // materialSingleLineTextField1
            // 
            this.materialSingleLineTextField1.Depth = 0;
            this.materialSingleLineTextField1.Hint = "";
            this.materialSingleLineTextField1.Location = new System.Drawing.Point(4, 4);
            this.materialSingleLineTextField1.MaxLength = 32767;
            this.materialSingleLineTextField1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField1.Name = "materialSingleLineTextField1";
            this.materialSingleLineTextField1.PasswordChar = '\0';
            this.materialSingleLineTextField1.SelectedText = "";
            this.materialSingleLineTextField1.SelectionLength = 0;
            this.materialSingleLineTextField1.SelectionStart = 0;
            this.materialSingleLineTextField1.Size = new System.Drawing.Size(294, 28);
            this.materialSingleLineTextField1.TabIndex = 0;
            this.materialSingleLineTextField1.TabStop = false;
            this.materialSingleLineTextField1.Text = "materialSingleLineTextField1";
            this.materialSingleLineTextField1.UseSystemPasswordChar = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(304, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 28);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1040, 744);
            this.Controls.Add(this.panMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Travel Experts Package Editor";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panMain.ResumeLayout(false);
            this.mtabControl.ResumeLayout(false);
            this.tabPkgs.ResumeLayout(false);
            this.panPkgBtns.ResumeLayout(false);
            this.panPkgBtns.PerformLayout();
            this.panMainInner.ResumeLayout(false);
            this.panForm.ResumeLayout(false);
            this.panBtns.ResumeLayout(false);
            this.tabProductSuppliers.ResumeLayout(false);
            this.panProducts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panMain;
        private System.Windows.Forms.Panel panBtns;
        private MaterialSkin.Controls.MaterialRaisedButton mbtnExit;
        private MaterialSkin.Controls.MaterialTabControl mtabControl;
        private System.Windows.Forms.TabPage tabPkgs;
        private System.Windows.Forms.TabPage tabSettings;
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
        private MaterialSkin.Controls.MaterialFlatButton mbtnDelete;
        private MaterialSkin.Controls.MaterialFlatButton mbtnEdit;
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField1;
    }
}

