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
    public partial class DockProdSupSearch : UserControl
    {
        public DockProdSupSearch()
        {
            InitializeComponent();
        }

        private void DockProdSupSearch_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.Gray;
        }

        private void DockProdSupSearch_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(64,64,64);
        }

        private void DockProdSupSearch_MouseClick(object sender, MouseEventArgs e)
        {
            //this.Dispose();
            //var mySize = this.Size;
            //this.ParentForm.Refresh();
            //mySize = this.Size;
            Control parent = this.Parent;
            Form pf = this.ParentForm;
            parent.Controls.Remove(this);
            parent.Size = new Size(parent.Width - this.Width, parent.Height);
            pf.Size = new Size(pf.Width - this.Width, pf.Height);
            parent.Refresh();
            pf.Refresh();
            this.Dispose();
        }
    }
}
