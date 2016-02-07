using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using Validation;

/**********************************************************************
Title:                MaterialMessageBox.cs  
 Project:          Travel Experts Desktop App
Authors:         Royal Bissell, Kevin Liao, Annie Ali, Lee Harrold
Class:               OOSD Fall 2015 
Date:               2016/02/07
Description:  A Form Class that implements Message Box like funcionality but looks like a 
                           MaterialSkin Form.
                           Use this class to display all messages to a user in a MaterialSkin UI Project
**********************************************************************/

namespace TravelExpertsApp
{
    /// <summary>
    /// Custom Message Box for Material Skin Appearance 
    /// </summary>
    public partial class MaterialMessageBox : MaterialForm
    {
        //basic constructor
        protected MaterialMessageBox()
        {
            InitializeComponent();
        }

        //constructor that just takes a message and caption
        protected MaterialMessageBox(string message, string caption = "") : this()
        {
            this.Text = caption;
            lblMessage.Text = message;
            //no cancel button
            mbtnCancel.Visible = false;
        }

        //constructor that allows a cancel button
        protected MaterialMessageBox(string message, bool cancelable, string caption = "") : this()
        {
            this.Text = caption;
            lblMessage.Text = message;
            mbtnCancel.Visible = cancelable;
        }

        //OK was clicked
        private void mbtnOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        //Overridden WndProc to make it immovable
        protected override void WndProc(ref Message m)
        {
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MOVE = 0xF010;

            if (m.Msg == WM_SYSCOMMAND)
            {
                if ((m.WParam.ToInt32() & SC_MOVE) == SC_MOVE)
                {
                    m.Msg = 0;
                    m.LParam = IntPtr.Zero;
                    m.WParam = IntPtr.Zero;
                    m.Result = IntPtr.Zero;
                }
            }
            base.WndProc(ref m);
        }

        /// <summary>
        /// Shows a new Message Box from a Result Object
        /// </summary>
        /// <param name="sender">Parent Form</param>
        /// <param name="result">Result Object</param>
        /// <returns></returns>
        public static DialogResult Show(Form sender, Result result)
        {
            //displays a new hide panel
            Panel hidePanel = DisplayHidePanel(sender);

            //construct a new Material Message Box
            MaterialMessageBox mbox = new MaterialMessageBox(result.Message, "Invalid Entry");
            //return the result of the message box
            return DisplayMBox(sender, mbox, hidePanel);
        }

        /// <summary>
        /// Shows a new Message Box with the specified message
        /// </summary>
        /// <param name="sender">Parent Form</param>
        /// <param name="cancelable">true if cancelable</param>
        /// <param name="message">string</param>
        /// <returns></returns>
        public static DialogResult Show(Form sender, bool cancelable,  string message)
        {
            //displays a new hide panel
            Panel hidePanel = DisplayHidePanel(sender);

            //construct a new Material Message Box
            MaterialMessageBox mbox = new MaterialMessageBox(message, cancelable,"Confirm Delete");
            //return the result of the message box
            return DisplayMBox(sender, mbox, hidePanel);
        }

        private void mbtnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            //this.Close();
        }

        /// <summary>
        /// Displays the MessageBox
        /// </summary>
        /// <param name="sender">Parent Form</param>
        /// <param name="mbox">MaterialMessageBox, this</param>
        /// <param name="hidePanel">Panel, HidePanel</param>
        /// <returns>Dialog Result</returns>
        private static DialogResult DisplayMBox(Form sender, MaterialMessageBox mbox, Panel hidePanel)
        {
            mbox.Width = sender.Width;
            mbox.Location = new Point(0, (sender.Height / 2) - (mbox.Height / 2));
            DialogResult mboxResult = mbox.ShowDialog();
            if (mboxResult != DialogResult.None)
            {
                hidePanel.Dispose();
            }
            return mboxResult;
        }

        /// <summary>
        /// Displays a Hide Panel
        /// </summary>
        /// <param name="sender">Parent Form</param>
        /// <returns>Panel, Hide Panel</returns>
        private static Panel DisplayHidePanel(Form sender)
        {
            Panel hidePanel = new Panel();
            hidePanel.Size = sender.Size;
            hidePanel.BackColor = Color.FromArgb(200, 0, 0, 0);
            sender.Controls.Add(hidePanel);
            hidePanel.BringToFront();
            return hidePanel;
        }
    }
}
