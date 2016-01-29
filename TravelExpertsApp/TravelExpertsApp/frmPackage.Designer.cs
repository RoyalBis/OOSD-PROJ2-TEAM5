using MaterialSkin.Controls;

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
            this.btnSearch = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnAdd = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnUpdate = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnDelete = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnXML = new MaterialSkin.Controls.MaterialFlatButton();
            this.colId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDesc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStartDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colEndDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colBasePrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCommission = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvPackages = new MaterialSkin.Controls.MaterialListView();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.travelExpertsDataSet1 = new TravelExpertsDB.TravelExpertsDataSet();
            this.panMain = new System.Windows.Forms.Panel();
            this.gbPackageDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.travelExpertsDataSet1)).BeginInit();
            this.panMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPackageId
            // 
            this.txtPackageId.Location = new System.Drawing.Point(1236, 33);
            this.txtPackageId.Margin = new System.Windows.Forms.Padding(4);
            this.txtPackageId.Name = "txtPackageId";
            this.txtPackageId.Size = new System.Drawing.Size(88, 22);
            this.txtPackageId.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1079, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
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
            this.gbPackageDetail.Location = new System.Drawing.Point(1070, 73);
            this.gbPackageDetail.Margin = new System.Windows.Forms.Padding(4);
            this.gbPackageDetail.Name = "gbPackageDetail";
            this.gbPackageDetail.Padding = new System.Windows.Forms.Padding(4);
            this.gbPackageDetail.Size = new System.Drawing.Size(372, 337);
            this.gbPackageDetail.TabIndex = 2;
            this.gbPackageDetail.TabStop = false;
            this.gbPackageDetail.Text = "Package Detail";
            // 
            // rtxtPkgDesc
            // 
            this.rtxtPkgDesc.Location = new System.Drawing.Point(167, 86);
            this.rtxtPkgDesc.Margin = new System.Windows.Forms.Padding(4);
            this.rtxtPkgDesc.Name = "rtxtPkgDesc";
            this.rtxtPkgDesc.Size = new System.Drawing.Size(175, 50);
            this.rtxtPkgDesc.TabIndex = 26;
            this.rtxtPkgDesc.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 295);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 17);
            this.label6.TabIndex = 25;
            this.label6.Text = "Agency Commission:";
            // 
            // txtPkgAgencyCommission
            // 
            this.txtPkgAgencyCommission.Location = new System.Drawing.Point(167, 292);
            this.txtPkgAgencyCommission.Margin = new System.Windows.Forms.Padding(4);
            this.txtPkgAgencyCommission.Name = "txtPkgAgencyCommission";
            this.txtPkgAgencyCommission.Size = new System.Drawing.Size(101, 22);
            this.txtPkgAgencyCommission.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(73, 251);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 17);
            this.label7.TabIndex = 23;
            this.label7.Text = "Base Price:";
            // 
            // txtPkgBasePrice
            // 
            this.txtPkgBasePrice.Location = new System.Drawing.Point(167, 247);
            this.txtPkgBasePrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtPkgBasePrice.Name = "txtPkgBasePrice";
            this.txtPkgBasePrice.Size = new System.Drawing.Size(101, 22);
            this.txtPkgBasePrice.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 206);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Package End Date:";
            // 
            // txtPkgEndDate
            // 
            this.txtPkgEndDate.Location = new System.Drawing.Point(167, 202);
            this.txtPkgEndDate.Margin = new System.Windows.Forms.Padding(4);
            this.txtPkgEndDate.Name = "txtPkgEndDate";
            this.txtPkgEndDate.Size = new System.Drawing.Size(175, 22);
            this.txtPkgEndDate.TabIndex = 20;
            // 
            // lblPkg
            // 
            this.lblPkg.AutoSize = true;
            this.lblPkg.Location = new System.Drawing.Point(16, 161);
            this.lblPkg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPkg.Name = "lblPkg";
            this.lblPkg.Size = new System.Drawing.Size(135, 17);
            this.lblPkg.TabIndex = 19;
            this.lblPkg.Text = "Package Start Date:";
            // 
            // txtPkgStartDate
            // 
            this.txtPkgStartDate.Location = new System.Drawing.Point(167, 158);
            this.txtPkgStartDate.Margin = new System.Windows.Forms.Padding(4);
            this.txtPkgStartDate.Name = "txtPkgStartDate";
            this.txtPkgStartDate.Size = new System.Drawing.Size(175, 22);
            this.txtPkgStartDate.TabIndex = 18;
            // 
            // lblPkgDesc
            // 
            this.lblPkgDesc.AutoSize = true;
            this.lblPkgDesc.Location = new System.Drawing.Point(9, 86);
            this.lblPkgDesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPkgDesc.Name = "lblPkgDesc";
            this.lblPkgDesc.Size = new System.Drawing.Size(142, 17);
            this.lblPkgDesc.TabIndex = 17;
            this.lblPkgDesc.Text = "Package Description:";
            // 
            // lblPkgName
            // 
            this.lblPkgName.AutoSize = true;
            this.lblPkgName.Location = new System.Drawing.Point(43, 42);
            this.lblPkgName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPkgName.Name = "lblPkgName";
            this.lblPkgName.Size = new System.Drawing.Size(108, 17);
            this.lblPkgName.TabIndex = 15;
            this.lblPkgName.Text = "Package Name:";
            // 
            // txtPkgName
            // 
            this.txtPkgName.Location = new System.Drawing.Point(167, 38);
            this.txtPkgName.Margin = new System.Windows.Forms.Padding(4);
            this.txtPkgName.Name = "txtPkgName";
            this.txtPkgName.Size = new System.Drawing.Size(175, 22);
            this.txtPkgName.TabIndex = 14;
            // 
            // btnSearch
            // 
            this.btnSearch.Depth = 0;
            this.btnSearch.Location = new System.Drawing.Point(1342, 31);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Primary = true;
            this.btnSearch.Size = new System.Drawing.Size(100, 28);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click_1);
            // 
            // btnAdd
            // 
            this.btnAdd.Depth = 0;
            this.btnAdd.Location = new System.Drawing.Point(19, 501);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Primary = true;
            this.btnAdd.Size = new System.Drawing.Size(100, 28);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Depth = 0;
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(155, 501);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Primary = true;
            this.btnUpdate.Size = new System.Drawing.Size(100, 28);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click_1);
            // 
            // btnDelete
            // 
            this.btnDelete.Depth = 0;
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(291, 501);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Primary = true;
            this.btnDelete.Size = new System.Drawing.Size(100, 28);
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
            this.btnXML.Location = new System.Drawing.Point(1319, 496);
            this.btnXML.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnXML.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnXML.Name = "btnXML";
            this.btnXML.Primary = true;
            this.btnXML.Size = new System.Drawing.Size(122, 36);
            this.btnXML.TabIndex = 13;
            this.btnXML.Text = "Save to XML";
            this.btnXML.UseVisualStyleBackColor = true;
            this.btnXML.Click += new System.EventHandler(this.btnXML_Click_1);
            // 
            // colId
            // 
            this.colId.Text = "ID";
            this.colId.Width = 50;
            // 
            // colName
            // 
            this.colName.Text = "Name";
            this.colName.Width = 200;
            // 
            // colDesc
            // 
            this.colDesc.Text = "Description";
            this.colDesc.Width = 300;
            // 
            // colStartDate
            // 
            this.colStartDate.Text = "Start Date";
            this.colStartDate.Width = 110;
            // 
            // colEndDate
            // 
            this.colEndDate.Text = "End Date";
            this.colEndDate.Width = 110;
            // 
            // colBasePrice
            // 
            this.colBasePrice.Text = "Base Price";
            this.colBasePrice.Width = 110;
            // 
            // colCommission
            // 
            this.colCommission.Text = "Commission";
            this.colCommission.Width = 157;
            // 
            // lvPackages
            // 
            this.lvPackages.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvPackages.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colId,
            this.colName,
            this.colDesc,
            this.colStartDate,
            this.colEndDate,
            this.colBasePrice,
            this.colCommission});
            this.lvPackages.Depth = 0;
            this.lvPackages.FullRowSelect = true;
            this.lvPackages.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvPackages.Location = new System.Drawing.Point(13, 13);
            this.lvPackages.Margin = new System.Windows.Forms.Padding(4);
            this.lvPackages.MouseLocation = new System.Drawing.Point(-1, -1);
            this.lvPackages.MouseState = MaterialSkin.MouseState.OUT;
            this.lvPackages.Name = "lvPackages";
            this.lvPackages.OwnerDraw = true;
            this.lvPackages.Size = new System.Drawing.Size(1037, 397);
            this.lvPackages.TabIndex = 7;
            this.lvPackages.UseCompatibleStateImageBehavior = false;
            this.lvPackages.View = System.Windows.Forms.View.Details;
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(405, 501);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(185, 27);
            this.materialRaisedButton1.TabIndex = 14;
            this.materialRaisedButton1.Text = "Change Theme";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // travelExpertsDataSet1
            // 
            this.travelExpertsDataSet1.DataSetName = "TravelExpertsDataSet";
            this.travelExpertsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panMain
            // 
            this.panMain.BackColor = System.Drawing.Color.Transparent;
            this.panMain.Controls.Add(this.gbPackageDetail);
            this.panMain.Controls.Add(this.txtPackageId);
            this.panMain.Controls.Add(this.label1);
            this.panMain.Controls.Add(this.btnSearch);
            this.panMain.Controls.Add(this.lvPackages);
            this.panMain.Location = new System.Drawing.Point(0, 64);
            this.panMain.Name = "panMain";
            this.panMain.Size = new System.Drawing.Size(1455, 475);
            this.panMain.TabIndex = 15;
            // 
            // frmPackage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1455, 539);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.btnXML);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.panMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPackage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Package Report";
            this.Load += new System.EventHandler(this.frmPackage_Load);
            this.gbPackageDetail.ResumeLayout(false);
            this.gbPackageDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.travelExpertsDataSet1)).EndInit();
            this.panMain.ResumeLayout(false);
            this.panMain.PerformLayout();
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
        private System.Windows.Forms.ToolTip ttpPackage;
        private TravelExpertsDB.TravelExpertsDataSet travelExpertsDataSet1;
        private MaterialSkin.Controls.MaterialRaisedButton btnSearch;
        private MaterialSkin.Controls.MaterialRaisedButton btnAdd;
        private MaterialSkin.Controls.MaterialRaisedButton btnUpdate;
        private MaterialSkin.Controls.MaterialRaisedButton btnDelete;
        private MaterialSkin.Controls.MaterialFlatButton btnXML;
        private System.Windows.Forms.ColumnHeader colId;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colDesc;
        private System.Windows.Forms.ColumnHeader colStartDate;
        private System.Windows.Forms.ColumnHeader colEndDate;
        private System.Windows.Forms.ColumnHeader colBasePrice;
        private System.Windows.Forms.ColumnHeader colCommission;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private MaterialListView lvPackages;
        private System.Windows.Forms.TextBox txtPkgName;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private System.Windows.Forms.Panel panMain;
    }
}