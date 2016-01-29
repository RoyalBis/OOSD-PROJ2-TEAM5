using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;

namespace TravelExpertsApp
{
    public partial class DockPkgViewer : UserControl
    {
        public Control UpdateControl;
        public Panel MyDockingPanel;
        public Form MyForm;
        public Panel SiblingFormPanel;

        public DockPkgViewer()
        {
            InitializeComponent();
        }

        public DockPkgViewer(Panel dockingPanel)
        {
            InitializeComponent();
            MyDockingPanel = dockingPanel;
            MyForm = MyDockingPanel.FindForm();
            SiblingFormPanel = (Panel)MyDockingPanel.Parent.Controls.Find("panForm", true)[0];
            AddDock();
        }

        public DockPkgViewer(Panel dockingPanel, Control updateControl) : this(dockingPanel)
        {
            this.UpdateControl = updateControl;
        }

        public void AddDock()
        {
            MyDockingPanel.Width = this.Width;
            SiblingFormPanel.Width = SiblingFormPanel.Width - this.Width;
            MyForm.Size = new Size(MyForm.Width + this.Width, MyForm.Height);
            MyDockingPanel.Controls.Add(this);
            this.Dock = DockStyle.Fill;
        }

        private void Dock_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = MaterialSkinManager.Instance.ColorScheme.AccentColor;
        }

        private void Dock_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = MaterialSkinManager.Instance.ColorScheme.PrimaryColor;
        }

        private void Dock_MouseClick(object sender, MouseEventArgs e)
        {
            Dock_Disposing();
        }

        public void Dock_Disposing()
        {
            //Remove the form from the parent
            MyDockingPanel.Controls.Remove(this);
            //Set the new Parents Size
            SiblingFormPanel.Size = new Size(SiblingFormPanel.Width + this.Width, SiblingFormPanel.Height);
            MyDockingPanel.Size = new Size(MyDockingPanel.Width - this.Width, MyDockingPanel.Height);
            MyForm.Size = new Size(MyForm.Width - this.Width, MyForm.Height);
            //Finally Dispose of this
            this.Dispose();
        }

        private void AddToUpdateControl()
        {
            
        }
    }
}
