namespace TravelExpertsApp
{
    partial class frmPackageEntry
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
            this.gbPackageDetail = new System.Windows.Forms.GroupBox();
            this.dtpPkgEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpPkgStartDate = new System.Windows.Forms.DateTimePicker();
            this.rtxtPkgDesc = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPkgAgencyCommission = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPkgBasePrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPkg = new System.Windows.Forms.Label();
            this.lblPkgDesc = new System.Windows.Forms.Label();
            this.lblPkgName = new System.Windows.Forms.Label();
            this.txtPkgName = new System.Windows.Forms.TextBox();
            this.btnCommit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbPackageDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbPackageDetail
            // 
            this.gbPackageDetail.Controls.Add(this.dtpPkgEndDate);
            this.gbPackageDetail.Controls.Add(this.dtpPkgStartDate);
            this.gbPackageDetail.Controls.Add(this.rtxtPkgDesc);
            this.gbPackageDetail.Controls.Add(this.label6);
            this.gbPackageDetail.Controls.Add(this.txtPkgAgencyCommission);
            this.gbPackageDetail.Controls.Add(this.label7);
            this.gbPackageDetail.Controls.Add(this.txtPkgBasePrice);
            this.gbPackageDetail.Controls.Add(this.label4);
            this.gbPackageDetail.Controls.Add(this.lblPkg);
            this.gbPackageDetail.Controls.Add(this.lblPkgDesc);
            this.gbPackageDetail.Controls.Add(this.lblPkgName);
            this.gbPackageDetail.Controls.Add(this.txtPkgName);
            this.gbPackageDetail.Location = new System.Drawing.Point(12, 12);
            this.gbPackageDetail.Name = "gbPackageDetail";
            this.gbPackageDetail.Size = new System.Drawing.Size(348, 263);
            this.gbPackageDetail.TabIndex = 3;
            this.gbPackageDetail.TabStop = false;
            // 
            // dtpPkgEndDate
            // 
            this.dtpPkgEndDate.Location = new System.Drawing.Point(125, 151);
            this.dtpPkgEndDate.Name = "dtpPkgEndDate";
            this.dtpPkgEndDate.Size = new System.Drawing.Size(199, 20);
            this.dtpPkgEndDate.TabIndex = 30;
            // 
            // dtpPkgStartDate
            // 
            this.dtpPkgStartDate.Location = new System.Drawing.Point(125, 115);
            this.dtpPkgStartDate.Name = "dtpPkgStartDate";
            this.dtpPkgStartDate.Size = new System.Drawing.Size(199, 20);
            this.dtpPkgStartDate.TabIndex = 29;
            // 
            // rtxtPkgDesc
            // 
            this.rtxtPkgDesc.Location = new System.Drawing.Point(125, 56);
            this.rtxtPkgDesc.Name = "rtxtPkgDesc";
            this.rtxtPkgDesc.Size = new System.Drawing.Size(132, 41);
            this.rtxtPkgDesc.TabIndex = 26;
            this.rtxtPkgDesc.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Agency Commission:";
            // 
            // txtPkgAgencyCommission
            // 
            this.txtPkgAgencyCommission.Location = new System.Drawing.Point(125, 223);
            this.txtPkgAgencyCommission.Name = "txtPkgAgencyCommission";
            this.txtPkgAgencyCommission.Size = new System.Drawing.Size(77, 20);
            this.txtPkgAgencyCommission.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(55, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Base Price:";
            // 
            // txtPkgBasePrice
            // 
            this.txtPkgBasePrice.Location = new System.Drawing.Point(125, 187);
            this.txtPkgBasePrice.Name = "txtPkgBasePrice";
            this.txtPkgBasePrice.Size = new System.Drawing.Size(77, 20);
            this.txtPkgBasePrice.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Package End Date:";
            // 
            // lblPkg
            // 
            this.lblPkg.AutoSize = true;
            this.lblPkg.Location = new System.Drawing.Point(12, 117);
            this.lblPkg.Name = "lblPkg";
            this.lblPkg.Size = new System.Drawing.Size(104, 13);
            this.lblPkg.TabIndex = 19;
            this.lblPkg.Text = "Package Start Date:";
            // 
            // lblPkgDesc
            // 
            this.lblPkgDesc.AutoSize = true;
            this.lblPkgDesc.Location = new System.Drawing.Point(7, 56);
            this.lblPkgDesc.Name = "lblPkgDesc";
            this.lblPkgDesc.Size = new System.Drawing.Size(109, 13);
            this.lblPkgDesc.TabIndex = 17;
            this.lblPkgDesc.Text = "Package Description:";
            // 
            // lblPkgName
            // 
            this.lblPkgName.AutoSize = true;
            this.lblPkgName.Location = new System.Drawing.Point(32, 20);
            this.lblPkgName.Name = "lblPkgName";
            this.lblPkgName.Size = new System.Drawing.Size(84, 13);
            this.lblPkgName.TabIndex = 15;
            this.lblPkgName.Text = "Package Name:";
            // 
            // txtPkgName
            // 
            this.txtPkgName.Location = new System.Drawing.Point(125, 17);
            this.txtPkgName.Name = "txtPkgName";
            this.txtPkgName.Size = new System.Drawing.Size(132, 20);
            this.txtPkgName.TabIndex = 14;
            // 
            // btnCommit
            // 
            this.btnCommit.Location = new System.Drawing.Point(109, 283);
            this.btnCommit.Name = "btnCommit";
            this.btnCommit.Size = new System.Drawing.Size(75, 23);
            this.btnCommit.TabIndex = 4;
            this.btnCommit.Text = "Commit";
            this.btnCommit.UseVisualStyleBackColor = true;
            this.btnCommit.Click += new System.EventHandler(this.btnCommit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(190, 283);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmPackageEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 319);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCommit);
            this.Controls.Add(this.gbPackageDetail);
            this.Name = "frmPackageEntry";
            this.Text = "frmPackageEntry";
            this.Load += new System.EventHandler(this.frmPackageEntry_Load);
            this.gbPackageDetail.ResumeLayout(false);
            this.gbPackageDetail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPackageDetail;
        private System.Windows.Forms.RichTextBox rtxtPkgDesc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPkgAgencyCommission;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPkgBasePrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPkg;
        private System.Windows.Forms.Label lblPkgDesc;
        private System.Windows.Forms.Label lblPkgName;
        private System.Windows.Forms.TextBox txtPkgName;
        private System.Windows.Forms.Button btnCommit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DateTimePicker dtpPkgEndDate;
        private System.Windows.Forms.DateTimePicker dtpPkgStartDate;
    }
}