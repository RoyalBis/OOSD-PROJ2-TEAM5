using System.Windows.Forms;
using MaterialSkin.Controls;

namespace TravelExpertsApp
{
    partial class DockPkgViewer
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DockPkgViewer));
            this.panMain = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.panel3 = new System.Windows.Forms.Panel();
            this.mlblCommission = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.mlblBasePrice = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.mlblEndDate = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.mlblStartDate = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.mlvProdSuppliers = new MaterialSkin.Controls.MaterialListView();
            this.colID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colProduct = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSupplier = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.pbPkgImage = new System.Windows.Forms.PictureBox();
            this.panBanner = new System.Windows.Forms.Panel();
            this.pbLeft = new System.Windows.Forms.PictureBox();
            this.pbRight = new System.Windows.Forms.PictureBox();
            this.lblPkg = new MaterialSkin.Controls.MaterialRaisedButton();
            this.mdivBanner = new MaterialSkin.Controls.MaterialDivider();
            this.panButtons = new System.Windows.Forms.Panel();
            this.mbtnDelete = new MaterialSkin.Controls.MaterialFlatButton();
            this.mbtnAccept = new MaterialSkin.Controls.MaterialFlatButton();
            this.mbtnCancel = new MaterialSkin.Controls.MaterialFlatButton();
            this.mdivBtns = new MaterialSkin.Controls.MaterialDivider();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panMain.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPkgImage)).BeginInit();
            this.panBanner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRight)).BeginInit();
            this.panButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // panMain
            // 
            this.panMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panMain.BackColor = System.Drawing.Color.White;
            this.panMain.Controls.Add(this.panel1);
            this.panMain.Controls.Add(this.panBanner);
            this.panMain.Controls.Add(this.mdivBanner);
            this.panMain.Controls.Add(this.panButtons);
            this.panMain.Controls.Add(this.mdivBtns);
            this.panMain.Location = new System.Drawing.Point(9, 0);
            this.panMain.Name = "panMain";
            this.panMain.Size = new System.Drawing.Size(641, 760);
            this.panMain.TabIndex = 27;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.materialDivider1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txtDescription);
            this.panel1.Controls.Add(this.materialLabel2);
            this.panel1.Controls.Add(this.mlvProdSuppliers);
            this.panel1.Controls.Add(this.materialLabel1);
            this.panel1.Controls.Add(this.pbPkgImage);
            this.panel1.Location = new System.Drawing.Point(4, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(633, 636);
            this.panel1.TabIndex = 28;
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(0, 362);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(634, 1);
            this.materialDivider1.TabIndex = 30;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.mlblCommission);
            this.panel3.Controls.Add(this.materialLabel6);
            this.panel3.Controls.Add(this.mlblBasePrice);
            this.panel3.Controls.Add(this.materialLabel8);
            this.panel3.Location = new System.Drawing.Point(0, 181);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(633, 46);
            this.panel3.TabIndex = 29;
            // 
            // mlblCommission
            // 
            this.mlblCommission.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mlblCommission.AutoSize = true;
            this.mlblCommission.Depth = 0;
            this.mlblCommission.Font = new System.Drawing.Font("Roboto", 11F);
            this.mlblCommission.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlblCommission.Location = new System.Drawing.Point(445, 10);
            this.mlblCommission.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlblCommission.Name = "mlblCommission";
            this.mlblCommission.Size = new System.Drawing.Size(113, 24);
            this.mlblCommission.TabIndex = 3;
            this.mlblCommission.Text = "PkgEndDate";
            // 
            // materialLabel6
            // 
            this.materialLabel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Enabled = false;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(316, 10);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(123, 24);
            this.materialLabel6.TabIndex = 2;
            this.materialLabel6.Text = "Commission:";
            // 
            // mlblBasePrice
            // 
            this.mlblBasePrice.AutoSize = true;
            this.mlblBasePrice.Depth = 0;
            this.mlblBasePrice.Font = new System.Drawing.Font("Roboto", 11F);
            this.mlblBasePrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlblBasePrice.Location = new System.Drawing.Point(115, 10);
            this.mlblBasePrice.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlblBasePrice.Name = "mlblBasePrice";
            this.mlblBasePrice.Size = new System.Drawing.Size(120, 24);
            this.mlblBasePrice.TabIndex = 1;
            this.mlblBasePrice.Text = "PkgStartDate";
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Enabled = false;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(4, 10);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(105, 24);
            this.materialLabel8.TabIndex = 0;
            this.materialLabel8.Text = "Base Price:";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.mlblEndDate);
            this.panel2.Controls.Add(this.materialLabel5);
            this.panel2.Controls.Add(this.mlblStartDate);
            this.panel2.Controls.Add(this.materialLabel3);
            this.panel2.Location = new System.Drawing.Point(0, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(633, 46);
            this.panel2.TabIndex = 28;
            // 
            // mlblEndDate
            // 
            this.mlblEndDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mlblEndDate.AutoSize = true;
            this.mlblEndDate.Depth = 0;
            this.mlblEndDate.Font = new System.Drawing.Font("Roboto", 11F);
            this.mlblEndDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlblEndDate.Location = new System.Drawing.Point(412, 10);
            this.mlblEndDate.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlblEndDate.Name = "mlblEndDate";
            this.mlblEndDate.Size = new System.Drawing.Size(113, 24);
            this.mlblEndDate.TabIndex = 3;
            this.mlblEndDate.Text = "PkgEndDate";
            // 
            // materialLabel5
            // 
            this.materialLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Enabled = false;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(316, 10);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(90, 24);
            this.materialLabel5.TabIndex = 2;
            this.materialLabel5.Text = "End Date:";
            // 
            // mlblStartDate
            // 
            this.mlblStartDate.AutoSize = true;
            this.mlblStartDate.Depth = 0;
            this.mlblStartDate.Font = new System.Drawing.Font("Roboto", 11F);
            this.mlblStartDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlblStartDate.Location = new System.Drawing.Point(107, 10);
            this.mlblStartDate.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlblStartDate.Name = "mlblStartDate";
            this.mlblStartDate.Size = new System.Drawing.Size(120, 24);
            this.mlblStartDate.TabIndex = 1;
            this.mlblStartDate.Text = "PkgStartDate";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Enabled = false;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(4, 10);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(97, 24);
            this.materialLabel3.TabIndex = 0;
            this.materialLabel3.Text = "Start Date:";
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(7, 81);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(622, 94);
            this.txtDescription.TabIndex = 1;
            // 
            // materialLabel2
            // 
            this.materialLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Enabled = false;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(3, 53);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(111, 24);
            this.materialLabel2.TabIndex = 0;
            this.materialLabel2.Text = "Description:";
            // 
            // mlvProdSuppliers
            // 
            this.mlvProdSuppliers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mlvProdSuppliers.BackColor = System.Drawing.Color.White;
            this.mlvProdSuppliers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mlvProdSuppliers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colID,
            this.colProduct,
            this.colSupplier});
            this.mlvProdSuppliers.Depth = 0;
            this.mlvProdSuppliers.FullRowSelect = true;
            this.mlvProdSuppliers.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.mlvProdSuppliers.Location = new System.Drawing.Point(0, 257);
            this.mlvProdSuppliers.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mlvProdSuppliers.MouseState = MaterialSkin.MouseState.OUT;
            this.mlvProdSuppliers.Name = "mlvProdSuppliers";
            this.mlvProdSuppliers.OwnerDraw = true;
            this.mlvProdSuppliers.Size = new System.Drawing.Size(633, 103);
            this.mlvProdSuppliers.TabIndex = 27;
            this.mlvProdSuppliers.UseCompatibleStateImageBehavior = false;
            this.mlvProdSuppliers.View = System.Windows.Forms.View.Details;
            // 
            // colID
            // 
            this.colID.Text = "ID";
            this.colID.Width = 50;
            // 
            // colProduct
            // 
            this.colProduct.Text = "Product";
            this.colProduct.Width = 150;
            // 
            // colSupplier
            // 
            this.colSupplier.Text = "Supplier";
            this.colSupplier.Width = 433;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Enabled = false;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(3, 230);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(165, 24);
            this.materialLabel1.TabIndex = 22;
            this.materialLabel1.Text = "Product Suppliers:";
            // 
            // pbPkgImage
            // 
            this.pbPkgImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbPkgImage.Location = new System.Drawing.Point(0, 366);
            this.pbPkgImage.Name = "pbPkgImage";
            this.pbPkgImage.Size = new System.Drawing.Size(633, 270);
            this.pbPkgImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPkgImage.TabIndex = 24;
            this.pbPkgImage.TabStop = false;
            // 
            // panBanner
            // 
            this.panBanner.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panBanner.Controls.Add(this.pbLeft);
            this.panBanner.Controls.Add(this.pbRight);
            this.panBanner.Controls.Add(this.lblPkg);
            this.panBanner.Location = new System.Drawing.Point(3, 6);
            this.panBanner.Name = "panBanner";
            this.panBanner.Size = new System.Drawing.Size(635, 51);
            this.panBanner.TabIndex = 25;
            // 
            // pbLeft
            // 
            this.pbLeft.BackColor = System.Drawing.Color.Transparent;
            this.pbLeft.Image = ((System.Drawing.Image)(resources.GetObject("pbLeft.Image")));
            this.pbLeft.Location = new System.Drawing.Point(-1, 0);
            this.pbLeft.Name = "pbLeft";
            this.pbLeft.Size = new System.Drawing.Size(52, 50);
            this.pbLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbLeft.TabIndex = 17;
            this.pbLeft.TabStop = false;
            this.pbLeft.Click += new System.EventHandler(this.pbLeft_Click);
            this.pbLeft.MouseEnter += new System.EventHandler(this.pbLeft_MouseEnter);
            this.pbLeft.MouseLeave += new System.EventHandler(this.pbLeft_MouseLeave);
            // 
            // pbRight
            // 
            this.pbRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbRight.BackColor = System.Drawing.Color.Transparent;
            this.pbRight.Image = ((System.Drawing.Image)(resources.GetObject("pbRight.Image")));
            this.pbRight.Location = new System.Drawing.Point(582, 0);
            this.pbRight.Name = "pbRight";
            this.pbRight.Size = new System.Drawing.Size(52, 50);
            this.pbRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbRight.TabIndex = 18;
            this.pbRight.TabStop = false;
            this.pbRight.Click += new System.EventHandler(this.pbRight_Click);
            this.pbRight.MouseEnter += new System.EventHandler(this.pbRight_MouseEnter);
            this.pbRight.MouseLeave += new System.EventHandler(this.pbRight_MouseLeave);
            // 
            // lblPkg
            // 
            this.lblPkg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPkg.Depth = 0;
            this.lblPkg.Location = new System.Drawing.Point(-1, 0);
            this.lblPkg.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPkg.Name = "lblPkg";
            this.lblPkg.Primary = true;
            this.lblPkg.Size = new System.Drawing.Size(635, 50);
            this.lblPkg.TabIndex = 19;
            this.lblPkg.Text = "Pkg Name";
            this.lblPkg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPkg.UseVisualStyleBackColor = true;
            // 
            // mdivBanner
            // 
            this.mdivBanner.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mdivBanner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mdivBanner.Depth = 0;
            this.mdivBanner.Location = new System.Drawing.Point(3, 63);
            this.mdivBanner.MouseState = MaterialSkin.MouseState.HOVER;
            this.mdivBanner.Name = "mdivBanner";
            this.mdivBanner.Size = new System.Drawing.Size(635, 1);
            this.mdivBanner.TabIndex = 16;
            this.mdivBanner.Text = "materialDivider1";
            // 
            // panButtons
            // 
            this.panButtons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panButtons.BackColor = System.Drawing.Color.White;
            this.panButtons.Controls.Add(this.mbtnDelete);
            this.panButtons.Controls.Add(this.mbtnAccept);
            this.panButtons.Controls.Add(this.mbtnCancel);
            this.panButtons.Location = new System.Drawing.Point(3, 717);
            this.panButtons.Name = "panButtons";
            this.panButtons.Size = new System.Drawing.Size(638, 40);
            this.panButtons.TabIndex = 14;
            // 
            // mbtnDelete
            // 
            this.mbtnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mbtnDelete.AutoSize = true;
            this.mbtnDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbtnDelete.Depth = 0;
            this.mbtnDelete.Location = new System.Drawing.Point(327, 4);
            this.mbtnDelete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mbtnDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbtnDelete.Name = "mbtnDelete";
            this.mbtnDelete.Primary = true;
            this.mbtnDelete.Size = new System.Drawing.Size(155, 36);
            this.mbtnDelete.TabIndex = 2;
            this.mbtnDelete.Text = "Delete Package";
            this.mbtnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.mbtnDelete.UseVisualStyleBackColor = true;
            this.mbtnDelete.Click += new System.EventHandler(this.mbtnDelete_Click);
            // 
            // mbtnAccept
            // 
            this.mbtnAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mbtnAccept.AutoSize = true;
            this.mbtnAccept.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbtnAccept.Depth = 0;
            this.mbtnAccept.Location = new System.Drawing.Point(490, 4);
            this.mbtnAccept.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mbtnAccept.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbtnAccept.Name = "mbtnAccept";
            this.mbtnAccept.Primary = true;
            this.mbtnAccept.Size = new System.Drawing.Size(145, 36);
            this.mbtnAccept.TabIndex = 0;
            this.mbtnAccept.Text = "Edit Package...";
            this.mbtnAccept.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.mbtnAccept.UseVisualStyleBackColor = true;
            this.mbtnAccept.Click += new System.EventHandler(this.mbtnAccept_Click);
            // 
            // mbtnCancel
            // 
            this.mbtnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.mbtnCancel.AutoSize = true;
            this.mbtnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbtnCancel.Depth = 0;
            this.mbtnCancel.Location = new System.Drawing.Point(4, 4);
            this.mbtnCancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mbtnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbtnCancel.Name = "mbtnCancel";
            this.mbtnCancel.Primary = true;
            this.mbtnCancel.Size = new System.Drawing.Size(65, 36);
            this.mbtnCancel.TabIndex = 1;
            this.mbtnCancel.Text = "Close";
            this.mbtnCancel.UseVisualStyleBackColor = true;
            this.mbtnCancel.Click += new System.EventHandler(this.mbtnCancel_Click);
            // 
            // mdivBtns
            // 
            this.mdivBtns.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mdivBtns.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mdivBtns.Depth = 0;
            this.mdivBtns.Location = new System.Drawing.Point(1, 713);
            this.mdivBtns.MouseState = MaterialSkin.MouseState.HOVER;
            this.mdivBtns.Name = "mdivBtns";
            this.mdivBtns.Size = new System.Drawing.Size(624, 1);
            this.mdivBtns.TabIndex = 13;
            this.mdivBtns.Text = "materialDivider1";
            // 
            // DockPkgViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.panMain);
            this.Name = "DockPkgViewer";
            this.Size = new System.Drawing.Size(650, 760);
            this.Load += new System.EventHandler(this.DockPkgViewer_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Dock_MouseClick);
            this.MouseEnter += new System.EventHandler(this.Dock_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.Dock_MouseLeave);
            this.panMain.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPkgImage)).EndInit();
            this.panBanner.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRight)).EndInit();
            this.panButtons.ResumeLayout(false);
            this.panButtons.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panMain;
        private Panel panButtons;
        private MaterialFlatButton mbtnAccept;
        private MaterialFlatButton mbtnCancel;
        private MaterialDivider mdivBtns;
        private MaterialDivider mdivBanner;
        private PictureBox pbLeft;
        private PictureBox pbRight;
        private MaterialRaisedButton lblPkg;
        private ToolTip toolTip1;
        private Panel panBanner;
        private PictureBox pbPkgImage;
        private MaterialLabel materialLabel1;
        private ColumnHeader colSupplier;
        private ColumnHeader colProduct;
        private ColumnHeader colID;
        private MaterialListView mlvProdSuppliers;
        private MaterialLabel materialLabel2;
        private TextBox txtDescription;
        private Panel panel1;
        private Panel panel2;
        private MaterialLabel mlblEndDate;
        private MaterialLabel materialLabel5;
        private MaterialLabel mlblStartDate;
        private MaterialLabel materialLabel3;
        private Panel panel3;
        private MaterialLabel mlblCommission;
        private MaterialLabel materialLabel6;
        private MaterialLabel mlblBasePrice;
        private MaterialLabel materialLabel8;
        private MaterialFlatButton mbtnDelete;
        private MaterialDivider materialDivider1;
    }
}
