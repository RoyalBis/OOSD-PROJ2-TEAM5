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

/**********************************************************************
Title:                frmProductSupplier.cs  
 Project:          Travel Experts Desktop App
Authors:         Royal Bissell, Kevin Liao, Annie Ali, Lee Harrold
Class:               OOSD Fall 2015 
Date:               2016/02/07
Description:  Simple form to add or update a Product Supplier
**********************************************************************/

namespace TravelExpertsApp
{
    public partial class frmProductSupplier : MaterialForm
    {
        //list of all products and suppliers for dropdowns
        private List<Product> products;
        private List<Supplier> suppliers;
        public bool Add;    //true if adding a product supplier
        public ProductSupplier ProdSuppIn;  //the existing product supplier on an edit action
        public ProductSupplier ProdSuppOut;     //the new product supplier

        public frmProductSupplier(Form senderForm)
        {
            InitializeComponent();
            //when this form is made, make it the right size
            this.Width = senderForm.Width;
            this.Location = new Point(senderForm.Left, senderForm.Top + (senderForm.Height / 2) - (this.Height / 2));
        }

        

        private void frmProductSupplier_Load(object sender, EventArgs e)
        {
            //load the list of products and suppliers
            products = ProductsTable.GetAllProducts();
            suppliers = SuppliersTable.GetAllSuppliers();

            //add the products to the combo box
            foreach (Product product in products)
            {
                //cbProduct.Add();
              cbProducts.Items.Add( product.ProductId + " - " + product.ProdName );
            }
            //cbProducts.Items.Add(".....Add New Product.....");

            //add the suppliers to the combo box
            foreach (Supplier supplier in suppliers)
            {
                cbSuppliers.Items.Add( supplier.SupplierId + " - " + supplier.SupName );
            }
            //cbSuppliers.Items.Add( ".....Add New Supplier....." );

            //set the info displayed based on whether we are adding or modifying
            if ( !Add )
            {
                //this is a modify action so dispaly the existing productsupplier
                this.Text = $"Modify Product Supplier{ProdSuppIn.ProductSupplierId}";
                SetToProdSuppIn();
            }
            else
            {
                //just an add action
                this.Text = "Add new Product Supplier";
            }
        }

        /// <summary>
        /// Displays the Existing ProductSupplier's Product and Supplier in the Combo Boxes
        /// </summary>
        private void SetToProdSuppIn()
        {
            //Dispalys the Current Product
            for (int i = 0; i < products.Count; i++)
            {
                if ( products[i].ProductId == ProdSuppIn.MyProduct.ProductId )
                {
                    cbProducts.SelectedIndex = i;
                }
            }

            //Dispalys the Current Product
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
            //make a new productsupplier
            ProdSuppOut = new ProductSupplier();
            //set product using the product list and selection from the combo box
            ProdSuppOut.MyProduct = products[cbProducts.SelectedIndex];
            //set supplier using the supplier list and selection from the combo box
            ProdSuppOut.MySupplier = suppliers[cbSuppliers.SelectedIndex];
            try
            {
                //if we are adding a product supplier, add it!
                if (Add)
                {
                    if ( ProductSupplierTable.AddProdSupp(ProdSuppOut) )
                    {
                        //productsupplier was added successfully
                        AddEditSuccess();
                    }
                    else
                    {
                        //adding the product supplier failed
                        string failMsg = $"Unable to add product supplier(Product: {ProdSuppOut.MyProduct.ProdName}, Supplier: {ProdSuppOut.MySupplier.SupName}).";
                        MaterialMessageBox.Show(this, false, failMsg);
                    }
                }
                else
                {
                    //we are modifying the product supplier so modify it!
                    if ( ProductSupplierTable.UpdateProdSupp(ProdSuppOut, ProdSuppIn) )
                    {
                        //productsupplier was modified successfully
                        AddEditSuccess();
                    }
                    else
                    {
                        //modifing the product failedm 
                        string failMsg = $"Unable to edit product supplier(Product: {ProdSuppOut.MyProduct.ProdName}, Supplier: {ProdSuppOut.MySupplier.SupName}).";
                        MaterialMessageBox.Show(this, false, failMsg);
                    }
                }
            }
            catch (Exception ex)
            {
                //an error occured for the add or modify, display the failure to the user and the message associated
                string action = (Add) ? "add" : "edit";
                string failMsg = $"Unable to {action} product supplier(Product: {ProdSuppOut.MyProduct.ProdName}, Supplier: {ProdSuppOut.MySupplier.SupName}). {Environment.NewLine}{ex.Message}.";
                MaterialMessageBox.Show(this, false, failMsg);
            }
        }

        /// <summary>
        /// Successfully added/modified the productsupplier
        /// </summary>
        private void AddEditSuccess()
        {
            this.DialogResult = DialogResult.OK;
            Close();
        }
    }
}
