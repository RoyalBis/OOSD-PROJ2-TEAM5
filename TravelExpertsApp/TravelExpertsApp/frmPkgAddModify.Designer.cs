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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPkgName = new System.Windows.Forms.TextBox();
            this.lblPkgName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtBasePrice = new System.Windows.Forms.TextBox();
            this.lblBasePrice = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtCommission = new System.Windows.Forms.TextBox();
            this.lblCommission = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btn = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblPkgImage = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lvPkgProductSuppliers = new System.Windows.Forms.ListView();
            this.colProdSup = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colProdName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSupName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblPkgProducts = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblMessages = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnAddModfy = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel9.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtPkgName);
            this.panel1.Controls.Add(this.lblPkgName);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(353, 32);
            this.panel1.TabIndex = 0;
            // 
            // txtPkgName
            // 
            this.txtPkgName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtPkgName.Location = new System.Drawing.Point(119, 4);
            this.txtPkgName.Name = "txtPkgName";
            this.txtPkgName.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPkgName.Size = new System.Drawing.Size(230, 22);
            this.txtPkgName.TabIndex = 1;
            this.txtPkgName.TextChanged += new System.EventHandler(this.txtPkgName_TextChanged);
            this.txtPkgName.Leave += new System.EventHandler(this.txtPkgName_Leave);
            // 
            // lblPkgName
            // 
            this.lblPkgName.AutoSize = true;
            this.lblPkgName.Location = new System.Drawing.Point(3, 7);
            this.lblPkgName.Name = "lblPkgName";
            this.lblPkgName.Size = new System.Drawing.Size(108, 17);
            this.lblPkgName.TabIndex = 0;
            this.lblPkgName.Text = "Package Name:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtpStartDate);
            this.panel2.Controls.Add(this.lblStartDate);
            this.panel2.Location = new System.Drawing.Point(0, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(353, 32);
            this.panel2.TabIndex = 2;
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
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(739, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(142, 26);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(142, 26);
            this.saveAsToolStripMenuItem.Text = "Save as...";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(142, 26);
            this.closeToolStripMenuItem.Text = "Close";
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Location = new System.Drawing.Point(0, 515);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(739, 22);
            this.statusStrip.TabIndex = 5;
            this.statusStrip.Text = "statusStrip1";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.textBox2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(0, 114);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(353, 96);
            this.panel4.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(118, 7);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(230, 82);
            this.textBox2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "End Date:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dtpEndDate);
            this.panel3.Controls.Add(this.lblEndDate);
            this.panel3.Location = new System.Drawing.Point(0, 76);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(353, 32);
            this.panel3.TabIndex = 3;
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
            this.lblEndDate.Size = new System.Drawing.Size(76, 17);
            this.lblEndDate.TabIndex = 0;
            this.lblEndDate.Text = "Start Date:";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtBasePrice);
            this.panel5.Controls.Add(this.lblBasePrice);
            this.panel5.Location = new System.Drawing.Point(0, 216);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(353, 32);
            this.panel5.TabIndex = 2;
            // 
            // txtBasePrice
            // 
            this.txtBasePrice.Location = new System.Drawing.Point(119, 4);
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
            // panel6
            // 
            this.panel6.Controls.Add(this.txtCommission);
            this.panel6.Controls.Add(this.lblCommission);
            this.panel6.Location = new System.Drawing.Point(0, 254);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(353, 32);
            this.panel6.TabIndex = 3;
            // 
            // txtCommission
            // 
            this.txtCommission.Location = new System.Drawing.Point(119, 4);
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
            // panel7
            // 
            this.panel7.Controls.Add(this.btn);
            this.panel7.Controls.Add(this.textBox3);
            this.panel7.Controls.Add(this.lblPkgImage);
            this.panel7.Location = new System.Drawing.Point(0, 292);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(353, 70);
            this.panel7.TabIndex = 4;
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(226, 33);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(122, 31);
            this.btn.TabIndex = 2;
            this.btn.Text = "Select Image";
            this.btn.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(119, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(230, 22);
            this.textBox3.TabIndex = 1;
            // 
            // lblPkgImage
            // 
            this.lblPkgImage.AutoSize = true;
            this.lblPkgImage.Location = new System.Drawing.Point(3, 7);
            this.lblPkgImage.Name = "lblPkgImage";
            this.lblPkgImage.Size = new System.Drawing.Size(109, 17);
            this.lblPkgImage.TabIndex = 0;
            this.lblPkgImage.Text = "Package Image:";
            // 
            // panel8
            // 
            this.panel8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel8.Controls.Add(this.btnDelete);
            this.panel8.Controls.Add(this.btnAdd);
            this.panel8.Controls.Add(this.lvPkgProductSuppliers);
            this.panel8.Controls.Add(this.lblPkgProducts);
            this.panel8.Location = new System.Drawing.Point(374, 80);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(353, 362);
            this.panel8.TabIndex = 5;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(98, 324);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(122, 31);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete Product";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(226, 324);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(122, 31);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add Product";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // lvPkgProductSuppliers
            // 
            this.lvPkgProductSuppliers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colProdSup,
            this.colProdName,
            this.colSupName});
            this.lvPkgProductSuppliers.FullRowSelect = true;
            this.lvPkgProductSuppliers.GridLines = true;
            this.lvPkgProductSuppliers.Location = new System.Drawing.Point(6, 28);
            this.lvPkgProductSuppliers.Name = "lvPkgProductSuppliers";
            this.lvPkgProductSuppliers.ShowGroups = false;
            this.lvPkgProductSuppliers.Size = new System.Drawing.Size(342, 290);
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
            this.lblPkgProducts.Size = new System.Drawing.Size(127, 17);
            this.lblPkgProducts.TabIndex = 0;
            this.lblPkgProducts.Text = "Package Products:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lblMessages
            // 
            this.lblMessages.Location = new System.Drawing.Point(15, 32);
            this.lblMessages.Name = "lblMessages";
            this.lblMessages.Size = new System.Drawing.Size(712, 30);
            this.lblMessages.TabIndex = 6;
            this.lblMessages.Text = "label2";
            // 
            // btnAddModfy
            // 
            this.btnAddModfy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddModfy.Location = new System.Drawing.Point(590, 3);
            this.btnAddModfy.Name = "btnAddModfy";
            this.btnAddModfy.Size = new System.Drawing.Size(122, 31);
            this.btnAddModfy.TabIndex = 6;
            this.btnAddModfy.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(462, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(122, 31);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // panel9
            // 
            this.panel9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel9.Controls.Add(this.panel1);
            this.panel9.Controls.Add(this.panel2);
            this.panel9.Controls.Add(this.panel4);
            this.panel9.Controls.Add(this.panel3);
            this.panel9.Controls.Add(this.panel5);
            this.panel9.Controls.Add(this.panel7);
            this.panel9.Controls.Add(this.panel6);
            this.panel9.Location = new System.Drawing.Point(12, 80);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(353, 362);
            this.panel9.TabIndex = 7;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnAddModfy);
            this.flowLayoutPanel1.Controls.Add(this.btnCancel);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 475);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(715, 37);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // frmPkgAddModify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 537);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.lblMessages);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPkgAddModify";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel9.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtPkgName;
        private System.Windows.Forms.Label lblPkgName;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtBasePrice;
        private System.Windows.Forms.Label lblBasePrice;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtCommission;
        private System.Windows.Forms.Label lblCommission;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblPkgImage;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListView lvPkgProductSuppliers;
        private System.Windows.Forms.Label lblPkgProducts;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblMessages;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ColumnHeader colProdSup;
        private System.Windows.Forms.ColumnHeader colProdName;
        private System.Windows.Forms.ColumnHeader colSupName;
        private System.Windows.Forms.Button btnAddModfy;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}