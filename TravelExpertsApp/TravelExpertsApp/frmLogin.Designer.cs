namespace TravelExpertsApp
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.btnLogin = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtAgentName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtAgentPassword = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.btnExit = new MaterialSkin.Controls.MaterialRaisedButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mdivBtns = new MaterialSkin.Controls.MaterialDivider();
            this.panForm = new System.Windows.Forms.Panel();
            this.pan = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panForm.SuspendLayout();
            this.pan.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Depth = 0;
            this.btnLogin.Location = new System.Drawing.Point(257, 4);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Primary = true;
            this.btnLogin.Size = new System.Drawing.Size(100, 28);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtAgentName
            // 
            this.txtAgentName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtAgentName.Depth = 0;
            this.txtAgentName.Hint = "";
            this.txtAgentName.Location = new System.Drawing.Point(226, 38);
            this.txtAgentName.Margin = new System.Windows.Forms.Padding(4);
            this.txtAgentName.MaxLength = 32767;
            this.txtAgentName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtAgentName.Name = "txtAgentName";
            this.txtAgentName.PasswordChar = '\0';
            this.txtAgentName.SelectedText = "";
            this.txtAgentName.SelectionLength = 0;
            this.txtAgentName.SelectionStart = 0;
            this.txtAgentName.Size = new System.Drawing.Size(172, 28);
            this.txtAgentName.TabIndex = 1;
            this.txtAgentName.TabStop = false;
            this.txtAgentName.Tag = "Username";
            this.txtAgentName.UseSystemPasswordChar = false;
            // 
            // txtAgentPassword
            // 
            this.txtAgentPassword.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtAgentPassword.Depth = 0;
            this.txtAgentPassword.Hint = "";
            this.txtAgentPassword.Location = new System.Drawing.Point(226, 86);
            this.txtAgentPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtAgentPassword.MaxLength = 32767;
            this.txtAgentPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtAgentPassword.Name = "txtAgentPassword";
            this.txtAgentPassword.PasswordChar = '\0';
            this.txtAgentPassword.SelectedText = "";
            this.txtAgentPassword.SelectionLength = 0;
            this.txtAgentPassword.SelectionStart = 0;
            this.txtAgentPassword.Size = new System.Drawing.Size(172, 28);
            this.txtAgentPassword.TabIndex = 2;
            this.txtAgentPassword.TabStop = false;
            this.txtAgentPassword.Tag = "Password";
            this.txtAgentPassword.UseSystemPasswordChar = true;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(62, 40);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(100, 24);
            this.materialLabel1.TabIndex = 3;
            this.materialLabel1.Text = "Username:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(62, 91);
            this.materialLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(99, 24);
            this.materialLabel2.TabIndex = 4;
            this.materialLabel2.Text = "Password:";
            // 
            // btnExit
            // 
            this.btnExit.Depth = 0;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(365, 4);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnExit.Name = "btnExit";
            this.btnExit.Primary = true;
            this.btnExit.Size = new System.Drawing.Size(100, 28);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.mdivBtns);
            this.panel1.Controls.Add(this.panForm);
            this.panel1.Controls.Add(this.pan);
            this.panel1.Location = new System.Drawing.Point(0, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(476, 202);
            this.panel1.TabIndex = 6;
            // 
            // mdivBtns
            // 
            this.mdivBtns.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mdivBtns.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mdivBtns.Depth = 0;
            this.mdivBtns.Location = new System.Drawing.Point(3, 160);
            this.mdivBtns.MouseState = MaterialSkin.MouseState.HOVER;
            this.mdivBtns.Name = "mdivBtns";
            this.mdivBtns.Size = new System.Drawing.Size(470, 1);
            this.mdivBtns.TabIndex = 2;
            this.mdivBtns.Text = "materialDivider1";
            // 
            // panForm
            // 
            this.panForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panForm.Controls.Add(this.materialLabel2);
            this.panForm.Controls.Add(this.materialLabel1);
            this.panForm.Controls.Add(this.txtAgentName);
            this.panForm.Controls.Add(this.txtAgentPassword);
            this.panForm.Location = new System.Drawing.Point(4, 4);
            this.panForm.Name = "panForm";
            this.panForm.Size = new System.Drawing.Size(469, 154);
            this.panForm.TabIndex = 1;
            // 
            // pan
            // 
            this.pan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pan.Controls.Add(this.btnExit);
            this.pan.Controls.Add(this.btnLogin);
            this.pan.Location = new System.Drawing.Point(3, 164);
            this.pan.Name = "pan";
            this.pan.Size = new System.Drawing.Size(470, 35);
            this.pan.TabIndex = 0;
            // 
            // frmLogin
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(476, 266);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmLogin";
            this.Sizable = false;
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panForm.ResumeLayout(false);
            this.panForm.PerformLayout();
            this.pan.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton btnLogin;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtAgentName;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtAgentPassword;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialRaisedButton btnExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panForm;
        private System.Windows.Forms.Panel pan;
        private MaterialSkin.Controls.MaterialDivider mdivBtns;
    }
}