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
    /// <summary>
    /// Login Form
    /// </summary>
    public partial class frmLogin : MaterialForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Login Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //first validate
            Result message = isValid();
            if (message.Success)    //if valid then...
            {
                //Call the Login Function with Username (Agt First Name) and Password
                //TODO: Encrypt the Password
                if ( AgentTable.Login(txtAgentName.Text, txtAgentPassword.Text) )
                {
                    //Successfully logged in so close this Dialog
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    //Failed, Inform User
                    string invalidMsg = $"Incorrent login for user {txtAgentName.Text}.";
                    MaterialMessageBox.Show(this, false, invalidMsg);
                }
            }
            else
            {
                //Invalid Info Entered
                MaterialMessageBox.Show(this, message);
            }
        }

        //Exit the Applications
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Validation
        /// </summary>
        /// <returns>Result Object</returns>
        private Result isValid()
        {
            Result[] results = new Result[2];
            //Only validate for present, so we don't give any info on username/password structure away, 
            results[0] = Validator.IsPresent(txtAgentName);
            results[1] = Validator.IsPresent(txtAgentPassword);

            //loop through each Validator operation and if any of them return false then return that false result.
            foreach (Result result in results)
            {
                if (!result.Success) return result;
            }
            return new Result(true);
        }
    }
}
