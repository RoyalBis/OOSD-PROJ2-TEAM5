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
            this.mbtnAccept = new MaterialSkin.Controls.MaterialRaisedButton();
            this.mbtnCancel = new MaterialSkin.Controls.MaterialRaisedButton();
            this.listView1 = new System.Windows.Forms.ListView();
            this.mrbProdSup = new MaterialSkin.Controls.MaterialRadioButton();
            this.mrbProd = new MaterialSkin.Controls.MaterialRadioButton();
            this.fpanRadio = new System.Windows.Forms.FlowLayoutPanel();
            this.mlblSearchby = new MaterialSkin.Controls.MaterialLabel();
            this.mrbSup = new MaterialSkin.Controls.MaterialRadioButton();
            this.mtxtSearch = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblSearch = new MaterialSkin.Controls.MaterialLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.fpanButtons.SuspendLayout();
            this.fpanRadio.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fpanButtons
            // 
            this.fpanButtons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fpanButtons.BackColor = System.Drawing.SystemColors.Control;
            this.fpanButtons.Controls.Add(this.mbtnAccept);
            this.fpanButtons.Controls.Add(this.mbtnCancel);
            this.fpanButtons.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.fpanButtons.Location = new System.Drawing.Point(20, 643);
            this.fpanButtons.Name = "fpanButtons";
            this.fpanButtons.Size = new System.Drawing.Size(252, 36);
            this.fpanButtons.TabIndex = 12;
            // 
            // mbtnAccept
            // 
            this.mbtnAccept.Depth = 0;
            this.mbtnAccept.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.mbtnAccept.Location = new System.Drawing.Point(139, 3);
            this.mbtnAccept.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbtnAccept.Name = "mbtnAccept";
            this.mbtnAccept.Primary = true;
            this.mbtnAccept.Size = new System.Drawing.Size(110, 31);
            this.mbtnAccept.TabIndex = 0;
            this.mbtnAccept.Text = "Accept";
            this.mbtnAccept.UseVisualStyleBackColor = true;
            // 
            // mbtnCancel
            // 
            this.mbtnCancel.Depth = 0;
            this.mbtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.mbtnCancel.Location = new System.Drawing.Point(23, 3);
            this.mbtnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbtnCancel.Name = "mbtnCancel";
            this.mbtnCancel.Primary = true;
            this.mbtnCancel.Size = new System.Drawing.Size(110, 31);
            this.mbtnCancel.TabIndex = 1;
            this.mbtnCancel.Text = "Cancel";
            this.mbtnCancel.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.BackColor = System.Drawing.SystemColors.Control;
            this.listView1.Location = new System.Drawing.Point(20, 228);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(254, 409);
            this.listView1.TabIndex = 21;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // mrbProdSup
            // 
            this.mrbProdSup.Depth = 0;
            this.mrbProdSup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mrbProdSup.Font = new System.Drawing.Font("Roboto", 10F);
            this.mrbProdSup.Location = new System.Drawing.Point(0, 24);
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
            this.mrbProd.Location = new System.Drawing.Point(0, 54);
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
            this.fpanRadio.BackColor = System.Drawing.SystemColors.Control;
            this.fpanRadio.Controls.Add(this.mlblSearchby);
            this.fpanRadio.Controls.Add(this.mrbProdSup);
            this.fpanRadio.Controls.Add(this.mrbProd);
            this.fpanRadio.Controls.Add(this.mrbSup);
            this.fpanRadio.Location = new System.Drawing.Point(20, 93);
            this.fpanRadio.Name = "fpanRadio";
            this.fpanRadio.Size = new System.Drawing.Size(254, 129);
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
            this.mrbSup.Location = new System.Drawing.Point(0, 84);
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
            this.mtxtSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.mtxtSearch.Name = "mtxtSearch";
            this.mtxtSearch.PasswordChar = '\0';
            this.mtxtSearch.SelectedText = "";
            this.mtxtSearch.SelectionLength = 0;
            this.mtxtSearch.SelectionStart = 0;
            this.mtxtSearch.Size = new System.Drawing.Size(238, 28);
            this.mtxtSearch.TabIndex = 14;
            this.mtxtSearch.UseSystemPasswordChar = false;
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
            this.lblSearch.Text = "Product Supplier ID:";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.mtxtSearch);
            this.panel1.Controls.Add(this.lblSearch);
            this.panel1.Location = new System.Drawing.Point(20, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(254, 83);
            this.panel1.TabIndex = 26;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Location = new System.Drawing.Point(9, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(273, 682);
            this.panel2.TabIndex = 27;
            // 
            // DockProdSupSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.fpanRadio);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.fpanButtons);
            this.Controls.Add(this.panel2);
            this.Name = "DockProdSupSearch";
            this.Size = new System.Drawing.Size(282, 682);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DockProdSupSearch_MouseClick);
            this.MouseEnter += new System.EventHandler(this.DockProdSupSearch_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.DockProdSupSearch_MouseLeave);
            this.fpanButtons.ResumeLayout(false);
            this.fpanRadio.ResumeLayout(false);
            this.fpanRadio.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel fpanButtons;
        private MaterialSkin.Controls.MaterialRaisedButton mbtnAccept;
        private MaterialSkin.Controls.MaterialRaisedButton mbtnCancel;
        private System.Windows.Forms.ListView listView1;
        private MaterialSkin.Controls.MaterialRadioButton mrbProdSup;
        private MaterialSkin.Controls.MaterialRadioButton mrbProd;
        private System.Windows.Forms.FlowLayoutPanel fpanRadio;
        private MaterialSkin.Controls.MaterialRadioButton mrbSup;
        private MaterialSkin.Controls.MaterialLabel mlblSearchby;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialLabel lblSearch;
        private MaterialSkin.Controls.MaterialSingleLineTextField mtxtSearch;
        private System.Windows.Forms.Panel panel2;
    }
}
