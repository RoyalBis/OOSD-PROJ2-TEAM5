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
    public partial class frmProduct : MaterialForm
    {
        public bool Add;
        public Product ProdIn;
        public Product ProdOut;

        public frmProduct(Form senderForm)
        {
            InitializeComponent();
            this.Width = senderForm.Width;
            this.Location = new Point(senderForm.Left, senderForm.Top + (senderForm.Height / 2) - (this.Height / 2));
        }

        private void frmProduct_Load(object sender, EventArgs e)
        {
            if (!Add)
            {
                this.Text = $"Modify Product {ProdIn.ProdName}";
                SetToProdIn();
            }
            else
            {
                this.Text = "Add new Product";
            }
        }

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
            Result message = isValid();
            if (message.Success )
            {
                ProdOut = new Product();
                ProdOut.ProdName = mtxtProductName.Text;
                try
                {
                    if (Add)
                    {
                        if (ProductsTable.AddProduct(ProdOut))
                        {
                            AddEditSuccess();
                        }
                        else
                        {
                            string failMsg = $"Unable to add Product: {ProdOut.ProdName}.";
                            MaterialMessageBox.Show(this, false, failMsg);
                        }
                    }
                    else
                    {
                        if (ProductsTable.UpdateProduct(ProdOut, ProdIn))
                        {
                            AddEditSuccess();
                        }
                        else
                        {
                            string failMsg = $"Unable to edit Product: {ProdOut.ProdName}.";
                            MaterialMessageBox.Show(this, true, failMsg);
                        }
                    }
                }
                catch (Exception ex)
                {
                    string action = (Add) ? "add" : "edit";
                    string failMsg = $"Unable to {action} Product: {ProdOut.ProdName}, . {Environment.NewLine}{ex.Message}.";
                    MaterialMessageBox.Show(this, false, failMsg);
                }
            }
            else
            {
                MaterialMessageBox.Show(this, message);
            }
        }

        private void AddEditSuccess()
        {
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private Result isValid()
        {
            Result[] results = new Result[1];
            results[0] = Validator.IsPresent(mtxtProductName);

            foreach (Result result in results)
            {
                if (!result.Success) return result;
            }
            return new Result(true);
        }
    }
}
