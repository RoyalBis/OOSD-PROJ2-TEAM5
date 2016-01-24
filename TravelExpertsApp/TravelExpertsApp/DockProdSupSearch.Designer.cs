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
            this.fpanButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.mbtnAccept = new MaterialSkin.Controls.MaterialFlatButton();
            this.mbtnCancel = new MaterialSkin.Controls.MaterialFlatButton();
            this.lvResults = new MaterialSkin.Controls.MaterialListView();
            this.colID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colProduct = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSupplier = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mrbProdSup = new MaterialSkin.Controls.MaterialRadioButton();
            this.mrbProd = new MaterialSkin.Controls.MaterialRadioButton();
            this.fpanRadio = new System.Windows.Forms.Panel();
            this.mlblSearchby = new MaterialSkin.Controls.MaterialLabel();
            this.mrbSup = new MaterialSkin.Controls.MaterialRadioButton();
            this.mtxtSearch = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblSearch = new MaterialSkin.Controls.MaterialLabel();
            this.panSearch = new System.Windows.Forms.Panel();
            this.panMain = new System.Windows.Forms.Panel();
            this.fpanButtons.SuspendLayout();
            this.fpanRadio.SuspendLayout();
            this.panSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // fpanButtons
            // 
            this.fpanButtons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fpanButtons.BackColor = System.Drawing.Color.White;
            this.fpanButtons.Controls.Add(this.mbtnAccept);
            this.fpanButtons.Controls.Add(this.mbtnCancel);
            this.fpanButtons.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.fpanButtons.Location = new System.Drawing.Point(20, 643);
            this.fpanButtons.Name = "fpanButtons";
            this.fpanButtons.Size = new System.Drawing.Size(506, 36);
            this.fpanButtons.TabIndex = 12;
            // 
            // mbtnAccept
            // 
            this.mbtnAccept.AutoSize = true;
            this.mbtnAccept.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbtnAccept.Depth = 0;
            this.mbtnAccept.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.mbtnAccept.Location = new System.Drawing.Point(231, 6);
            this.mbtnAccept.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mbtnAccept.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbtnAccept.Name = "mbtnAccept";
            this.mbtnAccept.Primary = true;
            this.mbtnAccept.Size = new System.Drawing.Size(271, 36);
            this.mbtnAccept.TabIndex = 0;
            this.mbtnAccept.Text = "Add Selection(s) to Package";
            this.mbtnAccept.UseVisualStyleBackColor = true;
            // 
            // mbtnCancel
            // 
            this.mbtnCancel.AutoSize = true;
            this.mbtnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbtnCancel.Depth = 0;
            this.mbtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.mbtnCancel.Location = new System.Drawing.Point(145, 6);
            this.mbtnCancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mbtnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbtnCancel.Name = "mbtnCancel";
            this.mbtnCancel.Primary = true;
            this.mbtnCancel.Size = new System.Drawing.Size(78, 36);
            this.mbtnCancel.TabIndex = 1;
            this.mbtnCancel.Text = "Cancel";
            this.mbtnCancel.UseVisualStyleBackColor = true;
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
            this.lvResults.Depth = 0;
            this.lvResults.FullRowSelect = true;
            this.lvResults.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvResults.Location = new System.Drawing.Point(20, 228);
            this.lvResults.MouseLocation = new System.Drawing.Point(-1, -1);
            this.lvResults.MouseState = MaterialSkin.MouseState.OUT;
            this.lvResults.Name = "lvResults";
            this.lvResults.OwnerDraw = true;
            this.lvResults.Size = new System.Drawing.Size(506, 409);
            this.lvResults.TabIndex = 21;
            this.lvResults.UseCompatibleStateImageBehavior = false;
            this.lvResults.View = System.Windows.Forms.View.Details;
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
            this.colSupplier.Width = 300;
            // 
            // mrbProdSup
            // 
            this.mrbProdSup.Checked = true;
            this.mrbProdSup.Depth = 0;
            this.mrbProdSup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mrbProdSup.Font = new System.Drawing.Font("Roboto", 10F);
            this.mrbProdSup.Location = new System.Drawing.Point(7, 30);
            this.mrbProdSup.Margin = new System.Windows.Forms.Padding(0);
            this.mrbProdSup.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mrbProdSup.MouseState = MaterialSkin.MouseState.HOVER;
            this.mrbProdSup.Name = "mrbProdSup";
            this.mrbProdSup.Ripple = true;
            this.mrbProdSup.Size = new System.Drawing.Size(243, 30);
            this.mrbProdSup.TabIndex = 23;
            this.mrbProdSup.TabStop = true;
            this.mrbProdSup.Text = "Product Supplier";
            this.mrbProdSup.UseVisualStyleBackColor = true;
            // 
            // mrbProd
            // 
            this.mrbProd.Depth = 0;
            this.mrbProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mrbProd.Font = new System.Drawing.Font("Roboto", 10F);
            this.mrbProd.Location = new System.Drawing.Point(7, 90);
            this.mrbProd.Margin = new System.Windows.Forms.Padding(0);
            this.mrbProd.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mrbProd.MouseState = MaterialSkin.MouseState.HOVER;
            this.mrbProd.Name = "mrbProd";
            this.mrbProd.Ripple = true;
            this.mrbProd.Size = new System.Drawing.Size(243, 30);
            this.mrbProd.TabIndex = 24;
            this.mrbProd.TabStop = true;
            this.mrbProd.Text = "Products";
            this.mrbProd.UseVisualStyleBackColor = true;
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
            this.fpanRadio.Location = new System.Drawing.Point(20, 93);
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
            this.mlblSearchby.Location = new System.Drawing.Point(3, 0);
            this.mlblSearchby.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlblSearchby.Name = "mlblSearchby";
            this.mlblSearchby.Size = new System.Drawing.Size(97, 24);
            this.mlblSearchby.TabIndex = 26;
            this.mlblSearchby.Text = "Search by:";
            // 
            // mrbSup
            // 
            this.mrbSup.Depth = 0;
            this.mrbSup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mrbSup.Font = new System.Drawing.Font("Roboto", 10F);
            this.mrbSup.Location = new System.Drawing.Point(7, 60);
            this.mrbSup.Margin = new System.Windows.Forms.Padding(0);
            this.mrbSup.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mrbSup.MouseState = MaterialSkin.MouseState.HOVER;
            this.mrbSup.Name = "mrbSup";
            this.mrbSup.Ripple = true;
            this.mrbSup.Size = new System.Drawing.Size(243, 30);
            this.mrbSup.TabIndex = 25;
            this.mrbSup.TabStop = true;
            this.mrbSup.Text = "Supplier";
            this.mrbSup.UseVisualStyleBackColor = true;
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
            this.mtxtSearch.Size = new System.Drawing.Size(495, 28);
            this.mtxtSearch.TabIndex = 14;
            this.mtxtSearch.TabStop = false;
            this.mtxtSearch.UseSystemPasswordChar = false;
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
            this.lblSearch.Size = new System.Drawing.Size(251, 24);
            this.lblSearch.TabIndex = 13;
            this.lblSearch.Text = "Search for a Product Supplier";
            // 
            // panSearch
            // 
            this.panSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panSearch.BackColor = System.Drawing.Color.White;
            this.panSearch.Controls.Add(this.mtxtSearch);
            this.panSearch.Controls.Add(this.lblSearch);
            this.panSearch.Location = new System.Drawing.Point(20, 4);
            this.panSearch.Name = "panSearch";
            this.panSearch.Size = new System.Drawing.Size(506, 83);
            this.panSearch.TabIndex = 26;
            // 
            // panMain
            // 
            this.panMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panMain.BackColor = System.Drawing.Color.White;
            this.panMain.Location = new System.Drawing.Point(9, 0);
            this.panMain.Name = "panMain";
            this.panMain.Size = new System.Drawing.Size(525, 682);
            this.panMain.TabIndex = 27;
            // 
            // DockProdSupSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.panSearch);
            this.Controls.Add(this.fpanRadio);
            this.Controls.Add(this.lvResults);
            this.Controls.Add(this.fpanButtons);
            this.Controls.Add(this.panMain);
            this.Name = "DockProdSupSearch";
            this.Size = new System.Drawing.Size(534, 682);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DockProdSupSearch_MouseClick);
            this.MouseEnter += new System.EventHandler(this.DockProdSupSearch_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.DockProdSupSearch_MouseLeave);
            this.fpanButtons.ResumeLayout(false);
            this.fpanButtons.PerformLayout();
            this.fpanRadio.ResumeLayout(false);
            this.fpanRadio.PerformLayout();
            this.panSearch.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel fpanButtons;
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
    }
}
