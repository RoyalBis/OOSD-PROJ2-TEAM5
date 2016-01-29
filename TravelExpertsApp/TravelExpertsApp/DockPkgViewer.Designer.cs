using System.Windows.Forms;
using MaterialSkin.Controls;

namespace TravelExpertsApp
{
    partial class DockPkgViewer
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panMain = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panMain
            // 
            this.panMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panMain.BackColor = System.Drawing.Color.White;
            this.panMain.Location = new System.Drawing.Point(9, 0);
            this.panMain.Name = "panMain";
            this.panMain.Size = new System.Drawing.Size(525, 682);
            this.panMain.TabIndex = 27;
            // 
            // Dock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.panMain);
            this.Name = "Dock";
            this.Size = new System.Drawing.Size(534, 682);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Dock_MouseClick);
            this.MouseEnter += new System.EventHandler(this.Dock_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.Dock_MouseLeave);
            this.ResumeLayout(false);
        }

        #endregion
        private Panel panMain;
    }
}
