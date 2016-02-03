using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityLayer;
using MaterialSkin;
using MaterialSkin.Controls;
using TravelExpertsApp.Properties;
using TravelExpertsDB;

namespace TravelExpertsApp
{
    public partial class DockProdSupSearch : UserControl
    {
        public List<ProductSupplier> ProdSupResults = new List<ProductSupplier>();
        private List<ProductSupplier> AllProdSups;
        private string searchBy = "ProductSupplier"; //MAybe make this an Enum
        public ListView UpdateControl;

        public DockProdSupSearch()
        {
            InitializeComponent();

            AllProdSups = ProductSupplierTable.GetAllProductSuppliers();
            this.BackColor = MaterialSkinManager.Instance.ColorScheme.PrimaryColor;
        }

        private void DockProdSupSearch_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = MaterialSkinManager.Instance.ColorScheme.AccentColor;
        }

        private void DockProdSupSearch_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = MaterialSkinManager.Instance.ColorScheme.PrimaryColor;
        }

        private void DockProdSupSearch_MouseClick(object sender, MouseEventArgs e)
        {
            DockProdSupSearch_Disposing();
        }

        public void DockProdSupSearch_Disposing()
        {
            //Get Parent Control and Form
            Control parent = this.Parent;
            Form pf = this.ParentForm;
            Control[] panForms = pf.Controls.Find("panForm", true);
            Control panform = panForms[0];
            //Remove the form from the parent
            parent.Controls.Remove(this);
            //Set the new Parents Size
            panform.Size = new Size(panform.Width + this.Width, panform.Height);
            parent.Size = new Size(parent.Width - this.Width, parent.Height);
            pf.Size = new Size(pf.Width - this.Width, pf.Height);
            //Finally Dispose of this
            this.Dispose();
        }

        private void mtxtSearch_TextChanged(object sender, EventArgs e)
        {
            searchProdSups();
        }

        private void searchProdSups()
        {
            string searchStr = mtxtSearch.Text;
            ProdSupResults.Clear();
            IEnumerable<ProductSupplier> results;

            switch ( searchBy )
            {
                case "ProductSupplier":
                    results = from prodsup in AllProdSups
                              where Convert.ToString(prodsup.ProductSupplierId).StartsWith(searchStr)
                              orderby prodsup.MyProduct.ProductId
                              select prodsup;
                    ProdSupResults.AddRange(results);
                    break;
                case "Product":
                    results = from prodsup in AllProdSups
                              where Convert.ToString(prodsup.MyProduct.ProductId).StartsWith(searchStr) || Convert.ToString(prodsup.MyProduct.ProdName.ToLower()).Contains(searchStr.ToLower())
                              orderby prodsup.MyProduct.ProductId
                              select prodsup;
                    ProdSupResults.AddRange(results);
                    break;
                case "Supplier":
                    results = from prodsup in AllProdSups
                              where Convert.ToString(prodsup.MySupplier.SupplierId).StartsWith(searchStr) || Convert.ToString(prodsup.MySupplier.SupName.ToLower()).Contains(searchStr.ToLower())
                              orderby prodsup.MyProduct.ProductId
                              select prodsup;
                    ProdSupResults.AddRange(results);
                    break;
                default:
                    break;
            }
            addToResultsList();
        }

        private void addToResultsList()
        {
            lvResults.Items.Clear();
            for (int i = 0; i < ProdSupResults.Count; i++)
            {
                ProductSupplier prodsup = ProdSupResults[i];
                lvResults.Items.Add(ProdSupResults[i].ProductSupplierId.ToString());
                lvResults.Items[i].SubItems.Add(prodsup.MyProduct.ProductId + " - " +
                                                prodsup.MyProduct.ProdName);
                lvResults.Items[i].SubItems.Add(prodsup.MySupplier.SupplierId + " - " +
                                                prodsup.MySupplier.SupName);
            }
        }

        private void mrbProdSup_CheckedChanged(object sender, EventArgs e)
        {
            if (mrbProdSup.Checked)
            {
                searchBy = "ProductSupplier";
            }
            searchProdSups();
        }

        private void mrbProd_CheckedChanged(object sender, EventArgs e)
        {
            if (mrbProd.Checked)
            {
                searchBy = "Product";
            }
            searchProdSups();
        }

        private void mrbSup_CheckedChanged(object sender, EventArgs e)
        {
            if (mrbSup.Checked)
            {
                searchBy = "Supplier";
            }
            searchProdSups();
        }

        private void mbtnAccept_Click(object sender, EventArgs e)
        {
            AddToUpdateControl();
        }

        private void AddToUpdateControl()
        {
            foreach (int item in lvResults.SelectedIndices)
            {
                ProductSupplier ps = ProdSupResults[item];

                string[] row = { ps.ProductSupplierId.ToString(), ps.MyProduct.ProdName, ps.MySupplier.SupName };
                UpdateControl.Items.Add(new ListViewItem(row));
            }
        }

        private void mctxtResultsAdd_Click(object sender, EventArgs e)
        {
            AddToUpdateControl();
        }

        private void mctxtResultsClose_Click(object sender, EventArgs e)
        {
            DockProdSupSearch_Disposing();
        }

        private void lvResults_SelectedIndexChanged(object sender, EventArgs e)
        {
            mctxtResultsAdd.Enabled = (lvResults.SelectedItems.Count > 0) ? true : false;
        }

        private void mbtnCancel_Click(object sender, EventArgs e)
        {
            DockProdSupSearch_Disposing();
        }

        private void mtxtSearch_Enter(object sender, EventArgs e)
        {
            pbSearch.Image = Resources.magnifier_24_lightblue;
        }

        private void mtxtSearch_Leave(object sender, EventArgs e)
        {
            pbSearch.Image = Resources.magnifier_24__bluegrey;
        }
    }
}
