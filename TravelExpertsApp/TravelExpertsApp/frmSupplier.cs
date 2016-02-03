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
        public bool Add;
        public Supplier SuppIn;
        public Supplier SuppOut;

        public frmSupplier(Form senderForm)
        {
            InitializeComponent();
            this.Width = senderForm.Width;
            this.Location = new Point(senderForm.Left, senderForm.Top + (senderForm.Height / 2) - (this.Height / 2));
        }

        private void frmSupplier_Load(object sender, EventArgs e)
        {
            if (!Add)
            {
                this.Text = $"Modify Supplier{SuppIn.SupName}";
                SetToSuppIn();
            }
            else
            {
                this.Text = "Add new Supplier";
            }
        }

        private void SetToSuppIn()
        {
            mtxtSupplierId.Enabled = false;
            mchkGenerate.Visible = false;
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
            Result message = isValid();
            if (message.Success)
            {
                SuppOut = new Supplier();
                SuppOut.SupName = mtxtSupplierName.Text;
                SuppOut.SupplierId = Convert.ToInt32(mtxtSupplierId.Text);
                try
                {
                    if (Add)
                    {
                        if (SuppliersTable.AddSupplier(SuppOut))
                        {
                            AddEditSuccess();
                        }
                        else
                        {
                            string failMsg = $"Unable to add Supplier: {SuppOut.SupName}.";
                            MaterialMessageBox.Show(this, false, failMsg);
                        }
                    }
                    else
                    {
                        if (SuppliersTable.UpdateSupplier(SuppOut, SuppIn))
                        {
                            AddEditSuccess();
                        }
                        else
                        {
                            string failMsg = $"Unable to edit Supplier: {SuppOut.SupName}.";
                            MaterialMessageBox.Show(this, true, failMsg);
                        }
                    }
                }
                catch (Exception ex)
                {
                    string action = (Add) ? "add" : "edit";
                    string failMsg = $"Unable to {action} Supplier: {SuppOut.SupName}, . {Environment.NewLine}{ex.Message}.";
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
            Result[] results = new Result[3];
            results[0] = Validator.IsPresent(mtxtSupplierName);
            //validate Supplier  just in case
            results[1] = Validator.IsPresent(mtxtSupplierId);
            results[2] = Validator.NonNegInt(mtxtSupplierId);

            foreach (Result result in results)
            {
                if (!result.Success) return result;
            }
            return new Result(true);
        }

        private void mchkGenerate_CheckedChanged(object sender, EventArgs e)
        {
            if ( mchkGenerate.Checked )
            {
                mtxtSupplierId.Enabled = false;
                mtxtSupplierId.Text = GenerateSupplierId().ToString();
            }
            else
            {
                mtxtSupplierId.Enabled = true;
            }
        }

        private int GenerateSupplierId()
        {
            List<Supplier> suppliers = SuppliersTable.GetAllSuppliers();
            int newId = 1;
            foreach (Supplier supplier in suppliers)
            {
                if (supplier.SupplierId != newId)
                {
                    return newId;
                }
                newId++;
            }
            return suppliers.Count;
        }
    }
}
