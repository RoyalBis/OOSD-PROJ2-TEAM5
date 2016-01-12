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
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.gbPackageDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPackageId
            // 
            this.txtPackageId.Location = new System.Drawing.Point(184, 26);
            this.txtPackageId.Margin = new System.Windows.Forms.Padding(4);
            this.txtPackageId.Name = "txtPackageId";
            this.txtPackageId.Size = new System.Drawing.Size(88, 22);
            this.txtPackageId.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Package ID:";
            // 
            // gbPackageDetail
            // 
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
            this.gbPackageDetail.Location = new System.Drawing.Point(19, 79);
            this.gbPackageDetail.Margin = new System.Windows.Forms.Padding(4);
            this.gbPackageDetail.Name = "gbPackageDetail";
            this.gbPackageDetail.Padding = new System.Windows.Forms.Padding(4);
            this.gbPackageDetail.Size = new System.Drawing.Size(372, 340);
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
            this.btnSearch.Location = new System.Drawing.Point(291, 22);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 28);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(19, 428);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 28);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(156, 428);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 28);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(291, 428);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 28);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmPackage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 469);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.gbPackageDetail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPackageId);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPackage";
            this.Text = "frmPackage";
            this.Load += new System.EventHandler(this.frmPackage_Load);
            this.gbPackageDetail.ResumeLayout(false);
            this.gbPackageDetail.PerformLayout();
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
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
    }
}