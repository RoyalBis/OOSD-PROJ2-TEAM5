using System.Windows.Forms;
using MaterialSkin.Controls;

namespace TravelExpertsApp
{
    partial class DockProdSupSearch
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
            this.panButtons = new System.Windows.Forms.Panel();
            this.mbtnAccept = new MaterialSkin.Controls.MaterialFlatButton();
            this.mbtnCancel = new MaterialSkin.Controls.MaterialFlatButton();
            this.fpanRadio = new System.Windows.Forms.Panel();
            this.mlblSearchby = new MaterialSkin.Controls.MaterialLabel();
            this.mrbProdSup = new MaterialSkin.Controls.MaterialRadioButton();
            this.mrbProd = new MaterialSkin.Controls.MaterialRadioButton();
            this.mrbSup = new MaterialSkin.Controls.MaterialRadioButton();
            this.panSearch = new System.Windows.Forms.Panel();
            this.pbSearch = new System.Windows.Forms.PictureBox();
            this.mtxtSearch = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblSearch = new MaterialSkin.Controls.MaterialLabel();
            this.panMain = new System.Windows.Forms.Panel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.mdivResults = new MaterialSkin.Controls.MaterialDivider();
            this.mdivBtns = new MaterialSkin.Controls.MaterialDivider();
            this.lvResults = new MaterialSkin.Controls.MaterialListView();
            this.colID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colProduct = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSupplier = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mctxtResults = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.mctxtResultsAdd = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mctxtResultsClose = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.panButtons.SuspendLayout();
            this.fpanRadio.SuspendLayout();
            this.panSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).BeginInit();
            this.panMain.SuspendLayout();
            this.mctxtResults.SuspendLayout();
            this.SuspendLayout();
            // 
            // panButtons
            // 
            this.panButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panButtons.BackColor = System.Drawing.Color.White;
            this.panButtons.Controls.Add(this.mbtnAccept);
            this.panButtons.Controls.Add(this.mbtnCancel);
            this.panButtons.Location = new System.Drawing.Point(12, 639);
            this.panButtons.Name = "panButtons";
            this.panButtons.Size = new System.Drawing.Size(522, 40);
            this.panButtons.TabIndex = 12;
            // 
            // mbtnAccept
            // 
            this.mbtnAccept.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.mbtnAccept.AutoSize = true;
            this.mbtnAccept.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbtnAccept.Depth = 0;
            this.mbtnAccept.Location = new System.Drawing.Point(243, 4);
            this.mbtnAccept.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mbtnAccept.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbtnAccept.Name = "mbtnAccept";
            this.mbtnAccept.Primary = true;
            this.mbtnAccept.Size = new System.Drawing.Size(271, 36);
            this.mbtnAccept.TabIndex = 0;
            this.mbtnAccept.Text = "Add Selection(s) to Package";
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
            this.mbtnCancel.Location = new System.Drawing.Point(20, 4);
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
            // fpanRadio
            // 
            this.fpanRadio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fpanRadio.BackColor = System.Drawing.Color.White;
            this.fpanRadio.Controls.Add(this.mlblSearchby);
            this.fpanRadio.Controls.Add(this.mrbProdSup);
            this.fpanRadio.Controls.Add(this.mrbProd);
            this.fpanRadio.Controls.Add(this.mrbSup);
            this.fpanRadio.Location = new System.Drawing.Point(11, 133);
            this.fpanRadio.Name = "fpanRadio";
            this.fpanRadio.Size = new System.Drawing.Size(506, 129);
            this.fpanRadio.TabIndex = 25;
            // 
            // mlblSearchby
            // 
            this.mlblSearchby.AutoSize = true;
            this.mlblSearchby.Depth = 0;
            this.mlblSearchby.Font = new System.Drawing.Font("Roboto", 11F);
            this.mlblSearchby.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlblSearchby.Location = new System.Drawing.Point(3, 3);
            this.mlblSearchby.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlblSearchby.Name = "mlblSearchby";
            this.mlblSearchby.Size = new System.Drawing.Size(97, 24);
            this.mlblSearchby.TabIndex = 26;
            this.mlblSearchby.Text = "Search by:";
            // 
            // mrbProdSup
            // 
            this.mrbProdSup.Checked = true;
            this.mrbProdSup.Depth = 0;
            this.mrbProdSup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mrbProdSup.Font = new System.Drawing.Font("Roboto", 10F);
            this.mrbProdSup.Location = new System.Drawing.Point(7, 32);
            this.mrbProdSup.Margin = new System.Windows.Forms.Padding(0);
            this.mrbProdSup.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mrbProdSup.MouseState = MaterialSkin.MouseState.HOVER;
            this.mrbProdSup.Name = "mrbProdSup";
            this.mrbProdSup.Ripple = true;
            this.mrbProdSup.Size = new System.Drawing.Size(243, 30);
            this.mrbProdSup.TabIndex = 23;
            this.mrbProdSup.TabStop = true;
            this.mrbProdSup.Text = "Product Supplier ID";
            this.mrbProdSup.UseVisualStyleBackColor = true;
            this.mrbProdSup.CheckedChanged += new System.EventHandler(this.mrbProdSup_CheckedChanged);
            // 
            // mrbProd
            // 
            this.mrbProd.Depth = 0;
            this.mrbProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mrbProd.Font = new System.Drawing.Font("Roboto", 10F);
            this.mrbProd.Location = new System.Drawing.Point(7, 62);
            this.mrbProd.Margin = new System.Windows.Forms.Padding(0);
            this.mrbProd.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mrbProd.MouseState = MaterialSkin.MouseState.HOVER;
            this.mrbProd.Name = "mrbProd";
            this.mrbProd.Ripple = true;
            this.mrbProd.Size = new System.Drawing.Size(243, 30);
            this.mrbProd.TabIndex = 24;
            this.mrbProd.TabStop = true;
            this.mrbProd.Text = "Product ID or Name";
            this.mrbProd.UseVisualStyleBackColor = true;
            this.mrbProd.CheckedChanged += new System.EventHandler(this.mrbProd_CheckedChanged);
            // 
            // mrbSup
            // 
            this.mrbSup.Depth = 0;
            this.mrbSup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mrbSup.Font = new System.Drawing.Font("Roboto", 10F);
            this.mrbSup.Location = new System.Drawing.Point(7, 92);
            this.mrbSup.Margin = new System.Windows.Forms.Padding(0);
            this.mrbSup.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mrbSup.MouseState = MaterialSkin.MouseState.HOVER;
            this.mrbSup.Name = "mrbSup";
            this.mrbSup.Ripple = true;
            this.mrbSup.Size = new System.Drawing.Size(243, 30);
            this.mrbSup.TabIndex = 25;
            this.mrbSup.Text = "Supplier ID or Name";
            this.mrbSup.UseVisualStyleBackColor = true;
            this.mrbSup.CheckedChanged += new System.EventHandler(this.mrbSup_CheckedChanged);
            // 
            // panSearch
            // 
            this.panSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panSearch.BackColor = System.Drawing.Color.White;
            this.panSearch.Controls.Add(this.pbSearch);
            this.panSearch.Controls.Add(this.mtxtSearch);
            this.panSearch.Controls.Add(this.lblSearch);
            this.panSearch.Location = new System.Drawing.Point(11, 44);
            this.panSearch.Name = "panSearch";
            this.panSearch.Size = new System.Drawing.Size(506, 83);
            this.panSearch.TabIndex = 26;
            // 
            // pbSearch
            // 
            this.pbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbSearch.Image = global::TravelExpertsApp.Properties.Resources.magnifier_24__bluegrey;
            this.pbSearch.Location = new System.Drawing.Point(475, 40);
            this.pbSearch.Name = "pbSearch";
            this.pbSearch.Size = new System.Drawing.Size(28, 28);
            this.pbSearch.TabIndex = 15;
            this.pbSearch.TabStop = false;
            // 
            // mtxtSearch
            // 
            this.mtxtSearch.Depth = 0;
            this.mtxtSearch.Hint = "Search for...";
            this.mtxtSearch.Location = new System.Drawing.Point(7, 40);
            this.mtxtSearch.MaxLength = 32767;
            this.mtxtSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.mtxtSearch.Name = "mtxtSearch";
            this.mtxtSearch.PasswordChar = '\0';
            this.mtxtSearch.SelectedText = "";
            this.mtxtSearch.SelectionLength = 0;
            this.mtxtSearch.SelectionStart = 0;
            this.mtxtSearch.Size = new System.Drawing.Size(462, 28);
            this.mtxtSearch.TabIndex = 14;
            this.mtxtSearch.TabStop = false;
            this.mtxtSearch.UseSystemPasswordChar = false;
            this.mtxtSearch.Enter += new System.EventHandler(this.mtxtSearch_Enter);
            this.mtxtSearch.Leave += new System.EventHandler(this.mtxtSearch_Leave);
            this.mtxtSearch.TextChanged += new System.EventHandler(this.mtxtSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.BackColor = System.Drawing.Color.Transparent;
            this.lblSearch.Depth = 0;
            this.lblSearch.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSearch.Location = new System.Drawing.Point(3, 13);
            this.lblSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(500, 24);
            this.lblSearch.TabIndex = 13;
            this.lblSearch.Text = "Search for a Product Supplier...";
            // 
            // panMain
            // 
            this.panMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panMain.BackColor = System.Drawing.Color.White;
            this.panMain.Controls.Add(this.materialLabel1);
            this.panMain.Controls.Add(this.mdivResults);
            this.panMain.Controls.Add(this.mdivBtns);
            this.panMain.Controls.Add(this.panSearch);
            this.panMain.Controls.Add(this.fpanRadio);
            this.panMain.Location = new System.Drawing.Point(9, 0);
            this.panMain.Name = "panMain";
            this.panMain.Size = new System.Drawing.Size(525, 682);
            this.panMain.TabIndex = 27;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(7, 17);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(214, 24);
            this.materialLabel1.TabIndex = 27;
            this.materialLabel1.Text = "Add Product Suppliers...";
            // 
            // mdivResults
            // 
            this.mdivResults.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mdivResults.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mdivResults.Depth = 0;
            this.mdivResults.Location = new System.Drawing.Point(11, 261);
            this.mdivResults.MouseState = MaterialSkin.MouseState.HOVER;
            this.mdivResults.Name = "mdivResults";
            this.mdivResults.Size = new System.Drawing.Size(508, 1);
            this.mdivResults.TabIndex = 3;
            this.mdivResults.Text = "materialDivider1";
            // 
            // mdivBtns
            // 
            this.mdivBtns.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mdivBtns.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mdivBtns.Depth = 0;
            this.mdivBtns.Location = new System.Drawing.Point(10, 635);
            this.mdivBtns.MouseState = MaterialSkin.MouseState.HOVER;
            this.mdivBtns.Name = "mdivBtns";
            this.mdivBtns.Size = new System.Drawing.Size(508, 1);
            this.mdivBtns.TabIndex = 2;
            this.mdivBtns.Text = "materialDivider1";
            // 
            // lvResults
            // 
            this.lvResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvResults.BackColor = System.Drawing.Color.White;
            this.lvResults.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colID,
            this.colProduct,
            this.colSupplier});
            this.lvResults.ContextMenuStrip = this.mctxtResults;
            this.lvResults.Depth = 0;
            this.lvResults.FullRowSelect = true;
            this.lvResults.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvResults.Location = new System.Drawing.Point(20, 268);
            this.lvResults.MouseLocation = new System.Drawing.Point(-1, -1);
            this.lvResults.MouseState = MaterialSkin.MouseState.OUT;
            this.lvResults.Name = "lvResults";
            this.lvResults.OwnerDraw = true;
            this.lvResults.Size = new System.Drawing.Size(506, 358);
            this.lvResults.TabIndex = 21;
            this.lvResults.UseCompatibleStateImageBehavior = false;
            this.lvResults.View = System.Windows.Forms.View.Details;
            this.lvResults.SelectedIndexChanged += new System.EventHandler(this.lvResults_SelectedIndexChanged);
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
            this.colSupplier.Width = 306;
            // 
            // mctxtResults
            // 
            this.mctxtResults.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mctxtResults.Depth = 0;
            this.mctxtResults.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mctxtResults.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mctxtResultsAdd,
            this.toolStripSeparator1,
            this.mctxtResultsClose});
            this.mctxtResults.MouseState = MaterialSkin.MouseState.HOVER;
            this.mctxtResults.Name = "mcontext1";
            this.mctxtResults.Size = new System.Drawing.Size(275, 62);
            // 
            // mctxtResultsAdd
            // 
            this.mctxtResultsAdd.AutoSize = false;
            this.mctxtResultsAdd.Enabled = false;
            this.mctxtResultsAdd.Name = "mctxtResultsAdd";
            this.mctxtResultsAdd.Size = new System.Drawing.Size(274, 26);
            this.mctxtResultsAdd.Text = "Add Selected Items";
            this.mctxtResultsAdd.Click += new System.EventHandler(this.mctxtResultsAdd_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(271, 6);
            // 
            // mctxtResultsClose
            // 
            this.mctxtResultsClose.AutoSize = false;
            this.mctxtResultsClose.Name = "mctxtResultsClose";
            this.mctxtResultsClose.Size = new System.Drawing.Size(274, 26);
            this.mctxtResultsClose.Text = "Close Product Supplier Panel";
            this.mctxtResultsClose.Click += new System.EventHandler(this.mctxtResultsClose_Click);
            // 
            // DockProdSupSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.panButtons);
            this.Controls.Add(this.lvResults);
            this.Controls.Add(this.panMain);
            this.Name = "DockProdSupSearch";
            this.Size = new System.Drawing.Size(534, 682);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DockProdSupSearch_MouseClick);
            this.MouseEnter += new System.EventHandler(this.DockProdSupSearch_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.DockProdSupSearch_MouseLeave);
            this.panButtons.ResumeLayout(false);
            this.panButtons.PerformLayout();
            this.fpanRadio.ResumeLayout(false);
            this.fpanRadio.PerformLayout();
            this.panSearch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).EndInit();
            this.panMain.ResumeLayout(false);
            this.panMain.PerformLayout();
            this.mctxtResults.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panButtons;
        private MaterialSkin.Controls.MaterialFlatButton mbtnAccept;
        private MaterialSkin.Controls.MaterialFlatButton mbtnCancel;
        private MaterialListView lvResults;
        private MaterialSkin.Controls.MaterialRadioButton mrbProdSup;
        private MaterialSkin.Controls.MaterialRadioButton mrbProd;
        private Panel fpanRadio;
        private MaterialSkin.Controls.MaterialRadioButton mrbSup;
        private MaterialSkin.Controls.MaterialLabel mlblSearchby;
        private System.Windows.Forms.Panel panSearch;
        private MaterialSkin.Controls.MaterialLabel lblSearch;
        private MaterialSkin.Controls.MaterialSingleLineTextField mtxtSearch;
        private System.Windows.Forms.Panel panMain;
        private System.Windows.Forms.ColumnHeader colID;
        private System.Windows.Forms.ColumnHeader colProduct;
        private System.Windows.Forms.ColumnHeader colSupplier;
        private MaterialDivider mdivBtns;
        private MaterialDivider mdivResults;
        private MaterialContextMenuStrip mctxtResults;
        private MaterialToolStripMenuItem mctxtResultsAdd;
        private ToolStripSeparator toolStripSeparator1;
        private MaterialToolStripMenuItem mctxtResultsClose;
        private MaterialLabel materialLabel1;
        private PictureBox pbSearch;
    }
}
