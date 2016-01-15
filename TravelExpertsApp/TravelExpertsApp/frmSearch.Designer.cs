namespace TravelExpertsApp
{
    partial class frmSearch
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
            this.lblProductName = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lstViewProducts = new System.Windows.Forms.ListView();
            this.btnReturn = new System.Windows.Forms.Button();
            this.lblSearchPackages = new System.Windows.Forms.Label();
            this.txtSearchPackages = new System.Windows.Forms.TextBox();
            this.lstViewPackages = new System.Windows.Forms.ListView();
            this.lstViewAgents = new System.Windows.Forms.ListView();
            this.txtSearchAgents = new System.Windows.Forms.TextBox();
            this.lblSearchAgents = new System.Windows.Forms.Label();
            this.lstViewSuppliers = new System.Windows.Forms.ListView();
            this.txtSearchSuppliers = new System.Windows.Forms.TextBox();
            this.lblSearchSuppliers = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.Location = new System.Drawing.Point(12, 14);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(143, 17);
            this.lblProductName.TabIndex = 5;
            this.lblProductName.Text = "Search Products : ";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(161, 14);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(248, 22);
            this.txtProductName.TabIndex = 4;
            this.txtProductName.TextChanged += new System.EventHandler(this.txtProductName_TextChanged);
            // 
            // lstViewProducts
            // 
            this.lstViewProducts.Location = new System.Drawing.Point(12, 47);
            this.lstViewProducts.Name = "lstViewProducts";
            this.lstViewProducts.Size = new System.Drawing.Size(397, 244);
            this.lstViewProducts.TabIndex = 7;
            this.lstViewProducts.UseCompatibleStateImageBehavior = false;
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(354, 587);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(140, 30);
            this.btnReturn.TabIndex = 8;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lblSearchPackages
            // 
            this.lblSearchPackages.AutoSize = true;
            this.lblSearchPackages.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchPackages.Location = new System.Drawing.Point(12, 306);
            this.lblSearchPackages.Name = "lblSearchPackages";
            this.lblSearchPackages.Size = new System.Drawing.Size(149, 17);
            this.lblSearchPackages.TabIndex = 9;
            this.lblSearchPackages.Text = "Search Packages : ";
            // 
            // txtSearchPackages
            // 
            this.txtSearchPackages.Location = new System.Drawing.Point(161, 306);
            this.txtSearchPackages.Name = "txtSearchPackages";
            this.txtSearchPackages.Size = new System.Drawing.Size(248, 22);
            this.txtSearchPackages.TabIndex = 10;
            // 
            // lstViewPackages
            // 
            this.lstViewPackages.Location = new System.Drawing.Point(15, 337);
            this.lstViewPackages.Name = "lstViewPackages";
            this.lstViewPackages.Size = new System.Drawing.Size(394, 244);
            this.lstViewPackages.TabIndex = 11;
            this.lstViewPackages.UseCompatibleStateImageBehavior = false;
            // 
            // lstViewAgents
            // 
            this.lstViewAgents.Location = new System.Drawing.Point(433, 47);
            this.lstViewAgents.Name = "lstViewAgents";
            this.lstViewAgents.Size = new System.Drawing.Size(394, 244);
            this.lstViewAgents.TabIndex = 14;
            this.lstViewAgents.UseCompatibleStateImageBehavior = false;
            // 
            // txtSearchAgents
            // 
            this.txtSearchAgents.Location = new System.Drawing.Point(579, 16);
            this.txtSearchAgents.Name = "txtSearchAgents";
            this.txtSearchAgents.Size = new System.Drawing.Size(248, 22);
            this.txtSearchAgents.TabIndex = 13;
            this.txtSearchAgents.TextChanged += new System.EventHandler(this.txtSearchAgents_TextChanged);
            // 
            // lblSearchAgents
            // 
            this.lblSearchAgents.AutoSize = true;
            this.lblSearchAgents.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchAgents.Location = new System.Drawing.Point(430, 17);
            this.lblSearchAgents.Name = "lblSearchAgents";
            this.lblSearchAgents.Size = new System.Drawing.Size(129, 17);
            this.lblSearchAgents.TabIndex = 12;
            this.lblSearchAgents.Text = "Search Agents : ";
            // 
            // lstViewSuppliers
            // 
            this.lstViewSuppliers.Location = new System.Drawing.Point(433, 337);
            this.lstViewSuppliers.Name = "lstViewSuppliers";
            this.lstViewSuppliers.Size = new System.Drawing.Size(394, 244);
            this.lstViewSuppliers.TabIndex = 17;
            this.lstViewSuppliers.UseCompatibleStateImageBehavior = false;
            // 
            // txtSearchSuppliers
            // 
            this.txtSearchSuppliers.Location = new System.Drawing.Point(579, 306);
            this.txtSearchSuppliers.Name = "txtSearchSuppliers";
            this.txtSearchSuppliers.Size = new System.Drawing.Size(248, 22);
            this.txtSearchSuppliers.TabIndex = 16;
            // 
            // lblSearchSuppliers
            // 
            this.lblSearchSuppliers.AutoSize = true;
            this.lblSearchSuppliers.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchSuppliers.Location = new System.Drawing.Point(430, 306);
            this.lblSearchSuppliers.Name = "lblSearchSuppliers";
            this.lblSearchSuppliers.Size = new System.Drawing.Size(147, 17);
            this.lblSearchSuppliers.TabIndex = 15;
            this.lblSearchSuppliers.Text = "Search Suppliers : ";
            // 
            // frmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 623);
            this.Controls.Add(this.lstViewSuppliers);
            this.Controls.Add(this.txtSearchSuppliers);
            this.Controls.Add(this.lblSearchSuppliers);
            this.Controls.Add(this.lstViewAgents);
            this.Controls.Add(this.txtSearchAgents);
            this.Controls.Add(this.lblSearchAgents);
            this.Controls.Add(this.lstViewPackages);
            this.Controls.Add(this.txtSearchPackages);
            this.Controls.Add(this.lblSearchPackages);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.lstViewProducts);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.txtProductName);
            this.Name = "frmSearch";
            this.Text = "Search Engine";
            this.Load += new System.EventHandler(this.frmSearch_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.ListView lstViewProducts;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lblSearchPackages;
        private System.Windows.Forms.TextBox txtSearchPackages;
        private System.Windows.Forms.ListView lstViewPackages;
        private System.Windows.Forms.ListView lstViewAgents;
        private System.Windows.Forms.TextBox txtSearchAgents;
        private System.Windows.Forms.Label lblSearchAgents;
        private System.Windows.Forms.ListView lstViewSuppliers;
        private System.Windows.Forms.TextBox txtSearchSuppliers;
        private System.Windows.Forms.Label lblSearchSuppliers;
    }
}