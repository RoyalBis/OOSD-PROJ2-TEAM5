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

namespace TravelExpertsApp
{
    public partial class frmSupplier : MaterialForm
    {
        public bool Add;    //true if adding a supplier
        public Supplier SuppIn;     //this existing supplier on an edit action
        public Supplier SuppOut;        //the new supplier

        public frmSupplier(Form senderForm)
        {
            InitializeComponent();
            //when this form is made, make it the right size
            this.Width = senderForm.Width;
            this.Location = new Point(senderForm.Left, senderForm.Top + (senderForm.Height / 2) - (this.Height / 2));
        }

        private void frmSupplier_Load(object sender, EventArgs e)
        {
            //set the info displayed based on whether we are adding or modifying
            if (!Add)
            {
                //this is a modify action so set the display the existing supplier info
                this.Text = $"Modify Supplier{SuppIn.SupName}";
                SetToSuppIn();
            }
            else
            {
                //just an add action
                this.Text = "Add new Supplier";
            }
        }

        /// <summary>
        /// Displayes the Existing Supplier Info
        /// </summary>
        private void SetToSuppIn()
        {
            //cannot change supplierid on an edit action
            mtxtSupplierId.Enabled = false;
            // so it doesn't make sense to even give a choice to auto-generate a supplier id
            mchkGenerate.Visible = false;
            //set the existing data
            mtxtSupplierId.Text = SuppIn.SupplierId.ToString();
            mtxtSupplierName.Text = SuppIn.SupName;
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
            if (message.Success)
            {
                //input is valid, so make the new supplier with the input
                SuppOut = new Supplier();
                SuppOut.SupName = mtxtSupplierName.Text;    //supplier name
                SuppOut.SupplierId = Convert.ToInt32(mtxtSupplierId.Text);      //supplier id
                try
                {
                    //if we are adding a supplier add it!
                    if (Add)
                    {
                        if (SuppliersTable.AddSupplier(SuppOut))
                        {
                            //supplier was added successfully
                            AddEditSuccess();
                        }
                        else
                        {
                            //adding the supplier failed, so let the user know this
                            string failMsg = $"Unable to add Supplier: {SuppOut.SupName}.";
                            MaterialMessageBox.Show(this, false, failMsg);
                        }
                    }
                    //we are modifying a supplier, so modify it.
                    else
                    {
                        if (SuppliersTable.UpdateSupplier(SuppOut, SuppIn))
                        {
                            //the supplier was modified successfully
                            AddEditSuccess();
                        }
                        else
                        {
                            //modifying the supplier failed, so let the user know
                            string failMsg = $"Unable to edit Supplier: {SuppOut.SupName}.";
                            MaterialMessageBox.Show(this, true, failMsg);
                        }
                    }
                }
                catch (Exception ex)
                {
                    //there was an error modifying the supplier, let the user know and display the error.
                    string action = (Add) ? "add" : "edit";
                    string failMsg = $"Unable to {action} Supplier: {SuppOut.SupName}, . {Environment.NewLine}{ex.Message}.";
                    MaterialMessageBox.Show(this, false, failMsg);
                }
            }
            else
            {
                //the user input was invalid, so display the validation error message
                MaterialMessageBox.Show(this, message);
            }
        }

        /// <summary>
        /// Successfully added/modified the supplier
        /// </summary>
        private void AddEditSuccess()
        {
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
            Result[] results = new Result[3];
            results[0] = Validator.IsPresent(mtxtSupplierName);
            results[1] = Validator.IsPresent(mtxtSupplierId);
            results[2] = Validator.NonNegInt(mtxtSupplierId);

            //if any of the validation returns false, return that message
            foreach (Result result in results)
            {
                if (!result.Success) return result;
            }
            //valid user input, so return true.
            return new Result(true);
        }

        //Supplier the next available supplier id when checked.
        private void mchkGenerate_CheckedChanged(object sender, EventArgs e)
        {
            //if the auto-generate box is checked
            if ( mchkGenerate.Checked )
            {
                //disable the supplierid fields, because we can no longer manually enter one
                mtxtSupplierId.Enabled = false;
                //set the text of the supplier id equal to the next available Supplier ID
                mtxtSupplierId.Text = GenerateSupplierId().ToString();
            }
            else
            {
                //unchecked the auto-generate so renable the supplier id text box so the user can enter one.
                //no need to clear it.
                mtxtSupplierId.Enabled = true;
            }
        }

        /// <summary>
        /// Returns the Next available Supplier ID
        /// </summary>
        /// <returns>int, Supplier Id</returns>
        private int GenerateSupplierId()
        {
            //gets a list of all suppliers
            List<Supplier> suppliers = SuppliersTable.GetAllSuppliers();
            int newId = 1;
            //loops through the supplies and ids and locates the first available id
            foreach (Supplier supplier in suppliers)
            {
                //if the supplier id does not match the incrementing newid var  then we found an available id
                if (supplier.SupplierId != newId)
                {
                    //we found an available id so return it
                    return newId;
                }
                //increment and try the next supplier against the new id.
                newId++;
            }
            //ran through all supplier and no matches so the next available one will be eqaul to the count of suppliers
            return suppliers.Count;
        }
    }
}
