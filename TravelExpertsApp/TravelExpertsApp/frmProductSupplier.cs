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
        private List<Product> products;
        private List<Supplier> suppliers;
        public bool Add;
        public ProductSupplier ProdSuppIn;
        public ProductSupplier ProdSuppOut;

        public frmProductSupplier(Form senderForm)
        {
            InitializeComponent();
            this.Width = senderForm.Width;
            this.Location = new Point(senderForm.Left, senderForm.Top + (senderForm.Height / 2) - (this.Height / 2));
        }

        

        private void frmProductSupplier_Load(object sender, EventArgs e)
        {
            products = ProductsTable.GetAllProducts();
            suppliers = SuppliersTable.GetAllSuppliers();

            foreach (Product product in products)
            {
                //cbProduct.Add();
              cbProducts.Items.Add( product.ProductId + " - " + product.ProdName );
            }
            cbProducts.Items.Add(".....Add New Product.....");

            foreach (Supplier supplier in suppliers)
            {
                cbSuppliers.Items.Add( supplier.SupplierId + " - " + supplier.SupName );
            }
            cbSuppliers.Items.Add( ".....Add New Supplier....." );

            if ( !Add )
            {
                this.Text = $"Modify Product Supplier{ProdSuppIn.ProductSupplierId}";
                SetToProdSuppIn();
            }
            else
            {
                this.Text = "Add new Product Supplier";
            }
        }

        private void SetToProdSuppIn()
        {
            for (int i = 0; i < products.Count; i++)
            {
                if ( products[i].ProductId == ProdSuppIn.MyProduct.ProductId )
                {
                    cbProducts.SelectedIndex = i;
                }
            }

            for (int i = 0; i < suppliers.Count; i++)
            {
                if (suppliers[i].SupplierId == ProdSuppIn.MySupplier.SupplierId)
                {
                    cbSuppliers.SelectedIndex = i;
                }
            }
        }

        private void mbtnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void mbtnAccept_Click(object sender, EventArgs e)
        {
            ProdSuppOut = new ProductSupplier();
            ProdSuppOut.MyProduct = products[cbProducts.SelectedIndex];
            ProdSuppOut.MySupplier = suppliers[cbSuppliers.SelectedIndex];
            try
            {
                if (Add)
                {
                    if ( ProductSupplierTable.AddProdSupp(ProdSuppOut) )
                    {
                        AddEditSuccess();
                    }
                    else
                    {
                        string failMsg = $"Unable to add product supplier(Product: {ProdSuppOut.MyProduct.ProdName}, Supplier: {ProdSuppOut.MySupplier.SupName}).";
                        MaterialMessageBox.Show(this, false, failMsg);
                    }
                }
                else
                {
                    if ( ProductSupplierTable.UpdateProdSupp(ProdSuppOut, ProdSuppIn) )
                    {
                        AddEditSuccess();
                    }
                    else
                    {
                        string failMsg = $"Unable to edit product supplier(Product: {ProdSuppOut.MyProduct.ProdName}, Supplier: {ProdSuppOut.MySupplier.SupName}).";
                        MaterialMessageBox.Show(this, true, failMsg);
                    }
                }
            }
            catch (Exception ex)
            {
                string action = (Add) ? "add" : "edit";
                string failMsg = $"Unable to {action} product supplier(Product: {ProdSuppOut.MyProduct.ProdName}, Supplier: {ProdSuppOut.MySupplier.SupName}). {Environment.NewLine}{ex.Message}.";
                MaterialMessageBox.Show(this, false, failMsg);
            }
        }

        private void AddEditSuccess()
        {
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void cbProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ( cbProducts.SelectedIndex == cbProducts.Items.Count - 1 )
            {
                
            }
        }

        private void cbSuppliers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSuppliers.SelectedIndex == cbSuppliers.Items.Count - 1)
            {

            }
        }
    }
}
