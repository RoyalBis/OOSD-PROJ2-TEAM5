using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using EntityLayer;
using MaterialSkin;
using TravelExpertsApp.Properties;
using TravelExpertsDB;

namespace TravelExpertsApp
{
    public partial class DockPkgViewer : UserControl
    {
        public Control UpdateControl;
        public Panel MyDockingPanel;
        public IPkgViewerDocker MyDocker;
        public Panel SiblingFormPanel;
        public Package ActivePackage;

        public DockPkgViewer()
        {
            InitializeComponent();
        }

        public DockPkgViewer(Panel dockingPanel)
        {
            InitializeComponent();
            MyDockingPanel = dockingPanel;
            MyDocker = (IPkgViewerDocker)MyDockingPanel.FindForm();
            SiblingFormPanel = (Panel)MyDockingPanel.Parent.Controls.Find("panForm", true)[0];
            AddDock();
        }

        public void AddDock()
        {
            int newHeight = (this.Height > MyDocker.FormInstance.Height) ? this.Height : MyDocker.FormInstance.Height;
            MyDockingPanel.Width = this.Width;
            SiblingFormPanel.Width = SiblingFormPanel.Width - this.Width;
            MyDocker.FormInstance.Size = new Size(MyDocker.FormInstance.Width + this.Width, newHeight);
            MyDockingPanel.Controls.Add(this);
            this.Dock = DockStyle.Fill;
            if ( MyDocker.FormInstance.Width + MyDocker.FormInstance.Left > Screen.PrimaryScreen.Bounds.Width )
            {
                MyDocker.FormInstance.Left = 0;
                //MyDocker.FormInstance.WindowState = FormWindowState.Maximized;
                int oversize = MyDocker.FormInstance.Width - Screen.PrimaryScreen.Bounds.Width;
                MyDocker.FormInstance.Width -= oversize;
                //SiblingFormPanel.Width -= oversize;
            }
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
            MyDocker.FormInstance.Size = new Size(MyDocker.FormInstance.Width - this.Width, MyDocker.FormInstance.Height);
            //Finally Dispose of this
            this.Dispose();
        }

        private void pbLeft_Click(object sender, EventArgs e)
        {
            MyDocker.ActivePkgId -= 1;
        }

        private void pbLeft_MouseEnter(object sender, EventArgs e)
        {
            pbLeft.Image = Resources.keyboard_left_lightblue;
        }

        private void pbLeft_MouseLeave(object sender, EventArgs e)
        {
            pbLeft.Image = Resources.keyboard_left_bluegrey;
        }

        private void pbRight_Click(object sender, EventArgs e)
        {
            MyDocker.ActivePkgId += 1;
        }

        private void pbRight_MouseEnter(object sender, EventArgs e)
        {
            pbRight.Image = Resources.keyboard_right_lightblue;
        }

        private void pbRight_MouseLeave(object sender, EventArgs e)
        {
            pbRight.Image = Resources.keyboard_right_bluegrey;
        }

        private void DockPkgViewer_Load(object sender, EventArgs e)
        {
            DisplayActivePkg();
        }

        public void DisplayActivePkg()
        {
            ActivePackage = MyDocker.MyPackageList[MyDocker.ActivePkgId];
            ProductSupplierTable.AssignPkgProductSuppliers(ActivePackage);
            lblPkg.Text = ActivePackage.PkgName;
            txtDescription.Text = ActivePackage.PkgDesc;
            mlblStartDate.Text = ActivePackage.PkgStartDate.ToShortDateString();
            mlblEndDate.Text = ActivePackage.PkgEndDate.ToShortDateString();
            mlblBasePrice.Text = ActivePackage.PkgBasePrice.ToString("c");
            mlblCommission.Text = ActivePackage.PkgAgencyCommission.ToString("c");
            try
            {
                pbPkgImage.Image = ActivePackage.ImageFromBytes();
            }
            catch ( Exception )
            {
                pbPkgImage.Image = Resources.X_512_bluegrey;
            }

            //Fill the List view with the Product Suppliers
            mlvProdSuppliers.Items.Clear();
            var ps = ActivePackage.PkgProductSuppliers;
            for (int i = 0; i < ps.Count; i++)
            {
                //lvPkgProductSuppliers.Items.Add((ps[i]))
                mlvProdSuppliers.Items.Add(ps[i].ProductSupplierId.ToString());
                mlvProdSuppliers.Items[i].SubItems.Add(ps[i].MyProduct.ProdName);
                mlvProdSuppliers.Items[i].SubItems.Add(ps[i].MySupplier.SupName);
            }
        }

        private void mbtnAccept_Click(object sender, EventArgs e)
        {
            //hide panel
            Panel hidePanel = new Panel();
            hidePanel.Size = MyDocker.FormInstance.Size;
            hidePanel.BackColor = Color.FromArgb(200, 0, 0, 0);
            MyDocker.FormInstance.Controls.Add(hidePanel);
            hidePanel.BringToFront();

            //create new package form: add
            frmPkgAddModify modifyPkgForm = new frmPkgAddModify();
            modifyPkgForm.PkgIn = ActivePackage;
            modifyPkgForm.Add = false;
            DialogResult result = modifyPkgForm.ShowDialog();
            if ( result != DialogResult.None )
            {
                hidePanel.Dispose();
                if (result == DialogResult.OK)
                {
                    MyDocker.FillPackages();
                    MyDocker.ActivePkgId = MyDocker.ActivePkgId;
                }
            }
        }

        private void mbtnCancel_Click(object sender, EventArgs e)
        {
            Dock_Disposing();
        }

        private void mbtnDelete_Click(object sender, EventArgs e)
        {
            string delMsg =
                $"Are you sure you want to permantely delete Package {ActivePackage.PackageId}: {ActivePackage.PkgName}?";
            string successMsg = $"Package {ActivePackage.PackageId}: {ActivePackage.PkgName}  has been deleted successfully.";
            string failMsg = $"Package {ActivePackage.PackageId}: {ActivePackage.PkgName} could not be deleted.";
            if ( ActivePackage != null ) //check in case there is nothing to delete
            {
                //confirmation box
                DialogResult result = MaterialMessageBox.Show(MyDocker.FormInstance, true, delMsg);
                if ( result == DialogResult.OK )
                {
                    try //delete
                    {
                        PackagesProductsSuppliersTable.DeletePkgProdSup(ActivePackage.PackageId);
                        if (PackagesTable.DeletePackage(ActivePackage) )
                        {
                            MyDocker.FillPackages();
                            MaterialMessageBox.Show(MyDocker.FormInstance, false, successMsg);
                        }
                        else
                        {
                            MaterialMessageBox.Show(MyDocker.FormInstance, false, failMsg);
                        }
                    }
                    catch ( Exception ex )
                    {
                        MaterialMessageBox.Show(MyDocker.FormInstance, false,
                                                failMsg + $"{Environment.NewLine}Error: {ex}.");
                    }
                }
            }
        }
    }
}
