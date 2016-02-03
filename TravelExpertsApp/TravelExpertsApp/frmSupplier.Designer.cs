namespace TravelExpertsApp
{
    partial class frmSupplier
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
            this.lblProductId = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.mtxtSupplierName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.mtxtSupplierId = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.mchkGenerate = new MaterialSkin.Controls.MaterialCheckBox();
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
            this.fpanButtons.Location = new System.Drawing.Point(12, 189);
            this.fpanButtons.Name = "fpanButtons";
            this.fpanButtons.Size = new System.Drawing.Size(625, 36);
            this.fpanButtons.TabIndex = 21;
            // 
            // mbtnAccept
            // 
            this.mbtnAccept.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mbtnAccept.Depth = 0;
            this.mbtnAccept.DialogResult = System.Windows.Forms.DialogResult.OK;
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
            this.mbtnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            // lblProductId
            // 
            this.lblProductId.AutoSize = true;
            this.lblProductId.BackColor = System.Drawing.Color.White;
            this.lblProductId.Depth = 0;
            this.lblProductId.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblProductId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblProductId.Location = new System.Drawing.Point(11, 130);
            this.lblProductId.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblProductId.Name = "lblProductId";
            this.lblProductId.Size = new System.Drawing.Size(84, 24);
            this.lblProductId.TabIndex = 19;
            this.lblProductId.Text = "Supplier:";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.White;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(11, 96);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(106, 24);
            this.materialLabel1.TabIndex = 22;
            this.materialLabel1.Text = "Supplier ID:";
            // 
            // mtxtSupplierName
            // 
            this.mtxtSupplierName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mtxtSupplierName.BackColor = System.Drawing.Color.White;
            this.mtxtSupplierName.Depth = 0;
            this.mtxtSupplierName.Hint = "Supplier Name";
            this.mtxtSupplierName.Location = new System.Drawing.Point(196, 130);
            this.mtxtSupplierName.MaxLength = 32767;
            this.mtxtSupplierName.MouseState = MaterialSkin.MouseState.HOVER;
            this.mtxtSupplierName.Name = "mtxtSupplierName";
            this.mtxtSupplierName.PasswordChar = '\0';
            this.mtxtSupplierName.SelectedText = "";
            this.mtxtSupplierName.SelectionLength = 0;
            this.mtxtSupplierName.SelectionStart = 0;
            this.mtxtSupplierName.Size = new System.Drawing.Size(438, 28);
            this.mtxtSupplierName.TabIndex = 24;
            this.mtxtSupplierName.TabStop = false;
            this.mtxtSupplierName.UseSystemPasswordChar = false;
            // 
            // mtxtSupplierId
            // 
            this.mtxtSupplierId.BackColor = System.Drawing.Color.White;
            this.mtxtSupplierId.Depth = 0;
            this.mtxtSupplierId.Hint = "Supplier ID";
            this.mtxtSupplierId.Location = new System.Drawing.Point(196, 96);
            this.mtxtSupplierId.MaxLength = 32767;
            this.mtxtSupplierId.MouseState = MaterialSkin.MouseState.HOVER;
            this.mtxtSupplierId.Name = "mtxtSupplierId";
            this.mtxtSupplierId.PasswordChar = '\0';
            this.mtxtSupplierId.SelectedText = "";
            this.mtxtSupplierId.SelectionLength = 0;
            this.mtxtSupplierId.SelectionStart = 0;
            this.mtxtSupplierId.Size = new System.Drawing.Size(169, 28);
            this.mtxtSupplierId.TabIndex = 25;
            this.mtxtSupplierId.TabStop = false;
            this.mtxtSupplierId.UseSystemPasswordChar = false;
            // 
            // mchkGenerate
            // 
            this.mchkGenerate.AutoSize = true;
            this.mchkGenerate.BackColor = System.Drawing.Color.Transparent;
            this.mchkGenerate.Depth = 0;
            this.mchkGenerate.Font = new System.Drawing.Font("Roboto", 10F);
            this.mchkGenerate.Location = new System.Drawing.Point(368, 94);
            this.mchkGenerate.Margin = new System.Windows.Forms.Padding(0);
            this.mchkGenerate.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mchkGenerate.MouseState = MaterialSkin.MouseState.HOVER;
            this.mchkGenerate.Name = "mchkGenerate";
            this.mchkGenerate.Ripple = true;
            this.mchkGenerate.Size = new System.Drawing.Size(170, 30);
            this.mchkGenerate.TabIndex = 26;
            this.mchkGenerate.Text = "Auto-generate ID?";
            this.mchkGenerate.UseVisualStyleBackColor = false;
            this.mchkGenerate.CheckedChanged += new System.EventHandler(this.mchkGenerate_CheckedChanged);
            // 
            // frmSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(650, 237);
            this.Controls.Add(this.mchkGenerate);
            this.Controls.Add(this.mtxtSupplierId);
            this.Controls.Add(this.mtxtSupplierName);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.fpanButtons);
            this.Controls.Add(this.lblProductId);
            this.Name = "frmSupplier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmSupplier";
            this.Load += new System.EventHandler(this.frmSupplier_Load);
            this.fpanButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel fpanButtons;
        private MaterialSkin.Controls.MaterialRaisedButton mbtnAccept;
        private MaterialSkin.Controls.MaterialRaisedButton mbtnCancel;
        private MaterialSkin.Controls.MaterialLabel lblProductId;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField mtxtSupplierName;
        private MaterialSkin.Controls.MaterialCheckBox mchkGenerate;
        private MaterialSkin.Controls.MaterialSingleLineTextField mtxtSupplierId;
    }
}