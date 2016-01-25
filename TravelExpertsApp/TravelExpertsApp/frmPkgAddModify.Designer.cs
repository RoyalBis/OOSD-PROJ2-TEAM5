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
            this.lblPkgImage = new System.Windows.Forms.Label();
            this.panPkgImage = new System.Windows.Forms.Panel();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.panProdSup = new System.Windows.Forms.Panel();
            this.materialDivider2 = new MaterialSkin.Controls.MaterialDivider();
            this.btnPSDelete = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnPSAdd = new MaterialSkin.Controls.MaterialFlatButton();
            this.lvPkgProductSuppliers = new MaterialSkin.Controls.MaterialListView();
            this.colProdSup = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colProdName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSupName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblPkgProducts = new System.Windows.Forms.Label();
            this.panFormGrp = new System.Windows.Forms.Panel();
            this.panStartDate = new System.Windows.Forms.Panel();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblPkgName = new System.Windows.Forms.Label();
            this.panDesc = new System.Windows.Forms.Panel();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.panEndDate = new System.Windows.Forms.Panel();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.panBasePrice = new System.Windows.Forms.Panel();
            this.txtBasePrice = new System.Windows.Forms.TextBox();
            this.lblBasePrice = new System.Windows.Forms.Label();
            this.panCommission = new System.Windows.Forms.Panel();
            this.txtCommission = new System.Windows.Forms.TextBox();
            this.lblCommission = new System.Windows.Forms.Label();
            this.panForm = new System.Windows.Forms.Panel();
            this.panMain = new System.Windows.Forms.Panel();
            this.panDock = new System.Windows.Forms.Panel();
            this.txtPkgName = new MaterialSkin.Controls.MaterialComboBox();
            this.fpanButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPkgImage)).BeginInit();
            this.panPkgImage.SuspendLayout();
            this.panProdSup.SuspendLayout();
            this.panFormGrp.SuspendLayout();
            this.panStartDate.SuspendLayout();
            this.panDesc.SuspendLayout();
            this.panEndDate.SuspendLayout();
            this.panBasePrice.SuspendLayout();
            this.panCommission.SuspendLayout();
            this.panForm.SuspendLayout();
            this.panMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnImage
            // 
            this.btnImage.AutoSize = true;
            this.btnImage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnImage.Depth = 0;
            this.btnImage.Location = new System.Drawing.Point(582, 359);
            this.btnImage.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnImage.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnImage.Name = "btnImage";
            this.btnImage.Primary = true;
            this.btnImage.Size = new System.Drawing.Size(145, 36);
            this.btnImage.TabIndex = 2;
            this.btnImage.Text = "Select Image...";
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
            this.pbPkgImage.Location = new System.Drawing.Point(0, 21);
            this.pbPkgImage.Name = "pbPkgImage";
            this.pbPkgImage.Size = new System.Drawing.Size(739, 336);
            this.pbPkgImage.TabIndex = 9;
            this.pbPkgImage.TabStop = false;
            // 
            // lblPkgImage
            // 
            this.lblPkgImage.AutoSize = true;
            this.lblPkgImage.Location = new System.Drawing.Point(15, 1);
            this.lblPkgImage.Name = "lblPkgImage";
            this.lblPkgImage.Size = new System.Drawing.Size(109, 17);
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
            this.panPkgImage.Size = new System.Drawing.Size(739, 401);
            this.panPkgImage.TabIndex = 10;
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(0, 699);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(748, 1);
            this.materialDivider1.TabIndex = 10;
            this.materialDivider1.Text = "mdivMainBtn";
            // 
            // panProdSup
            // 
            this.panProdSup.BackColor = System.Drawing.Color.White;
            this.panProdSup.Controls.Add(this.materialDivider2);
            this.panProdSup.Controls.Add(this.btnPSDelete);
            this.panProdSup.Controls.Add(this.btnPSAdd);
            this.panProdSup.Controls.Add(this.lvPkgProductSuppliers);
            this.panProdSup.Controls.Add(this.lblPkgProducts);
            this.panProdSup.Location = new System.Drawing.Point(374, 0);
            this.panProdSup.Name = "panProdSup";
            this.panProdSup.Size = new System.Drawing.Size(353, 286);
            this.panProdSup.TabIndex = 5;
            // 
            // materialDivider2
            // 
            this.materialDivider2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider2.Depth = 0;
            this.materialDivider2.Location = new System.Drawing.Point(0, 244);
            this.materialDivider2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider2.Name = "materialDivider2";
            this.materialDivider2.Size = new System.Drawing.Size(353, 1);
            this.materialDivider2.TabIndex = 6;
            this.materialDivider2.Text = "materialDivider2";
            // 
            // btnPSDelete
            // 
            this.btnPSDelete.AutoSize = true;
            this.btnPSDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPSDelete.Depth = 0;
            this.btnPSDelete.Location = new System.Drawing.Point(206, 244);
            this.btnPSDelete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnPSDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPSDelete.Name = "btnPSDelete";
            this.btnPSDelete.Primary = true;
            this.btnPSDelete.Size = new System.Drawing.Size(73, 36);
            this.btnPSDelete.TabIndex = 4;
            this.btnPSDelete.Text = "Delete";
            this.btnPSDelete.UseVisualStyleBackColor = true;
            this.btnPSDelete.Click += new System.EventHandler(this.btnPSDelete_Click);
            // 
            // btnPSAdd
            // 
            this.btnPSAdd.AutoSize = true;
            this.btnPSAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPSAdd.Depth = 0;
            this.btnPSAdd.Location = new System.Drawing.Point(287, 244);
            this.btnPSAdd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnPSAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPSAdd.Name = "btnPSAdd";
            this.btnPSAdd.Primary = true;
            this.btnPSAdd.Size = new System.Drawing.Size(61, 36);
            this.btnPSAdd.TabIndex = 3;
            this.btnPSAdd.Text = "Add...";
            this.btnPSAdd.UseVisualStyleBackColor = true;
            this.btnPSAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lvPkgProductSuppliers
            // 
            this.lvPkgProductSuppliers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvPkgProductSuppliers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colProdSup,
            this.colProdName,
            this.colSupName});
            this.lvPkgProductSuppliers.Depth = 0;
            this.lvPkgProductSuppliers.FullRowSelect = true;
            this.lvPkgProductSuppliers.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvPkgProductSuppliers.LabelEdit = true;
            this.lvPkgProductSuppliers.Location = new System.Drawing.Point(6, 28);
            this.lvPkgProductSuppliers.MouseLocation = new System.Drawing.Point(-1, -1);
            this.lvPkgProductSuppliers.MouseState = MaterialSkin.MouseState.OUT;
            this.lvPkgProductSuppliers.Name = "lvPkgProductSuppliers";
            this.lvPkgProductSuppliers.OwnerDraw = true;
            this.lvPkgProductSuppliers.Scrollable = false;
            this.lvPkgProductSuppliers.ShowGroups = false;
            this.lvPkgProductSuppliers.Size = new System.Drawing.Size(342, 214);
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
            this.colProdName.Width = 150;
            // 
            // colSupName
            // 
            this.colSupName.Text = "Supplier";
            this.colSupName.Width = 150;
            // 
            // lblPkgProducts
            // 
            this.lblPkgProducts.AutoSize = true;
            this.lblPkgProducts.Location = new System.Drawing.Point(3, 7);
            this.lblPkgProducts.Name = "lblPkgProducts";
            this.lblPkgProducts.Size = new System.Drawing.Size(124, 17);
            this.lblPkgProducts.TabIndex = 0;
            this.lblPkgProducts.Text = "Product Suppliers:";
            // 
            // panFormGrp
            // 
            this.panFormGrp.BackColor = System.Drawing.Color.White;
            this.panFormGrp.Controls.Add(this.txtPkgName);
            this.panFormGrp.Controls.Add(this.panStartDate);
            this.panFormGrp.Controls.Add(this.lblPkgName);
            this.panFormGrp.Controls.Add(this.panDesc);
            this.panFormGrp.Controls.Add(this.panEndDate);
            this.panFormGrp.Controls.Add(this.panBasePrice);
            this.panFormGrp.Controls.Add(this.panCommission);
            this.panFormGrp.Location = new System.Drawing.Point(12, 0);
            this.panFormGrp.Name = "panFormGrp";
            this.panFormGrp.Size = new System.Drawing.Size(353, 286);
            this.panFormGrp.TabIndex = 7;
            // 
            // panStartDate
            // 
            this.panStartDate.BackColor = System.Drawing.Color.White;
            this.panStartDate.Controls.Add(this.dtpStartDate);
            this.panStartDate.Controls.Add(this.lblStartDate);
            this.panStartDate.Location = new System.Drawing.Point(0, 38);
            this.panStartDate.Name = "panStartDate";
            this.panStartDate.Size = new System.Drawing.Size(353, 32);
            this.panStartDate.TabIndex = 2;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartDate.Location = new System.Drawing.Point(118, 4);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(231, 22);
            this.dtpStartDate.TabIndex = 1;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(3, 7);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(76, 17);
            this.lblStartDate.TabIndex = 0;
            this.lblStartDate.Text = "Start Date:";
            // 
            // lblPkgName
            // 
            this.lblPkgName.AutoSize = true;
            this.lblPkgName.Location = new System.Drawing.Point(2, 7);
            this.lblPkgName.Name = "lblPkgName";
            this.lblPkgName.Size = new System.Drawing.Size(108, 17);
            this.lblPkgName.TabIndex = 0;
            this.lblPkgName.Text = "Package Name:";
            // 
            // panDesc
            // 
            this.panDesc.BackColor = System.Drawing.Color.White;
            this.panDesc.Controls.Add(this.txtDesc);
            this.panDesc.Controls.Add(this.lblDesc);
            this.panDesc.Location = new System.Drawing.Point(0, 114);
            this.panDesc.Name = "panDesc";
            this.panDesc.Size = new System.Drawing.Size(353, 96);
            this.panDesc.TabIndex = 4;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(118, 7);
            this.txtDesc.MaxLength = 50;
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(230, 82);
            this.txtDesc.TabIndex = 1;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(3, 7);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(83, 17);
            this.lblDesc.TabIndex = 0;
            this.lblDesc.Text = "Description:";
            // 
            // panEndDate
            // 
            this.panEndDate.BackColor = System.Drawing.Color.White;
            this.panEndDate.Controls.Add(this.dtpEndDate);
            this.panEndDate.Controls.Add(this.lblEndDate);
            this.panEndDate.Location = new System.Drawing.Point(0, 76);
            this.panEndDate.Name = "panEndDate";
            this.panEndDate.Size = new System.Drawing.Size(353, 32);
            this.panEndDate.TabIndex = 3;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndDate.Location = new System.Drawing.Point(118, 4);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(230, 22);
            this.dtpEndDate.TabIndex = 1;
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(3, 7);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(71, 17);
            this.lblEndDate.TabIndex = 0;
            this.lblEndDate.Text = "End Date:";
            // 
            // panBasePrice
            // 
            this.panBasePrice.BackColor = System.Drawing.Color.White;
            this.panBasePrice.Controls.Add(this.txtBasePrice);
            this.panBasePrice.Controls.Add(this.lblBasePrice);
            this.panBasePrice.Location = new System.Drawing.Point(0, 216);
            this.panBasePrice.Name = "panBasePrice";
            this.panBasePrice.Size = new System.Drawing.Size(353, 32);
            this.panBasePrice.TabIndex = 2;
            // 
            // txtBasePrice
            // 
            this.txtBasePrice.Location = new System.Drawing.Point(119, 4);
            this.txtBasePrice.MaxLength = 10;
            this.txtBasePrice.Name = "txtBasePrice";
            this.txtBasePrice.Size = new System.Drawing.Size(230, 22);
            this.txtBasePrice.TabIndex = 1;
            // 
            // lblBasePrice
            // 
            this.lblBasePrice.AutoSize = true;
            this.lblBasePrice.Location = new System.Drawing.Point(3, 7);
            this.lblBasePrice.Name = "lblBasePrice";
            this.lblBasePrice.Size = new System.Drawing.Size(80, 17);
            this.lblBasePrice.TabIndex = 0;
            this.lblBasePrice.Text = "Base Price:";
            // 
            // panCommission
            // 
            this.panCommission.BackColor = System.Drawing.Color.White;
            this.panCommission.Controls.Add(this.txtCommission);
            this.panCommission.Controls.Add(this.lblCommission);
            this.panCommission.Location = new System.Drawing.Point(0, 254);
            this.panCommission.Name = "panCommission";
            this.panCommission.Size = new System.Drawing.Size(353, 32);
            this.panCommission.TabIndex = 3;
            // 
            // txtCommission
            // 
            this.txtCommission.Location = new System.Drawing.Point(119, 4);
            this.txtCommission.MaxLength = 12;
            this.txtCommission.Name = "txtCommission";
            this.txtCommission.Size = new System.Drawing.Size(230, 22);
            this.txtCommission.TabIndex = 1;
            // 
            // lblCommission
            // 
            this.lblCommission.AutoSize = true;
            this.lblCommission.Location = new System.Drawing.Point(3, 7);
            this.lblCommission.Name = "lblCommission";
            this.lblCommission.Size = new System.Drawing.Size(87, 17);
            this.lblCommission.TabIndex = 0;
            this.lblCommission.Text = "Commission:";
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
            this.panForm.Size = new System.Drawing.Size(742, 696);
            this.panForm.TabIndex = 11;
            // 
            // panMain
            // 
            this.panMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panMain.BackColor = System.Drawing.Color.White;
            this.panMain.Controls.Add(this.materialDivider1);
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
            this.panDock.BackColor = System.Drawing.Color.White;
            this.panDock.Dock = System.Windows.Forms.DockStyle.Right;
            this.panDock.Location = new System.Drawing.Point(745, 0);
            this.panDock.Name = "panDock";
            this.panDock.Size = new System.Drawing.Size(0, 743);
            this.panDock.TabIndex = 11;
            // 
            // txtPkgName
            // 
            this.txtPkgName.Depth = 0;
            this.txtPkgName.Hint = "";
            this.txtPkgName.Location = new System.Drawing.Point(118, 4);
            this.txtPkgName.MaxLength = 32767;
            this.txtPkgName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPkgName.Name = "txtPkgName";
            this.txtPkgName.PasswordChar = '\0';
            this.txtPkgName.SelectedText = "";
            this.txtPkgName.SelectionLength = 0;
            this.txtPkgName.SelectionStart = 0;
            this.txtPkgName.Size = new System.Drawing.Size(230, 28);
            this.txtPkgName.TabIndex = 1;
            this.txtPkgName.TabStop = false;
            this.txtPkgName.UseSystemPasswordChar = false;
            // 
            // frmPkgAddModify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 805);
            this.Controls.Add(this.panMain);
            this.Name = "frmPkgAddModify";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.fpanButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPkgImage)).EndInit();
            this.panPkgImage.ResumeLayout(false);
            this.panPkgImage.PerformLayout();
            this.panProdSup.ResumeLayout(false);
            this.panProdSup.PerformLayout();
            this.panFormGrp.ResumeLayout(false);
            this.panFormGrp.PerformLayout();
            this.panStartDate.ResumeLayout(false);
            this.panStartDate.PerformLayout();
            this.panDesc.ResumeLayout(false);
            this.panDesc.PerformLayout();
            this.panEndDate.ResumeLayout(false);
            this.panEndDate.PerformLayout();
            this.panBasePrice.ResumeLayout(false);
            this.panBasePrice.PerformLayout();
            this.panCommission.ResumeLayout(false);
            this.panCommission.PerformLayout();
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
        private System.Windows.Forms.Label lblPkgImage;
        private System.Windows.Forms.Panel panPkgImage;
        private System.Windows.Forms.Label lblPkgProducts;
        private System.Windows.Forms.ColumnHeader colSupName;
        private System.Windows.Forms.ColumnHeader colProdName;
        private System.Windows.Forms.ColumnHeader colProdSup;
        private MaterialListView lvPkgProductSuppliers;
        private MaterialFlatButton btnPSAdd;
        private MaterialFlatButton btnPSDelete;
        private System.Windows.Forms.Panel panProdSup;
        private System.Windows.Forms.Label lblCommission;
        private System.Windows.Forms.TextBox txtCommission;
        private System.Windows.Forms.Panel panCommission;
        private System.Windows.Forms.Label lblBasePrice;
        private System.Windows.Forms.TextBox txtBasePrice;
        private System.Windows.Forms.Panel panBasePrice;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Panel panEndDate;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Panel panDesc;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Panel panStartDate;
        private System.Windows.Forms.Panel panFormGrp;
        private System.Windows.Forms.Label lblPkgName;
        private MaterialSkin.Controls.MaterialComboBox txtPkgName;
        private System.Windows.Forms.Panel panForm;
        private System.Windows.Forms.Panel panMain;
        private System.Windows.Forms.Panel panDock;
        private MaterialFlatButton btnImage;
        private MaterialDivider materialDivider1;
        private MaterialDivider materialDivider2;
    }
}