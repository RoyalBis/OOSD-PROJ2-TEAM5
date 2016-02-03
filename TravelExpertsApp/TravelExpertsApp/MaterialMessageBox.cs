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

namespace TravelExpertsApp
{
    public partial class MaterialMessageBox : MaterialForm
    {
        protected MaterialMessageBox()
        {
            InitializeComponent();
        }

        protected MaterialMessageBox(string message, string caption = "") : this()
        {
            Form parent = this.ParentForm;
            Form owner = this.Owner;
            this.Text = caption;
            lblMessage.Text = message;
            mbtnCancel.Visible = false;
        }

        protected MaterialMessageBox(string message, bool cancelable, string caption = "") : this()
        {
            Form parent = this.ParentForm;
            Form owner = this.Owner;
            this.Text = caption;
            lblMessage.Text = message;
            mbtnCancel.Visible = cancelable;
        }

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

        public static DialogResult Show(Form sender, Result result)
        {
            Panel hidePanel = new Panel();
            hidePanel.Size = sender.Size;
            hidePanel.BackColor = Color.FromArgb(200, 0, 0, 0);
            sender.Controls.Add(hidePanel);
            hidePanel.BringToFront();

            MaterialMessageBox mbox = new MaterialMessageBox(result.Message, "Invalid Entry");
            mbox.Width = sender.Width;
            mbox.Location = new Point(0, (sender.Height / 2) - (mbox.Height / 2));
            DialogResult mboxResult = mbox.ShowDialog();
            if (mboxResult != DialogResult.None)
            {
                hidePanel.Dispose();
            }
            return mboxResult;
        }

        public static DialogResult Show(Form sender, bool cancelable,  string message)
        {
            Panel hidePanel = new Panel();
            hidePanel.Size = sender.Size;
            hidePanel.BackColor = Color.FromArgb(200, 0, 0, 0);
            sender.Controls.Add(hidePanel);
            hidePanel.BringToFront();

            MaterialMessageBox mbox = new MaterialMessageBox(message, cancelable,"Confirm Delete");
            mbox.Width = sender.Width;
            mbox.Location = new Point(0, (sender.Height / 2) - (mbox.Height / 2));
            DialogResult mboxResult = mbox.ShowDialog();
            if (mboxResult != DialogResult.None)
            {
                hidePanel.Dispose();
            }
            return mboxResult;
        }

        private void mbtnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            //this.Close();
        }
    }
}
