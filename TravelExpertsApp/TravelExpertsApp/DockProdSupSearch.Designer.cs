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
            this.fpanRadio = new System.Windows.Forms.Panel();
            this.mlblSearchby = new MaterialSkin.Controls.MaterialLabel();
            this.mrbProdSup = new MaterialSkin.Controls.MaterialRadioButton();
            this.mrbProd = new MaterialSkin.Controls.MaterialRadioButton();
            this.mrbSup = new MaterialSkin.Controls.MaterialRadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mtxtSearch = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblSearch = new MaterialSkin.Controls.MaterialLabel();
            this.panMain = new System.Windows.Forms.Panel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.lvResults = new MaterialSkin.Controls.MaterialListView();
            this.colPrdSpId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPrd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSup = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mbtnCancel = new MaterialSkin.Controls.MaterialFlatButton();
            this.mbtnAccept = new MaterialSkin.Controls.MaterialFlatButton();
            this.fpanButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.fpanRadio.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panMain.SuspendLayout();
            this.fpanButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // fpanRadio
            // 
            this.fpanRadio.BackColor = System.Drawing.Color.White;
            this.fpanRadio.Controls.Add(this.mlblSearchby);
            this.fpanRadio.Controls.Add(this.mrbProdSup);
            this.fpanRadio.Controls.Add(this.mrbProd);
            this.fpanRadio.Controls.Add(this.mrbSup);
            this.fpanRadio.Location = new System.Drawing.Point(11, 155);
            this.fpanRadio.Name = "fpanRadio";
            this.fpanRadio.Size = new System.Drawing.Size(513, 129);
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
            // mrbProdSup
            // 
            this.mrbProdSup.AutoSize = true;
            this.mrbProdSup.Checked = true;
            this.mrbProdSup.Depth = 0;
            this.mrbProdSup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mrbProdSup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.mrbProdSup.Location = new System.Drawing.Point(7, 27);
            this.mrbProdSup.Margin = new System.Windows.Forms.Padding(0);
            this.mrbProdSup.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mrbProdSup.MouseState = MaterialSkin.MouseState.HOVER;
            this.mrbProdSup.Name = "mrbProdSup";
            this.mrbProdSup.Ripple = true;
            this.mrbProdSup.Size = new System.Drawing.Size(179, 30);
            this.mrbProdSup.TabIndex = 23;
            this.mrbProdSup.TabStop = true;
            this.mrbProdSup.Text = "Product Supplier ID";
            this.mrbProdSup.UseVisualStyleBackColor = true;
            this.mrbProdSup.CheckedChanged += new System.EventHandler(this.mrbProdSup_CheckedChanged);
            // 
            // mrbProd
            // 
            this.mrbProd.AutoSize = true;
            this.mrbProd.Depth = 0;
            this.mrbProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mrbProd.Font = new System.Drawing.Font("Roboto", 10F);
            this.mrbProd.Location = new System.Drawing.Point(7, 57);
            this.mrbProd.Margin = new System.Windows.Forms.Padding(0);
            this.mrbProd.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mrbProd.MouseState = MaterialSkin.MouseState.HOVER;
            this.mrbProd.Name = "mrbProd";
            this.mrbProd.Ripple = true;
            this.mrbProd.Size = new System.Drawing.Size(181, 30);
            this.mrbProd.TabIndex = 24;
            this.mrbProd.Text = "Product ID or Name";
            this.mrbProd.UseVisualStyleBackColor = true;
            this.mrbProd.CheckedChanged += new System.EventHandler(this.mrbProd_CheckedChanged);
            // 
            // mrbSup
            // 
            this.mrbSup.AutoSize = true;
            this.mrbSup.Depth = 0;
            this.mrbSup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mrbSup.Font = new System.Drawing.Font("Roboto", 10F);
            this.mrbSup.Location = new System.Drawing.Point(7, 87);
            this.mrbSup.Margin = new System.Windows.Forms.Padding(0);
            this.mrbSup.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mrbSup.MouseState = MaterialSkin.MouseState.HOVER;
            this.mrbSup.Name = "mrbSup";
            this.mrbSup.Ripple = true;
            this.mrbSup.Size = new System.Drawing.Size(184, 30);
            this.mrbSup.TabIndex = 25;
            this.mrbSup.Text = "Supplier ID or Name";
            this.mrbSup.UseVisualStyleBackColor = true;
            this.mrbSup.CheckedChanged += new System.EventHandler(this.mrbSup_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.mtxtSearch);
            this.panel1.Controls.Add(this.lblSearch);
            this.panel1.Location = new System.Drawing.Point(11, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(513, 83);
            this.panel1.TabIndex = 26;
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
            this.mtxtSearch.Size = new System.Drawing.Size(502, 28);
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
            this.lblSearch.Size = new System.Drawing.Size(291, 24);
            this.lblSearch.TabIndex = 13;
            this.lblSearch.Text = "Search Product Suppliers:";
            // 
            // panMain
            // 
            this.panMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panMain.BackColor = System.Drawing.Color.White;
            this.panMain.Controls.Add(this.materialLabel1);
            this.panMain.Controls.Add(this.panel1);
            this.panMain.Controls.Add(this.fpanRadio);
            this.panMain.Controls.Add(this.lvResults);
            this.panMain.Location = new System.Drawing.Point(9, 0);
            this.panMain.Name = "panMain";
            this.panMain.Size = new System.Drawing.Size(532, 682);
            this.panMain.TabIndex = 27;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(14, 17);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(214, 24);
            this.materialLabel1.TabIndex = 27;
            this.materialLabel1.Text = "Add Product Suppliers...";
            // 
            // lvResults
            // 
            this.lvResults.BackColor = System.Drawing.Color.White;
            this.lvResults.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colPrdSpId,
            this.colPrd,
            this.colSup});
            this.lvResults.Depth = 0;
            this.lvResults.FullRowSelect = true;
            this.lvResults.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvResults.LabelWrap = false;
            this.lvResults.Location = new System.Drawing.Point(11, 290);
            this.lvResults.MouseLocation = new System.Drawing.Point(-1, -1);
            this.lvResults.MouseState = MaterialSkin.MouseState.OUT;
            this.lvResults.Name = "lvResults";
            this.lvResults.OwnerDraw = true;
            this.lvResults.Size = new System.Drawing.Size(511, 347);
            this.lvResults.TabIndex = 21;
            this.lvResults.UseCompatibleStateImageBehavior = false;
            this.lvResults.View = System.Windows.Forms.View.Details;
            // 
            // colPrdSpId
            // 
            this.colPrdSpId.Text = "ID";
            this.colPrdSpId.Width = 50;
            // 
            // colPrd
            // 
            this.colPrd.Text = "Product";
            this.colPrd.Width = 150;
            // 
            // colSup
            // 
            this.colSup.Text = "Supplier";
            this.colSup.Width = 290;
            // 
            // mbtnCancel
            // 
            this.mbtnCancel.AutoSize = true;
            this.mbtnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbtnCancel.Depth = 0;
            this.mbtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.mbtnCancel.Location = new System.Drawing.Point(174, 6);
            this.mbtnCancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mbtnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbtnCancel.Name = "mbtnCancel";
            this.mbtnCancel.Primary = true;
            this.mbtnCancel.Size = new System.Drawing.Size(78, 36);
            this.mbtnCancel.TabIndex = 1;
            this.mbtnCancel.Text = "Cancel";
            this.mbtnCancel.UseVisualStyleBackColor = true;
            // 
            // mbtnAccept
            // 
            this.mbtnAccept.AutoSize = true;
            this.mbtnAccept.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbtnAccept.Depth = 0;
            this.mbtnAccept.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.mbtnAccept.Location = new System.Drawing.Point(260, 6);
            this.mbtnAccept.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mbtnAccept.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbtnAccept.Name = "mbtnAccept";
            this.mbtnAccept.Primary = true;
            this.mbtnAccept.Size = new System.Drawing.Size(249, 36);
            this.mbtnAccept.TabIndex = 0;
            this.mbtnAccept.Text = "Add Selection to Package";
            this.mbtnAccept.UseVisualStyleBackColor = true;
            // 
            // fpanButtons
            // 
            this.fpanButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.fpanButtons.BackColor = System.Drawing.Color.White;
            this.fpanButtons.Controls.Add(this.mbtnAccept);
            this.fpanButtons.Controls.Add(this.mbtnCancel);
            this.fpanButtons.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.fpanButtons.Location = new System.Drawing.Point(20, 643);
            this.fpanButtons.Name = "fpanButtons";
            this.fpanButtons.Size = new System.Drawing.Size(513, 36);
            this.fpanButtons.TabIndex = 12;
            // 
            // DockProdSupSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.fpanButtons);
            this.Controls.Add(this.panMain);
            this.Name = "DockProdSupSearch";
            this.Size = new System.Drawing.Size(541, 682);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DockProdSupSearch_MouseClick);
            this.MouseEnter += new System.EventHandler(this.DockProdSupSearch_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.DockProdSupSearch_MouseLeave);
            this.fpanRadio.ResumeLayout(false);
            this.fpanRadio.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panMain.ResumeLayout(false);
            this.panMain.PerformLayout();
            this.fpanButtons.ResumeLayout(false);
            this.fpanButtons.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialListView lvResults;
        private MaterialRadioButton mrbProdSup;
        private MaterialSkin.Controls.MaterialRadioButton mrbProd;
        private System.Windows.Forms.Panel fpanRadio;
        private MaterialSkin.Controls.MaterialRadioButton mrbSup;
        private MaterialSkin.Controls.MaterialLabel mlblSearchby;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialLabel lblSearch;
        private MaterialSkin.Controls.MaterialSingleLineTextField mtxtSearch;
        private System.Windows.Forms.Panel panMain;
        private System.Windows.Forms.ColumnHeader colPrdSpId;
        private System.Windows.Forms.ColumnHeader colPrd;
        private System.Windows.Forms.ColumnHeader colSup;
        private MaterialLabel materialLabel1;
        private FlowLayoutPanel fpanButtons;
        private MaterialFlatButton mbtnAccept;
        private MaterialFlatButton mbtnCancel;
    }
}
