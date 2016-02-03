namespace TravelExpertsApp
{
    partial class frmProduct
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
            this.lblProductId = new MaterialSkin.Controls.MaterialLabel();
            this.mtxtProductName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.fpanButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.mbtnAccept = new MaterialSkin.Controls.MaterialRaisedButton();
            this.mbtnCancel = new MaterialSkin.Controls.MaterialRaisedButton();
            this.fpanButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblProductId
            // 
            this.lblProductId.AutoSize = true;
            this.lblProductId.BackColor = System.Drawing.Color.White;
            this.lblProductId.Depth = 0;
            this.lblProductId.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblProductId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblProductId.Location = new System.Drawing.Point(15, 110);
            this.lblProductId.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblProductId.Name = "lblProductId";
            this.lblProductId.Size = new System.Drawing.Size(81, 24);
            this.lblProductId.TabIndex = 15;
            this.lblProductId.Text = "Product:";
            // 
            // mtxtProductName
            // 
            this.mtxtProductName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mtxtProductName.BackColor = System.Drawing.Color.White;
            this.mtxtProductName.Depth = 0;
            this.mtxtProductName.Hint = "Product Name";
            this.mtxtProductName.Location = new System.Drawing.Point(200, 110);
            this.mtxtProductName.MaxLength = 32767;
            this.mtxtProductName.MouseState = MaterialSkin.MouseState.HOVER;
            this.mtxtProductName.Name = "mtxtProductName";
            this.mtxtProductName.PasswordChar = '\0';
            this.mtxtProductName.SelectedText = "";
            this.mtxtProductName.SelectionLength = 0;
            this.mtxtProductName.SelectionStart = 0;
            this.mtxtProductName.Size = new System.Drawing.Size(434, 28);
            this.mtxtProductName.TabIndex = 17;
            this.mtxtProductName.TabStop = false;
            this.mtxtProductName.UseSystemPasswordChar = false;
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
            this.fpanButtons.TabIndex = 18;
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
            // frmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 237);
            this.Controls.Add(this.fpanButtons);
            this.Controls.Add(this.mtxtProductName);
            this.Controls.Add(this.lblProductId);
            this.Name = "frmProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.frmProduct_Load);
            this.fpanButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblProductId;
        private MaterialSkin.Controls.MaterialSingleLineTextField mtxtProductName;
        private System.Windows.Forms.FlowLayoutPanel fpanButtons;
        private MaterialSkin.Controls.MaterialRaisedButton mbtnAccept;
        private MaterialSkin.Controls.MaterialRaisedButton mbtnCancel;
    }
}