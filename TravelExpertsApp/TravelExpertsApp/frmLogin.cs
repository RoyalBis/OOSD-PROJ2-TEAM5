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
using MaterialSkin;
using TravelExpertsDB;
using Validation;
using MaterialSkin.Controls;

namespace TravelExpertsApp
{
    public partial class frmLogin : MaterialForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Result message = isValid();
            if (message.Success)
            {
                if ( AgentTable.Login1(txtAgentName.Text, txtAgentPassword.Text) )
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    string invalidMsg = $"Incorrent login for user {txtAgentName.Text}.";
                    MaterialMessageBox.Show(this, false, invalidMsg);
                }
            }
            else
            {
                MaterialMessageBox.Show(this, message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private Result isValid()
        {
            Result[] results = new Result[2];
            results[0] = Validator.IsPresent(txtAgentName);
            results[1] = Validator.IsPresent(txtAgentPassword);

            foreach (Result result in results)
            {
                if (!result.Success) return result;
            }
            return new Result(true);
        }
    }
}
