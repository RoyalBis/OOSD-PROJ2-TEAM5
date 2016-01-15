using EntityLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelExpertsDB;
using Validation;

namespace TravelExpertsApp
{
    public partial class frmSearch : Form
    {
        public frmSearch()
        {
            InitializeComponent();
            lstViewProducts.View = View.Details;
            lstViewAgents.View = View.Details;
            lstViewPackages.View = View.Details;
            lstViewSuppliers.View = View.Details;

        }

        public static Product products;
        public static Agent agents;
        public string searchIndex = "";

        private void frmSearch_Load(object sender, EventArgs e)
        {
            //adding columns for Products search
            lstViewProducts.Columns.Add("Product ID", 90, HorizontalAlignment.Right);
            lstViewProducts.Columns.Add("Product Name", 185, HorizontalAlignment.Right);


            //adding columns for Agent search
            lstViewAgents.Columns.Add("Agent ID", 50, HorizontalAlignment.Right);
            lstViewAgents.Columns.Add("Agent Name", 95, HorizontalAlignment.Right);
            lstViewAgents.Columns.Add("Middle Name", 60, HorizontalAlignment.Right);
            lstViewAgents.Columns.Add("Last Name", 95, HorizontalAlignment.Right);
            lstViewAgents.Columns.Add("Email", 205, HorizontalAlignment.Right);
            lstViewAgents.Columns.Add("Position", 125, HorizontalAlignment.Right);

            //adding columns for Packages search
            lstViewPackages.Columns.Add("Package ID", 90, HorizontalAlignment.Right);
            lstViewPackages.Columns.Add("Package Name", 185, HorizontalAlignment.Right);

            //adding columns for Suppliers search
            lstViewSuppliers.Columns.Add("Suppliers ID", 90, HorizontalAlignment.Right);
            lstViewSuppliers.Columns.Add("Suppliers Name", 185, HorizontalAlignment.Right);


        }


        private void txtProductName_TextChanged(object sender, EventArgs e)
        {
            //refreshes and clears the listview
            this.lstViewProducts.Items.Clear();
            this.lstViewProducts.Update();  // In case there is databinding
            this.lstViewProducts.Refresh(); // Redraw items
            //
            searchIndex = txtProductName.Text;
            List<Product> allProducts = new List<Product>();
            allProducts = ProductsTable.SearchAllProducts(searchIndex);

                try
                {
                    string[] arr = new string[2];
                    foreach (Product ValueType in allProducts)
                    {

                        //Add items in an array
                        arr[0] = ValueType.ProductId.ToString();
                        arr[1] = ValueType.ProdName.ToString();

                        //add items in the list
                        var listViewItem = new ListViewItem(arr);

                        //populates the listview
                        lstViewProducts.Items.Add(listViewItem);

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {

        }

        private void txtSearchAgents_TextChanged(object sender, EventArgs e)
        {
            //refreshes and clears the listview
            this.lstViewAgents.Items.Clear();
            this.lstViewAgents.Update();  // In case there is databinding
            this.lstViewAgents.Refresh(); // Redraw items

            //
            searchIndex = txtSearchAgents.Text;
            List<Agent> allAgents = new List<Agent>();
            allAgents = AgentTable.SearchAllAgents(searchIndex);

            try
            {
                string[] arr = new string[6];
                foreach (Agent ValueAgent in allAgents)
                {

                    //Add items in an array
                    arr[0] = ValueAgent.AgentId.ToString();
                    arr[1] = ValueAgent.AgentFirstName.ToString();
                    arr[2] = ValueAgent.AgentMiddleInitial.ToString();
                    arr[3] = ValueAgent.AgentLastName.ToString();
                    arr[4] = ValueAgent.AgentEmail.ToString();
                    arr[5] = ValueAgent.AgentPosition.ToString();

                    //add items in the list
                    var listViewItem = new ListViewItem(arr);

                    //populates the listview
                    lstViewAgents.Items.Add(listViewItem);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }

        }
    }


}