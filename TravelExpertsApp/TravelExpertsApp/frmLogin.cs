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

namespace TravelExpertsApp
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(isValide())
            {
                AgentTable.Login( txtAgentName.ToString(), txtAgentPassword.ToString());
                frmPackage fm = new frmPackage();
                fm.Show();
            }
        }

        private bool isValide()
        {

            return Validator.IsPresent(txtAgentName)&&  Validator.IsPresent(txtAgentPassword); ;
        }
    }
}
