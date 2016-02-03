using MaterialSkin.Controls;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductSupplier));
            this.fpanButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.mbtnAccept = new MaterialSkin.Controls.MaterialRaisedButton();
            this.mbtnCancel = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lblProductId = new MaterialSkin.Controls.MaterialLabel();
            this.lblSupplier = new MaterialSkin.Controls.MaterialLabel();
            this.cbProducts = new System.Windows.Forms.ComboBox();
            this.cbSuppliers = new System.Windows.Forms.ComboBox();
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
            this.lblProductId.Location = new System.Drawing.Point(12, 95);
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
            this.lblSupplier.Location = new System.Drawing.Point(13, 131);
            this.lblSupplier.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(84, 24);
            this.lblSupplier.TabIndex = 8;
            this.lblSupplier.Text = "Supplier:";
            // 
            // cbProducts
            // 
            this.cbProducts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbProducts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProducts.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProducts.FormattingEnabled = true;
            this.cbProducts.Location = new System.Drawing.Point(197, 89);
            this.cbProducts.Name = "cbProducts";
            this.cbProducts.Size = new System.Drawing.Size(438, 30);
            this.cbProducts.TabIndex = 14;
            this.cbProducts.SelectedIndexChanged += new System.EventHandler(this.cbProducts_SelectedIndexChanged);
            // 
            // cbSuppliers
            // 
            this.cbSuppliers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSuppliers.BackColor = System.Drawing.Color.White;
            this.cbSuppliers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSuppliers.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSuppliers.FormattingEnabled = true;
            this.cbSuppliers.Location = new System.Drawing.Point(197, 125);
            this.cbSuppliers.Name = "cbSuppliers";
            this.cbSuppliers.Size = new System.Drawing.Size(438, 30);
            this.cbSuppliers.TabIndex = 15;
            this.cbSuppliers.SelectedIndexChanged += new System.EventHandler(this.cbSuppliers_SelectedIndexChanged);
            // 
            // frmProductSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 237);
            this.ControlBox = false;
            this.Controls.Add(this.cbSuppliers);
            this.Controls.Add(this.cbProducts);
            this.Controls.Add(this.lblSupplier);
            this.Controls.Add(this.lblProductId);
            this.Controls.Add(this.fpanButtons);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private MaterialSkin.Controls.MaterialLabel lblProductId;
        private MaterialSkin.Controls.MaterialLabel lblSupplier;
        private System.Windows.Forms.ComboBox cbProducts;
        private System.Windows.Forms.ComboBox cbSuppliers;
    }
}