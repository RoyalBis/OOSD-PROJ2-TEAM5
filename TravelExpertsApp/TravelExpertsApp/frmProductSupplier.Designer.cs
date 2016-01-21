namespace TravelExpertsApp
{
    partial class frmProductSupplier
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
            this.fpanButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.mbtnAccept = new MaterialSkin.Controls.MaterialRaisedButton();
            this.mbtnCancel = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lblID = new MaterialSkin.Controls.MaterialLabel();
            this.lblProductId = new MaterialSkin.Controls.MaterialLabel();
            this.lblSupplier = new MaterialSkin.Controls.MaterialLabel();
            this.cbProductSupplier = new System.Windows.Forms.ComboBox();
            this.cbProduct = new System.Windows.Forms.ComboBox();
            this.cbSupplier = new System.Windows.Forms.ComboBox();
            this.fpanButtons.SuspendLayout();
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
            this.fpanButtons.Location = new System.Drawing.Point(13, 188);
            this.fpanButtons.Name = "fpanButtons";
            this.fpanButtons.Size = new System.Drawing.Size(625, 36);
            this.fpanButtons.TabIndex = 0;
            // 
            // mbtnAccept
            // 
            this.mbtnAccept.Depth = 0;
            this.mbtnAccept.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.mbtnAccept.Location = new System.Drawing.Point(512, 3);
            this.mbtnAccept.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbtnAccept.Name = "mbtnAccept";
            this.mbtnAccept.Primary = true;
            this.mbtnAccept.Size = new System.Drawing.Size(110, 31);
            this.mbtnAccept.TabIndex = 0;
            this.mbtnAccept.Text = "Accept";
            this.mbtnAccept.UseVisualStyleBackColor = true;
            this.mbtnAccept.Click += new System.EventHandler(this.mbtnAccept_Click);
            // 
            // mbtnCancel
            // 
            this.mbtnCancel.Depth = 0;
            this.mbtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.mbtnCancel.Location = new System.Drawing.Point(396, 3);
            this.mbtnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbtnCancel.Name = "mbtnCancel";
            this.mbtnCancel.Primary = true;
            this.mbtnCancel.Size = new System.Drawing.Size(110, 31);
            this.mbtnCancel.TabIndex = 1;
            this.mbtnCancel.Text = "Cancel";
            this.mbtnCancel.UseVisualStyleBackColor = true;
            this.mbtnCancel.Click += new System.EventHandler(this.mbtnCancel_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.Color.White;
            this.lblID.Depth = 0;
            this.lblID.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblID.Location = new System.Drawing.Point(13, 83);
            this.lblID.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(177, 24);
            this.lblID.TabIndex = 3;
            this.lblID.Text = "Product Supplier ID:";
            // 
            // lblProductId
            // 
            this.lblProductId.AutoSize = true;
            this.lblProductId.BackColor = System.Drawing.Color.White;
            this.lblProductId.Depth = 0;
            this.lblProductId.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblProductId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblProductId.Location = new System.Drawing.Point(13, 117);
            this.lblProductId.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblProductId.Name = "lblProductId";
            this.lblProductId.Size = new System.Drawing.Size(81, 24);
            this.lblProductId.TabIndex = 5;
            this.lblProductId.Text = "Product:";
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.BackColor = System.Drawing.Color.White;
            this.lblSupplier.Depth = 0;
            this.lblSupplier.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblSupplier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSupplier.Location = new System.Drawing.Point(13, 151);
            this.lblSupplier.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(84, 24);
            this.lblSupplier.TabIndex = 8;
            this.lblSupplier.Text = "Supplier:";
            // 
            // cbProductSupplier
            // 
            this.cbProductSupplier.FormattingEnabled = true;
            this.cbProductSupplier.Location = new System.Drawing.Point(197, 81);
            this.cbProductSupplier.Name = "cbProductSupplier";
            this.cbProductSupplier.Size = new System.Drawing.Size(438, 24);
            this.cbProductSupplier.TabIndex = 9;
            this.cbProductSupplier.SelectedIndexChanged += new System.EventHandler(this.cbProductSupplier_SelectedIndexChanged);
            // 
            // cbProduct
            // 
            this.cbProduct.FormattingEnabled = true;
            this.cbProduct.Location = new System.Drawing.Point(197, 117);
            this.cbProduct.Name = "cbProduct";
            this.cbProduct.Size = new System.Drawing.Size(438, 24);
            this.cbProduct.TabIndex = 10;
            // 
            // cbSupplier
            // 
            this.cbSupplier.FormattingEnabled = true;
            this.cbSupplier.Location = new System.Drawing.Point(197, 151);
            this.cbSupplier.Name = "cbSupplier";
            this.cbSupplier.Size = new System.Drawing.Size(438, 24);
            this.cbSupplier.TabIndex = 11;
            // 
            // frmProductSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 237);
            this.ControlBox = false;
            this.Controls.Add(this.cbSupplier);
            this.Controls.Add(this.cbProduct);
            this.Controls.Add(this.cbProductSupplier);
            this.Controls.Add(this.lblSupplier);
            this.Controls.Add(this.lblProductId);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.fpanButtons);
            this.Name = "frmProductSupplier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Edit Product Suppliers";
            this.Load += new System.EventHandler(this.frmProductSupplier_Load);
            this.fpanButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel fpanButtons;
        private MaterialSkin.Controls.MaterialRaisedButton mbtnAccept;
        private MaterialSkin.Controls.MaterialRaisedButton mbtnCancel;
        private MaterialSkin.Controls.MaterialLabel lblID;
        private MaterialSkin.Controls.MaterialLabel lblProductId;
        private MaterialSkin.Controls.MaterialLabel lblSupplier;
        private System.Windows.Forms.ComboBox cbProductSupplier;
        private System.Windows.Forms.ComboBox cbProduct;
        private System.Windows.Forms.ComboBox cbSupplier;
    }
}