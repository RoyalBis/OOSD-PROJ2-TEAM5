using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityLayer;
using MaterialSkin.Controls;
using TravelExpertsDB;

namespace TravelExpertsApp
{
    public partial class frmMain : MaterialForm
    {
        private DockPkgViewer pkgViewer;
        private PackageList packages;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            packages = PackagesTable.GetAllPackages();
            PopulateListView();

        }

        private void PopulateListView()
        {
            lvPackages.Items?.Clear();
            Package myPkg;
            for (int i = 0; i < packages.Count; i++)
            {
                myPkg = packages[i];
                string[] row =
                {
                    myPkg.PackageId.ToString(),
                    myPkg.PkgName,
                    myPkg.PkgDesc,
                    myPkg.PkgStartDate.ToShortDateString(),
                    myPkg.PkgEndDate.ToShortDateString(),
                    myPkg.PkgBasePrice.ToString("c"),
                    myPkg.PkgAgencyCommission.ToString()
                };
                lvPackages.Items.Add(new ListViewItem(row));
            }
        }

        private void mbtnAdd_Click(object sender, EventArgs e)
        {
            pkgViewer = new DockPkgViewer(panDock);
        }
    }
}
