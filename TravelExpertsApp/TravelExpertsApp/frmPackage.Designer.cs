namespace TravelExpertsApp
{
    partial class frmPackage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPackage));
            this.txtPackageId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbPackageDetail = new System.Windows.Forms.GroupBox();
            this.rtxtPkgDesc = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPkgAgencyCommission = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPkgBasePrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPkgEndDate = new System.Windows.Forms.TextBox();
            this.lblPkg = new System.Windows.Forms.Label();
            this.txtPkgStartDate = new System.Windows.Forms.TextBox();
            this.lblPkgDesc = new System.Windows.Forms.Label();
            this.lblPkgName = new System.Windows.Forms.Label();
            this.txtPkgName = new System.Windows.Forms.TextBox();
            this.ttpPackage = new System.Windows.Forms.ToolTip(this.components);
            this.travelExpertsDataSet1 = new TravelExpertsDB.TravelExpertsDataSet();
            this.btnSearch = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnAdd = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnUpdate = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnDelete = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnXML = new MaterialSkin.Controls.MaterialFlatButton();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lsvPackage_Supplier = new System.Windows.Forms.ListView();
            this.gbPackageDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.travelExpertsDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPackageId
            // 
            this.txtPackageId.Location = new System.Drawing.Point(139, 80);
            this.txtPackageId.Name = "txtPackageId";
            this.txtPackageId.Size = new System.Drawing.Size(67, 20);
            this.txtPackageId.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Package ID:";
            // 
            // gbPackageDetail
            // 
            this.gbPackageDetail.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbPackageDetail.Controls.Add(this.rtxtPkgDesc);
            this.gbPackageDetail.Controls.Add(this.label6);
            this.gbPackageDetail.Controls.Add(this.txtPkgAgencyCommission);
            this.gbPackageDetail.Controls.Add(this.label7);
            this.gbPackageDetail.Controls.Add(this.txtPkgBasePrice);
            this.gbPackageDetail.Controls.Add(this.label4);
            this.gbPackageDetail.Controls.Add(this.txtPkgEndDate);
            this.gbPackageDetail.Controls.Add(this.lblPkg);
            this.gbPackageDetail.Controls.Add(this.txtPkgStartDate);
            this.gbPackageDetail.Controls.Add(this.lblPkgDesc);
            this.gbPackageDetail.Controls.Add(this.lblPkgName);
            this.gbPackageDetail.Controls.Add(this.txtPkgName);
            this.gbPackageDetail.Location = new System.Drawing.Point(14, 112);
            this.gbPackageDetail.Name = "gbPackageDetail";
            this.gbPackageDetail.Size = new System.Drawing.Size(279, 274);
            this.gbPackageDetail.TabIndex = 2;
            this.gbPackageDetail.TabStop = false;
            this.gbPackageDetail.Text = "Package Detail";
            // 
            // rtxtPkgDesc
            // 
            this.rtxtPkgDesc.Location = new System.Drawing.Point(125, 70);
            this.rtxtPkgDesc.Name = "rtxtPkgDesc";
            this.rtxtPkgDesc.Size = new System.Drawing.Size(132, 41);
            this.rtxtPkgDesc.TabIndex = 26;
            this.rtxtPkgDesc.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Agency Commission:";
            // 
            // txtPkgAgencyCommission
            // 
            this.txtPkgAgencyCommission.Location = new System.Drawing.Point(125, 237);
            this.txtPkgAgencyCommission.Name = "txtPkgAgencyCommission";
            this.txtPkgAgencyCommission.Size = new System.Drawing.Size(77, 20);
            this.txtPkgAgencyCommission.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(55, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Base Price:";
            // 
            // txtPkgBasePrice
            // 
            this.txtPkgBasePrice.Location = new System.Drawing.Point(125, 201);
            this.txtPkgBasePrice.Name = "txtPkgBasePrice";
            this.txtPkgBasePrice.Size = new System.Drawing.Size(77, 20);
            this.txtPkgBasePrice.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Package End Date:";
            // 
            // txtPkgEndDate
            // 
            this.txtPkgEndDate.Location = new System.Drawing.Point(125, 164);
            this.txtPkgEndDate.Name = "txtPkgEndDate";
            this.txtPkgEndDate.Size = new System.Drawing.Size(132, 20);
            this.txtPkgEndDate.TabIndex = 20;
            // 
            // lblPkg
            // 
            this.lblPkg.AutoSize = true;
            this.lblPkg.Location = new System.Drawing.Point(12, 131);
            this.lblPkg.Name = "lblPkg";
            this.lblPkg.Size = new System.Drawing.Size(104, 13);
            this.lblPkg.TabIndex = 19;
            this.lblPkg.Text = "Package Start Date:";
            // 
            // txtPkgStartDate
            // 
            this.txtPkgStartDate.Location = new System.Drawing.Point(125, 128);
            this.txtPkgStartDate.Name = "txtPkgStartDate";
            this.txtPkgStartDate.Size = new System.Drawing.Size(132, 20);
            this.txtPkgStartDate.TabIndex = 18;
            // 
            // lblPkgDesc
            // 
            this.lblPkgDesc.AutoSize = true;
            this.lblPkgDesc.Location = new System.Drawing.Point(7, 70);
            this.lblPkgDesc.Name = "lblPkgDesc";
            this.lblPkgDesc.Size = new System.Drawing.Size(109, 13);
            this.lblPkgDesc.TabIndex = 17;
            this.lblPkgDesc.Text = "Package Description:";
            // 
            // lblPkgName
            // 
            this.lblPkgName.AutoSize = true;
            this.lblPkgName.Location = new System.Drawing.Point(32, 34);
            this.lblPkgName.Name = "lblPkgName";
            this.lblPkgName.Size = new System.Drawing.Size(84, 13);
            this.lblPkgName.TabIndex = 15;
            this.lblPkgName.Text = "Package Name:";
            // 
            // txtPkgName
            // 
            this.txtPkgName.Location = new System.Drawing.Point(125, 31);
            this.txtPkgName.Name = "txtPkgName";
            this.txtPkgName.Size = new System.Drawing.Size(132, 20);
            this.txtPkgName.TabIndex = 14;
            // 
            // travelExpertsDataSet1
            // 
            this.travelExpertsDataSet1.DataSetName = "TravelExpertsDataSet";
            this.travelExpertsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnSearch
            // 
            this.btnSearch.Depth = 0;
            this.btnSearch.Location = new System.Drawing.Point(218, 78);
            this.btnSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Primary = true;
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click_1);
            // 
            // btnAdd
            // 
            this.btnAdd.Depth = 0;
            this.btnAdd.Location = new System.Drawing.Point(14, 407);
            this.btnAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Primary = true;
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Depth = 0;
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(116, 407);
            this.btnUpdate.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Primary = true;
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click_1);
            // 
            // btnDelete
            // 
            this.btnDelete.Depth = 0;
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(218, 407);
            this.btnDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Primary = true;
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // btnXML
            // 
            this.btnXML.AutoSize = true;
            this.btnXML.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnXML.Depth = 0;
            this.btnXML.Location = new System.Drawing.Point(922, 394);
            this.btnXML.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnXML.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnXML.Name = "btnXML";
            this.btnXML.Primary = false;
            this.btnXML.Size = new System.Drawing.Size(99, 36);
            this.btnXML.TabIndex = 13;
            this.btnXML.Text = "Save to XML";
            this.btnXML.UseVisualStyleBackColor = true;
            this.btnXML.Click += new System.EventHandler(this.btnXML_Click_1);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Package ID";
            this.columnHeader1.Width = 70;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Package";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 117;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Description";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 191;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Start Date";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 84;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "End Date";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 79;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Base Price";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 66;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Agency Commission";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader7.Width = 107;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Product Supplier ID";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader8.Width = 106;
            // 
            // lsvPackage_Supplier
            // 
            this.lsvPackage_Supplier.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.lsvPackage_Supplier.Location = new System.Drawing.Point(304, 81);
            this.lsvPackage_Supplier.Name = "lsvPackage_Supplier";
            this.lsvPackage_Supplier.Size = new System.Drawing.Size(717, 305);
            this.lsvPackage_Supplier.TabIndex = 7;
            this.lsvPackage_Supplier.UseCompatibleStateImageBehavior = false;
            this.lsvPackage_Supplier.View = System.Windows.Forms.View.Details;
            // 
            // frmPackage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1032, 438);
            this.Controls.Add(this.btnXML);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lsvPackage_Supplier);
            this.Controls.Add(this.gbPackageDetail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPackageId);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPackage";
            this.Text = "Package Report";
            this.Load += new System.EventHandler(this.frmPackage_Load);
            this.gbPackageDetail.ResumeLayout(false);
            this.gbPackageDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.travelExpertsDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPackageId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbPackageDetail;
        private System.Windows.Forms.RichTextBox rtxtPkgDesc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPkgAgencyCommission;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPkgBasePrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPkgEndDate;
        private System.Windows.Forms.Label lblPkg;
        private System.Windows.Forms.TextBox txtPkgStartDate;
        private System.Windows.Forms.Label lblPkgDesc;
        private System.Windows.Forms.Label lblPkgName;
        private System.Windows.Forms.TextBox txtPkgName;
        private System.Windows.Forms.ToolTip ttpPackage;
        private TravelExpertsDB.TravelExpertsDataSet travelExpertsDataSet1;
        private MaterialSkin.Controls.MaterialRaisedButton btnSearch;
        private MaterialSkin.Controls.MaterialRaisedButton btnAdd;
        private MaterialSkin.Controls.MaterialRaisedButton btnUpdate;
        private MaterialSkin.Controls.MaterialRaisedButton btnDelete;
        private MaterialSkin.Controls.MaterialFlatButton btnXML;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ListView lsvPackage_Supplier;
    }
}