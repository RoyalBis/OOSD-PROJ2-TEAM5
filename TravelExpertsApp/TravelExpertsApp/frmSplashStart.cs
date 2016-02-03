using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelExpertsApp
{
    public partial class frmSplashStart : Form
    {
        private int tLeft;
        private SoundPlayer hoot = new SoundPlayer("../../Resources/Sound/owl.wav");
        public frmSplashStart()
        {
            InitializeComponent();
        }

        private void frmSplashStart_Load(object sender, EventArgs e)
        {
            //When the application starts, display this page.
            tLeft = 10;
            hoot.Play();
            tmStart.Start();
        }

        private void tmStart_Tick(object sender, EventArgs e)
        {
            //When the timer ends, hide this splash page.
            while (tLeft < 0)
            {
                tLeft -= tLeft;
            }
            tmStart.Stop();
            ////Loading form goes here.
            //new frmLogin();
            hoot.Stop();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
