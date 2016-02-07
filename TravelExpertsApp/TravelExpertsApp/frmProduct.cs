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
using Validation;

/**********************************************************************
Title:                frmProduct.cs  
 Project:          Travel Experts Desktop App
Authors:         Royal Bissell, Kevin Liao, Annie Ali, Lee Harrold
Class:               OOSD Fall 2015 
Date:               2016/02/07
Description:  Simple form to add or update a Product
**********************************************************************/

namespace TravelExpertsApp
{
    public partial class frmProduct : MaterialForm
    {
        public bool Add;        //true if adding a product
        public Product ProdIn;  //the exisitng product on an edit action
        public Product ProdOut;     //the new product

        public frmProduct(Form senderForm)
        {
            InitializeComponent();
            //when this form is made, make it the right size
            this.Width = senderForm.Width;
            this.Location = new Point(senderForm.Left, senderForm.Top + (senderForm.Height / 2) - (this.Height / 2));
        }

        private void frmProduct_Load(object sender, EventArgs e)
        {
            //set the info displayed based on whether we are adding or modifying
            if (!Add)
            {
                //this is a modify action so set the display the existing product info
                this.Text = $"Modify Product {ProdIn.ProdName}";
                SetToProdIn();
            }
            else
            {
                //just and add actioln
                this.Text = "Add new Product";
            }
        }

        /// <summary>
        /// Displays the Existing Product Info
        /// </summary>
        private void SetToProdIn()
        {
            mtxtProductName.Text = ProdIn.ProdName;
        }

        private void mbtnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void mbtnAccept_Click(object sender, EventArgs e)
        {
            //check if the input is valid
            Result message = isValid();
            if (message.Success )
            {
                //input is valid, so make new product with the input
                ProdOut = new Product();
                ProdOut.ProdName = mtxtProductName.Text;
                try
                {
                    //if we are adding a product, add it
                    if (Add)
                    {
                        if (ProductsTable.AddProduct(ProdOut))
                        {
                            //product was added successfully.
                            AddEditSuccess();
                        }
                        else
                        {
                            //adding the product failed, let the user know this
                            string failMsg = $"Unable to add Product: {ProdOut.ProdName}.";
                            MaterialMessageBox.Show(this, false, failMsg);
                        }
                    }
                    //we are modifying a product, so modify it.
                    else
                    {
                        if (ProductsTable.UpdateProduct(ProdOut, ProdIn))
                        {
                            //product was modified successfully
                            AddEditSuccess();
                        }
                        else
                        {
                            //modifying product failes so let the user know
                            string failMsg = $"Unable to edit Product: {ProdOut.ProdName}.";
                            MaterialMessageBox.Show(this, false, failMsg);
                        }
                    }
                }
                catch (Exception ex)
                {
                    //there was an exception thrown for this add/modify so let the user know and display the message
                    //this is likely an Sql Exception
                    string action = (Add) ? "add" : "edit";
                    string failMsg = $"Unable to {action} Product: {ProdOut.ProdName}, . {Environment.NewLine}{ex.Message}.";
                    MaterialMessageBox.Show(this, false, failMsg);
                }
            }
            else
            {
                //invalid user entry, so display the failed validation message
                MaterialMessageBox.Show(this, message);
            }
        }

        /// <summary>
        /// Successfully added/modifed the product
        /// </summary>
        private void AddEditSuccess()
        {
            //just set the dialog result and close.
            this.DialogResult = DialogResult.OK;
            Close();
        }

        /// <summary>
        /// User Input Validation
        /// </summary>
        /// <returns>A Result Object</returns>
        private Result isValid()
        {
            //Validation Array
            Result[] results = new Result[1];
            results[0] = Validator.IsPresent(mtxtProductName);

            //if any of the validation returns false, return that message
            foreach (Result result in results)
            {
                if (!result.Success) return result;
            }
            //valid user input, so return true
            return new Result(true);
        }
    }
}
