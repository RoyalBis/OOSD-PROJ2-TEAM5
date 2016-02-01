using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityLayer;
using MaterialSkin.Controls;
using TravelExpertsApp.Annotations;
using TravelExpertsDB;

namespace TravelExpertsApp
{
    public partial class frmMain : MaterialForm, IPkgViewerDocker
    {
        private int activePkgId;

        public frmMain()
        {
            InitializeComponent();
            MyPkgViewer = null;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            FillPackages();
        }

        public void FillPackages()
        {
            MyPackageList = PackagesTable.GetAllPackages();
            lvPackages.Items?.Clear();
            foreach (Package pkg in MyPackageList)
            {
                string[] row =
                {
                    pkg.PackageId.ToString(),
                    pkg.PkgName,
                    pkg.PkgDesc,
                    pkg.PkgStartDate.ToShortDateString(),
                    pkg.PkgEndDate.ToShortDateString(),
                    pkg.PkgBasePrice.ToString("c"),
                    pkg.PkgAgencyCommission.ToString("c")
                };
                lvPackages.Items.Add(new ListViewItem(row));
            }
        }

        private void mbtnAdd_Click(object sender, EventArgs e)
        {
            //hide panel
            Panel hidePanel = new Panel();
            hidePanel.Size = this.Size;
            hidePanel.BackColor = Color.FromArgb(200, 0, 0, 0);
            this.Controls.Add(hidePanel);
            hidePanel.BringToFront();

            //create new package form: add
            frmPkgAddModify addPkgForm = new frmPkgAddModify();
            addPkgForm.PkgIn = null;
            addPkgForm.Add = true;
            DialogResult result = addPkgForm.ShowDialog();

            if ( result != DialogResult.None )
            {
                hidePanel.Dispose();
                if ( result == DialogResult.OK )
                {
                    FillPackages();
                    ActivePkgId = MyPackageList.Count - 1;
                }
            }
        }

        private void lvPackages_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ( MyPkgViewer == null )
            {
                MyPkgViewer = new DockPkgViewer(this.panDock);
            }
            if ( lvPackages.FocusedItem != null )
            {
                ActivePkgId = lvPackages.FocusedItem.Index;
                mbtnDelete.Enabled = true;
                mbtnEdit.Enabled = true;
            }
            else
            {
                mbtnDelete.Enabled = false;
                mbtnEdit.Enabled = false;
            }
        }

        private void lvPackages_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if ( e.Button != MouseButtons.Left )
            {
                return;
            }
            MaterialListView thisListView = (MaterialListView)sender;
            //create new package form: add
            frmPkgAddModify modifyPkgForm = new frmPkgAddModify();
            modifyPkgForm.PkgIn = MyPackageList[thisListView.FocusedItem.Index];
            modifyPkgForm.Add = false;
            //Panel hidePanel = new Panel();
            //hidePanel.Size = this.Size;
            //hidePanel.BackColor = Color.FromArgb(200, 0, 0, 0);
            //this.Controls.Add(hidePanel);
            //hidePanel.BringToFront();
            DialogResult result = modifyPkgForm.ShowDialog();
        }

        public DockPkgViewer MyPkgViewer { get; set; }
        public PackageList MyPackageList { get; set; }
        public Panel PanDock => panDock;
        public Panel PanForm => panForm;
        public Form FormInstance => this;

        public int ActivePkgId
        {
            get { return activePkgId; }
            set
            {
                activePkgId = value;
                activePkgId = ActivePkgId < MyPackageList.Count
                                  ? ((ActivePkgId >= 0) ? activePkgId : MyPackageList.Count - 1)
                                  : 0;
                UpdateActivePackage();
            }
        }

        private void UpdateActivePackage()
        {
            if (MyPkgViewer != null) MyPkgViewer?.DisplayActivePkg();
            if ( lvPackages.FocusedItem.Index != ActivePkgId )
            {
                lvPackages.Items[ActivePkgId].Focused = true;
                lvPackages.Items[ActivePkgId].Selected = true;
            }
        }
    }
}
