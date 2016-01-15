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
using MaterialSkin.Controls;

namespace TravelExpertsApp
{
    public partial class frmLogin : MaterialForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private bool isValide()
        {
            return Validator.IsPresent(txtAgentName)&&  Validator.IsPresent(txtAgentPassword); ;
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            if (isValide())
            {
                AgentTable.Login(txtAgentName.ToString(), txtAgentPassword.ToString());
                frmPackage fm = new frmPackage();
                fm.Show();
                this.Hide();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
