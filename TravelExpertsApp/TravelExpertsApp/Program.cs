using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelExpertsApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new frmLogin());
            //Application.Run(new frmPkgAddModify());
            //Application.Run(new frmSearch());
            //Application.Run(new frmProductSupplier());
            //Application.Run(new frmPackage());
            Application.Run(new frmMain());
        }
    }
}
