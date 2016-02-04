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
    /// <summary>
    /// Docking Control to Browser Product Suppliers
    /// </summary>
    public partial class DockProdSupSearch : UserControl
    {
        //TODO: Make this Docking Control Be on a From that Inherits from a IProdSupSearchDocker
        public List<ProductSupplier> ProdSupResults = new List<ProductSupplier>();  //The Product Supplier Search Results
        private List<ProductSupplier> AllProdSups;  //List of All Product Suppliers
        private string searchBy = "ProductSupplier"; //Maybe make this an Enum
        public ListView UpdateControl;  //This is theControl that this Docking Control Updates

        public DockProdSupSearch()
        {
            InitializeComponent();
            //Get all Product Suppliers
            AllProdSups = ProductSupplierTable.GetAllProductSuppliers();
            //Set the Background Color to the Primary Theme Color
            this.BackColor = MaterialSkinManager.Instance.ColorScheme.PrimaryColor;
        }

        /// <summary>
        /// Takes care of reszing the parent form when this Control is disposed
        /// </summary>
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

        #region Docking Control Closing And Highlighting Events
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
        #endregion

        #region Searching Methods and Events
        private void mtxtSearch_TextChanged(object sender, EventArgs e)
        {
            //When the text changes search again
            searchProdSups();
        }

        /// <summary>
        /// Method to Search For Mateches to the Product Supplier
        /// </summary>
        private void searchProdSups()
        {
            string searchStr = mtxtSearch.Text;
            ProdSupResults.Clear();
            IEnumerable<ProductSupplier> results;   //IEnumerable to handle the three linq statements

            //Switch to search based on a Product Supplier, Product, or Supplier
            switch ( searchBy )
            {
                //Product Supplier Search
                case "ProductSupplier":
                    results = from prodsup in AllProdSups
                              where Convert.ToString(prodsup.ProductSupplierId).StartsWith(searchStr)   //Just serach by Id here and only starts with, because a mid-num search is wierd
                              orderby prodsup.MyProduct.ProductId
                              select prodsup;
                    break;
                //Product Search
                case "Product":
                    results = from prodsup in AllProdSups
                              where Convert.ToString(prodsup.MyProduct.ProductId).StartsWith(searchStr) || 
                                            Convert.ToString(prodsup.MyProduct.ProdName.ToLower()).Contains(searchStr.ToLower())
                              orderby prodsup.MyProduct.ProductId
                              select prodsup;
                    break;
                //Supplier Search
                case "Supplier":
                    results = from prodsup in AllProdSups
                              where Convert.ToString(prodsup.MySupplier.SupplierId).StartsWith(searchStr) || 
                                            Convert.ToString(prodsup.MySupplier.SupName.ToLower()).Contains(searchStr.ToLower())
                              orderby prodsup.MyProduct.ProductId
                              select prodsup;
                    break;
                default:
                    results = null;
                    break;
            }
            ProdSupResults.AddRange(results);
            addToResultsList();
        }

        /// <summary>
        /// Displays the Results on the Results List View
        /// </summary>
        private void addToResultsList()
        {
            lvResults.Items.Clear();
            for (int i = 0; i < ProdSupResults.Count; i++)
            {
                ProductSupplier prodsup = ProdSupResults[i];
                //ProductSupplierId
                lvResults.Items.Add(ProdSupResults[i].ProductSupplierId.ToString());
                //Product Id - Product Name
                lvResults.Items[i].SubItems.Add(prodsup.MyProduct.ProductId + " - " +
                                                prodsup.MyProduct.ProdName);
                //Supplier Id - Supplier Name
                lvResults.Items[i].SubItems.Add(prodsup.MySupplier.SupplierId + " - " +
                                                prodsup.MySupplier.SupName);
            }
        }
        #endregion

        #region SearchBy RadioButton Events
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
        #endregion

        #region UpdateControl Events and Methods
        private void mbtnAccept_Click(object sender, EventArgs e)
        {
            AddToUpdateControl();
        }

        private void mctxtResultsAdd_Click(object sender, EventArgs e)
        {
            AddToUpdateControl();
        }

        /// <summary>
        /// Updates this Docking Controls ListView
        /// </summary>
        private void AddToUpdateControl()
        {
            foreach (int item in lvResults.SelectedIndices)
            {
                ProductSupplier ps = ProdSupResults[item];

                string[] row = { ps.ProductSupplierId.ToString(), ps.MyProduct.ProdName, ps.MySupplier.SupName };
                UpdateControl.Items.Add(new ListViewItem(row));
            }
        }

        private void lvResults_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Something is selected in the results view so we can enable the
            if (lvResults.SelectedItems.Count > 0)
            {
                mctxtResultsAdd.Enabled = true;
                mbtnAccept.Enabled = true;
            }
            else
            {
                mctxtResultsAdd.Enabled = false;
                mbtnAccept.Enabled = false;
            }
        }
        #endregion

        #region Close Events
        private void mctxtResultsClose_Click(object sender, EventArgs e)
        {
            DockProdSupSearch_Disposing();
        }

        private void mbtnCancel_Click(object sender, EventArgs e)
        {
            DockProdSupSearch_Disposing();
        }
        #endregion

        #region Search Image Events
        private void mtxtSearch_Enter(object sender, EventArgs e)
        {
            pbSearch.Image = Resources.magnifier_24_lightblue;
        }

        private void mtxtSearch_Leave(object sender, EventArgs e)
        {
            pbSearch.Image = Resources.magnifier_24__bluegrey;
        }
        #endregion
    }
}
