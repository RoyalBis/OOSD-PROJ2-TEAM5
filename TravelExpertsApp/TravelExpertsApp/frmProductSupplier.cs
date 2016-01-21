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
    public partial class frmProductSupplier : MaterialForm
    {
        private List<ProductSupplier> prodsups;
        private List<Product> products;
        private List<Supplier> suppliers;

        public frmProductSupplier()
        {
            InitializeComponent();
        }

        private void frmProductSupplier_Load(object sender, EventArgs e)
        {
            prodsups = ProductSupplierTable.GetAllProductSuppliers();
            products = ProductsTable.GetAllProducts();
            suppliers = SuppliersTable.GetAllSuppliers();

            foreach (ProductSupplier prodsup in prodsups)
            {
                cbProductSupplier.Items.Add(prodsup.ProductSupplierId + "  -  " + prodsup.MyProduct.ProductId + ":" +
                                            prodsup.MyProduct.ProdName + "  -  " + prodsup.MySupplier.SupplierId + ":" +
                                            prodsup.MySupplier.SupName);
            }
            foreach (Product product in products)
            {
                cbProduct.Items.Add(product.ProductId + " - " + product.ProdName);
            }

            foreach (Supplier supplier in suppliers)
            {
                cbSupplier.Items.Add(supplier.SupplierId + " - " + supplier.SupName);
            }
            cbProductSupplier.Items.Add(".....Add New Product Supplier.....");
            cbProduct.Items.Add(".....Add New Product.....");
            cbSupplier.Items.Add(".....Add New Supplier.....");

            cbProduct.Enabled = false;
            cbSupplier.Enabled = false;
        }

        private void mbtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mbtnAccept_Click(object sender, EventArgs e)
        {

        }

        private void cbProductSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ( cbProductSupplier.SelectedIndex == cbProductSupplier.Items.Count - 1 )
            {
                cbProduct.Enabled = true;
                cbSupplier.Enabled = true;
            }
        }
    }
}
