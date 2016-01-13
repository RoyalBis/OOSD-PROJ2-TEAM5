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
using TravelExpertsDB;
using Validation;

namespace TravelExpertsApp
{
    public partial class frmProducts : Form
    {
        public frmProducts()
        {
            InitializeComponent();
        }

        public Product products;

        private void txtProductName_TextChanged(object sender, EventArgs e)
        {
            if (IsValide())
            {
                txtProductName.Text = products.ProdName.ToString();
                try
                {

                    products = ProductsTable.GetProducts(txtProductName.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
            }
        }


        private bool IsValide()
        {
          return  Validator.IsPresent(txtProductName);
                    
        }
    }
    

}
