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
            DockProdSupSearch_Disposing();
        }

        public void DockProdSupSearch_Disposing()
        {
            //Get Parent Control and Form
            Control parent = this.Parent;
            Form pf = this.ParentForm;
            //Remove the form from the parent
            parent.Controls.Remove(this);
            //Set the new Parents Size
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
                              where Convert.ToString(prodsup.MyProduct.ProductId).StartsWith(searchStr) || Convert.ToString(prodsup.MyProduct.ProdName).Contains(searchStr)
                              orderby prodsup.MyProduct.ProductId
                              select prodsup;
                    ProdSupResults.AddRange(results);
                    break;
                case "Supplier":
                    results = from prodsup in AllProdSups
                              where Convert.ToString(prodsup.MySupplier.SupplierId).StartsWith(searchStr) || Convert.ToString(prodsup.MySupplier.SupName).Contains(searchStr)
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
            //if (mrbProdSup.Checked)
            //{
            //    searchBy = "ProductSupplier";
            //}
            //searchProdSups();
        }

        private void mrbProd_CheckedChanged(object sender, EventArgs e)
        {
            //if (mrbProd.Checked)
            //{
            //    searchBy = "Product";
            //}
            //searchProdSups();
        }

        private void mrbSup_CheckedChanged(object sender, EventArgs e)
        {
            //if (mrbSup.Checked)
            //{
            //    searchBy = "Supplier";
            //}
            //searchProdSups();
        }

        private void mbtnAccept_Click(object sender, EventArgs e)
        {
            foreach (int item in lvResults.SelectedIndices)
            {
                ProductSupplier ps = ProdSupResults[item];

                string[] row = {ps.ProductSupplierId.ToString(), ps.MyProduct.ProdName, ps.MySupplier.SupName};
                UpdateControl.Items.Add(new ListViewItem(row) );
            }
        }
    }
}
