using System.Drawing;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace TravelExpertsApp
{
    partial class frmPkgAddModify
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
            this.btnImage = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnAddModify = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnCancel = new MaterialSkin.Controls.MaterialRaisedButton();
            this.fpanButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.ofdImage = new System.Windows.Forms.OpenFileDialog();
            this.pbPkgImage = new System.Windows.Forms.PictureBox();
            this.lblPkgImage = new MaterialSkin.Controls.MaterialLabel();
            this.panPkgImage = new System.Windows.Forms.Panel();
            this.mdivMainBtn = new MaterialSkin.Controls.MaterialDivider();
            this.panProdSup = new System.Windows.Forms.Panel();
            this.btnPSEdit = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnPSDelete = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnPSAdd = new MaterialSkin.Controls.MaterialFlatButton();
            this.lvPkgProductSuppliers = new MaterialSkin.Controls.MaterialListView();
            this.colProdSup = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colProdName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSupName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblPkgProducts = new MaterialSkin.Controls.MaterialLabel();
            this.panFormGrp = new System.Windows.Forms.Panel();
            this.txtCommission = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.lblCommission = new MaterialSkin.Controls.MaterialLabel();
            this.txtBasePrice = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblEndDate = new MaterialSkin.Controls.MaterialLabel();
            this.lblBasePrice = new MaterialSkin.Controls.MaterialLabel();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.lblDesc = new MaterialSkin.Controls.MaterialLabel();
            this.lblPkgName = new MaterialSkin.Controls.MaterialLabel();
            this.lblStartDate = new MaterialSkin.Controls.MaterialLabel();
            this.panForm = new System.Windows.Forms.Panel();
            this.panMain = new System.Windows.Forms.Panel();
            this.panDock = new System.Windows.Forms.Panel();
            this.txtPkgName = new MaterialSkin.Controls.MaterialComboBox();
            this.fpanButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPkgImage)).BeginInit();
            this.panPkgImage.SuspendLayout();
            this.panProdSup.SuspendLayout();
            this.panFormGrp.SuspendLayout();
            this.panForm.SuspendLayout();
            this.panMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnImage
            // 
            this.btnImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImage.AutoSize = true;
            this.btnImage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnImage.Depth = 0;
            this.btnImage.Location = new System.Drawing.Point(596, 359);
            this.btnImage.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnImage.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnImage.Name = "btnImage";
            this.btnImage.Primary = true;
            this.btnImage.Size = new System.Drawing.Size(131, 36);
            this.btnImage.TabIndex = 2;
            this.btnImage.Text = "Select Image";
            this.btnImage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImage.UseVisualStyleBackColor = true;
            this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
            // 
            // btnAddModify
            // 
            this.btnAddModify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddModify.Depth = 0;
            this.btnAddModify.Location = new System.Drawing.Point(611, 3);
            this.btnAddModify.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddModify.Name = "btnAddModify";
            this.btnAddModify.Primary = true;
            this.btnAddModify.Size = new System.Drawing.Size(110, 31);
            this.btnAddModify.TabIndex = 6;
            this.btnAddModify.UseVisualStyleBackColor = true;
            this.btnAddModify.Click += new System.EventHandler(this.btnAddModify_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Depth = 0;
            this.btnCancel.Location = new System.Drawing.Point(495, 3);
            this.btnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Primary = true;
            this.btnCancel.Size = new System.Drawing.Size(110, 31);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // fpanButtons
            // 
            this.fpanButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.fpanButtons.BackColor = System.Drawing.Color.White;
            this.fpanButtons.Controls.Add(this.btnAddModify);
            this.fpanButtons.Controls.Add(this.btnCancel);
            this.fpanButtons.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.fpanButtons.Location = new System.Drawing.Point(3, 703);
            this.fpanButtons.Name = "fpanButtons";
            this.fpanButtons.Size = new System.Drawing.Size(724, 37);
            this.fpanButtons.TabIndex = 8;
            // 
            // ofdImage
            // 
            this.ofdImage.Filter = "Image Files (*.bmp, *.jpg)|*.bmp;*.jpg";
            this.ofdImage.Title = "Select an Image";
            // 
            // pbPkgImage
            // 
            this.pbPkgImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbPkgImage.Location = new System.Drawing.Point(0, 28);
            this.pbPkgImage.Name = "pbPkgImage";
            this.pbPkgImage.Size = new System.Drawing.Size(745, 329);
            this.pbPkgImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPkgImage.TabIndex = 9;
            this.pbPkgImage.TabStop = false;
            // 
            // lblPkgImage
            // 
            this.lblPkgImage.AutoSize = true;
            this.lblPkgImage.Depth = 0;
            this.lblPkgImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblPkgImage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPkgImage.Location = new System.Drawing.Point(15, 1);
            this.lblPkgImage.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPkgImage.Name = "lblPkgImage";
            this.lblPkgImage.Size = new System.Drawing.Size(145, 24);
            this.lblPkgImage.TabIndex = 0;
            this.lblPkgImage.Text = "Package Image:";
            // 
            // panPkgImage
            // 
            this.panPkgImage.BackColor = System.Drawing.Color.White;
            this.panPkgImage.Controls.Add(this.lblPkgImage);
            this.panPkgImage.Controls.Add(this.btnImage);
            this.panPkgImage.Controls.Add(this.pbPkgImage);
            this.panPkgImage.Location = new System.Drawing.Point(0, 292);
            this.panPkgImage.Name = "panPkgImage";
            this.panPkgImage.Size = new System.Drawing.Size(745, 401);
            this.panPkgImage.TabIndex = 10;
            // 
            // mdivMainBtn
            // 
            this.mdivMainBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mdivMainBtn.Depth = 0;
            this.mdivMainBtn.Location = new System.Drawing.Point(0, 690);
            this.mdivMainBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.mdivMainBtn.Name = "mdivMainBtn";
            this.mdivMainBtn.Size = new System.Drawing.Size(742, 1);
            this.mdivMainBtn.TabIndex = 10;
            this.mdivMainBtn.Text = "mdivMainBtn";
            // 
            // panProdSup
            // 
            this.panProdSup.BackColor = System.Drawing.Color.White;
            this.panProdSup.Controls.Add(this.btnPSEdit);
            this.panProdSup.Controls.Add(this.btnPSDelete);
            this.panProdSup.Controls.Add(this.btnPSAdd);
            this.panProdSup.Controls.Add(this.lvPkgProductSuppliers);
            this.panProdSup.Controls.Add(this.lblPkgProducts);
            this.panProdSup.Location = new System.Drawing.Point(374, 0);
            this.panProdSup.Name = "panProdSup";
            this.panProdSup.Size = new System.Drawing.Size(371, 286);
            this.panProdSup.TabIndex = 5;
            // 
            // btnPSEdit
            // 
            this.btnPSEdit.AutoSize = true;
            this.btnPSEdit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPSEdit.Depth = 0;
            this.btnPSEdit.Location = new System.Drawing.Point(249, 244);
            this.btnPSEdit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnPSEdit.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPSEdit.Name = "btnPSEdit";
            this.btnPSEdit.Primary = true;
            this.btnPSEdit.Size = new System.Drawing.Size(49, 36);
            this.btnPSEdit.TabIndex = 5;
            this.btnPSEdit.Text = "Edit";
            this.btnPSEdit.UseVisualStyleBackColor = true;
            // 
            // btnPSDelete
            // 
            this.btnPSDelete.AutoSize = true;
            this.btnPSDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPSDelete.Depth = 0;
            this.btnPSDelete.Location = new System.Drawing.Point(168, 244);
            this.btnPSDelete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnPSDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPSDelete.Name = "btnPSDelete";
            this.btnPSDelete.Primary = true;
            this.btnPSDelete.Size = new System.Drawing.Size(73, 36);
            this.btnPSDelete.TabIndex = 4;
            this.btnPSDelete.Text = "Delete";
            this.btnPSDelete.UseVisualStyleBackColor = true;
            // 
            // btnPSAdd
            // 
            this.btnPSAdd.AutoSize = true;
            this.btnPSAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPSAdd.Depth = 0;
            this.btnPSAdd.Location = new System.Drawing.Point(306, 244);
            this.btnPSAdd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnPSAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPSAdd.Name = "btnPSAdd";
            this.btnPSAdd.Primary = true;
            this.btnPSAdd.Size = new System.Drawing.Size(47, 36);
            this.btnPSAdd.TabIndex = 3;
            this.btnPSAdd.Text = "Add";
            this.btnPSAdd.UseVisualStyleBackColor = true;
            this.btnPSAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lvPkgProductSuppliers
            // 
            this.lvPkgProductSuppliers.BackColor = System.Drawing.Color.White;
            this.lvPkgProductSuppliers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvPkgProductSuppliers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colProdSup,
            this.colProdName,
            this.colSupName});
            this.lvPkgProductSuppliers.Depth = 0;
            this.lvPkgProductSuppliers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lvPkgProductSuppliers.FullRowSelect = true;
            this.lvPkgProductSuppliers.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvPkgProductSuppliers.LabelEdit = true;
            this.lvPkgProductSuppliers.Location = new System.Drawing.Point(0, 38);
            this.lvPkgProductSuppliers.MouseLocation = new System.Drawing.Point(-1, -1);
            this.lvPkgProductSuppliers.MouseState = MaterialSkin.MouseState.OUT;
            this.lvPkgProductSuppliers.Name = "lvPkgProductSuppliers";
            this.lvPkgProductSuppliers.OwnerDraw = true;
            this.lvPkgProductSuppliers.Scrollable = false;
            this.lvPkgProductSuppliers.ShowGroups = false;
            this.lvPkgProductSuppliers.Size = new System.Drawing.Size(360, 204);
            this.lvPkgProductSuppliers.TabIndex = 1;
            this.lvPkgProductSuppliers.UseCompatibleStateImageBehavior = false;
            this.lvPkgProductSuppliers.View = System.Windows.Forms.View.Details;
            // 
            // colProdSup
            // 
            this.colProdSup.Text = "ID";
            this.colProdSup.Width = 50;
            // 
            // colProdName
            // 
            this.colProdName.Text = "Product";
            this.colProdName.Width = 160;
            // 
            // colSupName
            // 
            this.colSupName.Text = "Supplier";
            this.colSupName.Width = 150;
            // 
            // lblPkgProducts
            // 
            this.lblPkgProducts.AutoSize = true;
            this.lblPkgProducts.Depth = 0;
            this.lblPkgProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblPkgProducts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPkgProducts.Location = new System.Drawing.Point(3, 7);
            this.lblPkgProducts.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPkgProducts.Name = "lblPkgProducts";
            this.lblPkgProducts.Size = new System.Drawing.Size(164, 24);
            this.lblPkgProducts.TabIndex = 0;
            this.lblPkgProducts.Text = "Product Suppliers:";
            // 
            // panFormGrp
            // 
            this.panFormGrp.BackColor = System.Drawing.Color.White;
            this.panFormGrp.Controls.Add(this.txtCommission);
            this.panFormGrp.Controls.Add(this.dtpEndDate);
            this.panFormGrp.Controls.Add(this.lblCommission);
            this.panFormGrp.Controls.Add(this.txtBasePrice);
            this.panFormGrp.Controls.Add(this.lblEndDate);
            this.panFormGrp.Controls.Add(this.lblBasePrice);
            this.panFormGrp.Controls.Add(this.dtpStartDate);
            this.panFormGrp.Controls.Add(this.txtDesc);
            this.panFormGrp.Controls.Add(this.txtPkgName);
            this.panFormGrp.Controls.Add(this.lblDesc);
            this.panFormGrp.Controls.Add(this.lblPkgName);
            this.panFormGrp.Controls.Add(this.lblStartDate);
            this.panFormGrp.Location = new System.Drawing.Point(12, 0);
            this.panFormGrp.Name = "panFormGrp";
            this.panFormGrp.Size = new System.Drawing.Size(353, 286);
            this.panFormGrp.TabIndex = 7;
            // 
            // txtCommission
            // 
            this.txtCommission.Depth = 0;
            this.txtCommission.Hint = "";
            this.txtCommission.Location = new System.Drawing.Point(151, 251);
            this.txtCommission.MaxLength = 12;
            this.txtCommission.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCommission.Name = "txtCommission";
            this.txtCommission.PasswordChar = '\0';
            this.txtCommission.SelectedText = "";
            this.txtCommission.SelectionLength = 0;
            this.txtCommission.SelectionStart = 0;
            this.txtCommission.Size = new System.Drawing.Size(196, 28);
            this.txtCommission.TabIndex = 1;
            this.txtCommission.TabStop = false;
            this.txtCommission.UseSystemPasswordChar = false;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndDate.Location = new System.Drawing.Point(152, 77);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(196, 22);
            this.dtpEndDate.TabIndex = 1;
            // 
            // lblCommission
            // 
            this.lblCommission.AutoSize = true;
            this.lblCommission.Depth = 0;
            this.lblCommission.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblCommission.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCommission.Location = new System.Drawing.Point(1, 251);
            this.lblCommission.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCommission.Name = "lblCommission";
            this.lblCommission.Size = new System.Drawing.Size(119, 24);
            this.lblCommission.TabIndex = 0;
            this.lblCommission.Text = "Commission:";
            // 
            // txtBasePrice
            // 
            this.txtBasePrice.Depth = 0;
            this.txtBasePrice.Hint = "";
            this.txtBasePrice.Location = new System.Drawing.Point(151, 211);
            this.txtBasePrice.MaxLength = 10;
            this.txtBasePrice.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBasePrice.Name = "txtBasePrice";
            this.txtBasePrice.PasswordChar = '\0';
            this.txtBasePrice.SelectedText = "";
            this.txtBasePrice.SelectionLength = 0;
            this.txtBasePrice.SelectionStart = 0;
            this.txtBasePrice.Size = new System.Drawing.Size(196, 28);
            this.txtBasePrice.TabIndex = 1;
            this.txtBasePrice.TabStop = false;
            this.txtBasePrice.UseSystemPasswordChar = false;
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Depth = 0;
            this.lblEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblEndDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblEndDate.Location = new System.Drawing.Point(3, 77);
            this.lblEndDate.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(93, 24);
            this.lblEndDate.TabIndex = 0;
            this.lblEndDate.Text = "End Date:";
            // 
            // lblBasePrice
            // 
            this.lblBasePrice.AutoSize = true;
            this.lblBasePrice.Depth = 0;
            this.lblBasePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblBasePrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblBasePrice.Location = new System.Drawing.Point(1, 211);
            this.lblBasePrice.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblBasePrice.Name = "lblBasePrice";
            this.lblBasePrice.Size = new System.Drawing.Size(105, 24);
            this.lblBasePrice.TabIndex = 0;
            this.lblBasePrice.Text = "Base Price:";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartDate.Location = new System.Drawing.Point(152, 38);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(197, 22);
            this.dtpStartDate.TabIndex = 1;
            // 
            // txtDesc
            // 
            this.txtDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDesc.Location = new System.Drawing.Point(151, 113);
            this.txtDesc.MaxLength = 50;
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(196, 82);
            this.txtDesc.TabIndex = 1;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Depth = 0;
            this.lblDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDesc.Location = new System.Drawing.Point(2, 110);
            this.lblDesc.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(109, 24);
            this.lblDesc.TabIndex = 0;
            this.lblDesc.Text = "Description:";
            // 
            // lblPkgName
            // 
            this.lblPkgName.AutoSize = true;
            this.lblPkgName.Depth = 0;
            this.lblPkgName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblPkgName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPkgName.Location = new System.Drawing.Point(2, 4);
            this.lblPkgName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPkgName.Name = "lblPkgName";
            this.lblPkgName.Size = new System.Drawing.Size(144, 24);
            this.lblPkgName.TabIndex = 0;
            this.lblPkgName.Text = "Package Name:";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Depth = 0;
            this.lblStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblStartDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblStartDate.Location = new System.Drawing.Point(3, 38);
            this.lblStartDate.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(94, 24);
            this.lblStartDate.TabIndex = 0;
            this.lblStartDate.Text = "Start Date:";
            // 
            // panForm
            // 
            this.panForm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panForm.BackColor = System.Drawing.Color.White;
            this.panForm.Controls.Add(this.panFormGrp);
            this.panForm.Controls.Add(this.panPkgImage);
            this.panForm.Controls.Add(this.panProdSup);
            this.panForm.Location = new System.Drawing.Point(0, 3);
            this.panForm.Name = "panForm";
            this.panForm.Size = new System.Drawing.Size(745, 696);
            this.panForm.TabIndex = 11;
            // 
            // panMain
            // 
            this.panMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panMain.BackColor = System.Drawing.Color.White;
            this.panMain.Controls.Add(this.mdivMainBtn);
            this.panMain.Controls.Add(this.panDock);
            this.panMain.Controls.Add(this.fpanButtons);
            this.panMain.Controls.Add(this.panForm);
            this.panMain.Location = new System.Drawing.Point(-1, 63);
            this.panMain.Name = "panMain";
            this.panMain.Size = new System.Drawing.Size(745, 743);
            this.panMain.TabIndex = 12;
            // 
            // panDock
            // 
            this.panDock.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panDock.BackColor = System.Drawing.Color.White;
            this.panDock.Location = new System.Drawing.Point(745, 0);
            this.panDock.Name = "panDock";
            this.panDock.Size = new System.Drawing.Size(0, 743);
            this.panDock.TabIndex = 11;
            // 
            // txtPkgName
            // 
            this.txtPkgName.Depth = 0;
            this.txtPkgName.Hint = "";
            this.txtPkgName.Location = new System.Drawing.Point(152, 4);
            this.txtPkgName.MaxLength = 32767;
            this.txtPkgName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPkgName.Name = "txtPkgName";
            this.txtPkgName.PasswordChar = '\0';
            this.txtPkgName.SelectedText = "";
            this.txtPkgName.SelectionLength = 0;
            this.txtPkgName.SelectionStart = 0;
            this.txtPkgName.Size = new System.Drawing.Size(196, 28);
            this.txtPkgName.TabIndex = 1;
            this.txtPkgName.TabStop = false;
            this.txtPkgName.UseSystemPasswordChar = false;
            this.txtPkgName.Leave += new System.EventHandler(this.txtPkgName_Leave);
            this.txtPkgName.TextChanged += new System.EventHandler(this.txtPkgName_TextChanged);
            // 
            // frmPkgAddModify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 805);
            this.Controls.Add(this.panMain);
            this.Name = "frmPkgAddModify";
            this.Sizable = false;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.fpanButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPkgImage)).EndInit();
            this.panPkgImage.ResumeLayout(false);
            this.panPkgImage.PerformLayout();
            this.panProdSup.ResumeLayout(false);
            this.panProdSup.PerformLayout();
            this.panFormGrp.ResumeLayout(false);
            this.panFormGrp.PerformLayout();
            this.panForm.ResumeLayout(false);
            this.panMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialRaisedButton btnAddModify;
        private MaterialRaisedButton btnCancel;
        private System.Windows.Forms.FlowLayoutPanel fpanButtons;
        private System.Windows.Forms.OpenFileDialog ofdImage;
        private System.Windows.Forms.PictureBox pbPkgImage;
        private MaterialLabel lblPkgImage;
        private System.Windows.Forms.Panel panPkgImage;
        private MaterialLabel lblPkgProducts;
        private System.Windows.Forms.ColumnHeader colSupName;
        private System.Windows.Forms.ColumnHeader colProdName;
        private System.Windows.Forms.ColumnHeader colProdSup;
        private MaterialFlatButton btnPSAdd;
        private MaterialFlatButton btnPSDelete;
        private MaterialFlatButton btnPSEdit;
        private System.Windows.Forms.Panel panProdSup;
        private MaterialLabel lblCommission;
        private MaterialSingleLineTextField txtCommission;
        private MaterialLabel lblBasePrice;
        private MaterialSingleLineTextField txtBasePrice;
        private MaterialLabel lblEndDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private MaterialLabel lblDesc;
        private System.Windows.Forms.TextBox txtDesc;
        private MaterialLabel lblStartDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Panel panFormGrp;
        private MaterialLabel lblPkgName;
        private MaterialSkin.Controls.MaterialComboBox txtPkgName;
        private System.Windows.Forms.Panel panForm;
        private System.Windows.Forms.Panel panMain;
        private System.Windows.Forms.Panel panDock;
        private MaterialFlatButton btnImage;
        private MaterialDivider mdivMainBtn;
        private MaterialListView lvPkgProductSuppliers;
    }
}