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

/**********************************************************************
Title:                frmSplashScreen.cs  
 Project:          Travel Experts Desktop App
Authors:         Royal Bissell, Kevin Liao, Annie Ali, Lee Harrold
Class:               OOSD Fall 2015 
Date:               2016/02/07
Description:  SplashScreen for the TravelExperts Desktop Application
**********************************************************************/

namespace TravelExpertsApp
{
    public partial class frmSplashStart : Form
    {
        private int tLeft;  //countdown 
        private SoundPlayer hoot = new SoundPlayer("../../Resources/Sound/owl.wav");
        public frmSplashStart()
        {
            InitializeComponent();
        }

        private void frmSplashStart_Load(object sender, EventArgs e)
        {
            //When the application starts, display this page.
            hoot.Play();
            tLeft = 20;
            tmStart.Start();
        }

        private void tmStart_Tick(object sender, EventArgs e)
        {
            //When the timer ends, hide this splash page.
            while (tLeft > 0)
            {
                tLeft -= tLeft;
                return;
            }
            tmStart.Stop();
            //Loading form goes here.
            hoot.Stop();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
