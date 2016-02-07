using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using EntityLayer;
using MaterialSkin;
using TravelExpertsApp.Properties;
using TravelExpertsDB;

/**********************************************************************
Title:                DockPkgViewer.cs  
 Project:          Travel Experts Desktop App
Authors:         Royal Bissell, Kevin Liao, Annie Ali, Lee Harrold
Class:               OOSD Fall 2015 
Date:               2016/02/07
Description:  Dock that handles viewing packages. This Dock needs to be added to a form 
                           that implements the IDockPkgViwer Interface. This interface will allow the dock 
                           to access the neccessary Methods on the Parent Form
**********************************************************************/

namespace TravelExpertsApp
{
    /// <summary>
    /// Docking Control for TravelExperts Winform, Allows Browsing Packages
    /// </summary>
    public partial class DockPkgViewer : UserControl
    {
        //TODO: Make all Docking Panels work like this one
        public Panel MyDockingPanel;    //The panel that hold this dock, must be panDock
        public IPkgViewerDocker MyDocker;   //the Form that holds this Docking Control and inherits form the IPkgViewerDocker Interface
        public Panel SiblingFormPanel;  //the panel that is the sibling of the docking panel (panForm)
        public Package ActivePackage;   //the activePackage, this is updated by the IpkgViewerDocker

        public DockPkgViewer()
        {
            InitializeComponent();
        }

        public DockPkgViewer(Panel dockingPanel) : this()
        {
            //set parent and sibling variables
            MyDockingPanel = dockingPanel;
            MyDocker = (IPkgViewerDocker)MyDockingPanel.FindForm();
            SiblingFormPanel = (Panel)MyDockingPanel.Parent.Controls.Find("panForm", true)[0];
            AddDock();
        }

        //Make sure that when the form loads, we display the active package.
        private void DockPkgViewer_Load(object sender, EventArgs e)
        {
            DisplayActivePkg();
        }

        #region Adding and Removing the Dock
        /// <summary>
        /// adds the dock to the parentform and the panDock Panel
        /// </summary>
        public void AddDock()
        {
            //gets the greater of this height or ParentForm Height
            int newHeight = (this.Height > MyDocker.FormInstance.Height) ? this.Height : MyDocker.FormInstance.Height;
            //sets the Docking Panel wIdth = to this Width
            MyDockingPanel.Width = this.Width;
            //Reduces the Sibling Panel Width by this.Width to make space for it
            SiblingFormPanel.Width = SiblingFormPanel.Width - this.Width;
            //Set the Parent Form large enought to incorporate this.
            //the Sibling Panel should also grow larger if it needs to. (Anchors)
            MyDocker.FormInstance.Size = new Size(MyDocker.FormInstance.Width + this.Width, newHeight);
            //Add the Docking Control to the Parent Form
            MyDockingPanel.Controls.Add(this);
            //And dock it.
            this.Dock = DockStyle.Fill;
            //This makes sure the ParentForm will not flow off to a new screen
            //if it does then fix it
            if ( MyDocker.FormInstance.Width + MyDocker.FormInstance.Left > Screen.PrimaryScreen.Bounds.Width )
            {
                //just push it to the left, to make as much room as possible
                MyDocker.FormInstance.Left = 0;
                //gets an amount of the overflow
                int oversize = MyDocker.FormInstance.Width - Screen.PrimaryScreen.Bounds.Width;
                //then resize this.
                MyDocker.FormInstance.Width -= oversize;
            }
        }

        /// <summary>
        /// Takes care of reszing the parent form when this Control is disposed
        /// </summary>
        public void Dock_Disposing()
        {
            //Remove the form from the parent
            MyDockingPanel.Controls.Remove(this);
            //Set the Parents new Size
            SiblingFormPanel.Size = new Size(SiblingFormPanel.Width + this.Width, SiblingFormPanel.Height);
            MyDockingPanel.Size = new Size(MyDockingPanel.Width - this.Width, MyDockingPanel.Height);
            MyDocker.FormInstance.Size = new Size(MyDocker.FormInstance.Width - this.Width, MyDocker.FormInstance.Height);
            //Finally Dispose of this
            this.Dispose();
        }
#endregion  

        #region Docking Control Closing And Highlighting Events
        private void Dock_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = MaterialSkinManager.Instance.ColorScheme.AccentColor;
        }

        private void Dock_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = MaterialSkinManager.Instance.ColorScheme.PrimaryColor;
        }

        private void Dock_MouseClick(object sender, MouseEventArgs e)
        {
            Dock_Disposing();
        }
        #endregion

        #region Banner Browser Events
        private void pbLeft_Click(object sender, EventArgs e)
        {
            MyDocker.ActivePkgId -= 1;
        }

        private void pbLeft_MouseEnter(object sender, EventArgs e)
        {
            pbLeft.Image = Resources.keyboard_left_lightblue;
        }

        private void pbLeft_MouseLeave(object sender, EventArgs e)
        {
            pbLeft.Image = Resources.keyboard_left_bluegrey;
        }

        private void pbRight_Click(object sender, EventArgs e)
        {
            MyDocker.ActivePkgId += 1;
        }

        private void pbRight_MouseEnter(object sender, EventArgs e)
        {
            pbRight.Image = Resources.keyboard_right_lightblue;
        }

        private void pbRight_MouseLeave(object sender, EventArgs e)
        {
            pbRight.Image = Resources.keyboard_right_bluegrey;
        }
        #endregion

        /// <summary>
        /// Displays the information for the currently active package on the docking control
        /// </summary>
        public void DisplayActivePkg()
        {
            //Just sets the active Package
            ActivePackage = MyDocker.MyPackageList[MyDocker.ActivePkgId];
             //gets the active packages Product Suppliers
            ProductSupplierTable.AssignPkgProductSuppliers(ActivePackage);
            lblPkg.Text = ActivePackage.PkgName;    //PkgName
            txtDescription.Text = ActivePackage.PkgDesc;    //PkgDesc
            mlblStartDate.Text = ActivePackage.PkgStartDate.ToShortDateString();    //PkgStartDate
            mlblEndDate.Text = ActivePackage.PkgEndDate.ToShortDateString();    //PkgEndDate
            mlblBasePrice.Text = ActivePackage.PkgBasePrice.ToString("c");  //PkgBasePrice
            mlblCommission.Text = ActivePackage.PkgAgencyCommission.ToString("c");  //PkgCommission
            //need to catch possible Exceptions when creating the image from the bytes stored in the database
            try
            {
                pbPkgImage.Image = ActivePackage.ImageFromBytes();
            }
            catch ( Exception )
            {
                //dsipaly the no image image.
                pbPkgImage.Image = Resources.X_512_bluegrey;
            }

            //Fill the List view with the Product Suppliers
            mlvProdSuppliers.Items.Clear();
            var ps = ActivePackage.PkgProductSuppliers;
            for (int i = 0; i < ps.Count; i++)
            {
                mlvProdSuppliers.Items.Add(ps[i].ProductSupplierId.ToString());
                mlvProdSuppliers.Items[i].SubItems.Add(ps[i].MyProduct.ProdName);
                mlvProdSuppliers.Items[i].SubItems.Add(ps[i].MySupplier.SupName);
            }
        }

        #region Docking Control Buttons
        /// <summary>
        /// The Button to Modify the Active Package
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mbtnAccept_Click(object sender, EventArgs e)
        {
            if (ActivePackage != null) //check in case there is nothing to delete
            {
               MyDocker.EditPackage();
            }
        }

        private void mbtnCancel_Click(object sender, EventArgs e)
        {
            Dock_Disposing();
        }

        /// <summary>
        /// Button to Delete the Active Package
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mbtnDelete_Click(object sender, EventArgs e)
        {
            //these are the strings I need for the delete Messages////////////////////////////////////////////////////////////////////////////////////////////////
            //confirm Delete Message
            string confirmMsg =
                $"Are you sure you want to permantely delete Package {ActivePackage.PackageId}: {ActivePackage.PkgName}?";
            //delete successful Message
            string successMsg = $"Package {ActivePackage.PackageId}: {ActivePackage.PkgName}  has been deleted successfully.";
            //Delete Failed Message
            string failMsg = $"Package {ActivePackage.PackageId}: {ActivePackage.PkgName} could not be deleted.";
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            if ( ActivePackage != null ) //check in case there is nothing to delete
            {
                //confirmation box
                DialogResult result = MaterialMessageBox.Show(MyDocker.FormInstance, true, confirmMsg);
                if ( result == DialogResult.OK )
                {
                    try //delete
                    {
                        //First Delete the Packages Product Suppliers If they have any.
                        PackagesProductsSuppliersTable.DeletePkgProdSup(ActivePackage.PackageId);
                        // Then Delete the actual Package
                        if (PackagesTable.DeletePackage(ActivePackage) )
                        {
                            //It Worked so Update Everything and confirm with the user
                            MyDocker.FillPackages();
                            MyDocker.ActivePkgId = MyDocker.ActivePkgId;
                            MaterialMessageBox.Show(MyDocker.FormInstance, false, successMsg);
                        }
                        else
                        {
                            //It Didn't Work, so just let the user know
                            MaterialMessageBox.Show(MyDocker.FormInstance, false, failMsg);
                        }
                    }
                    catch ( Exception ex )
                    {
                        //An Error Occured So let the user know and give them the error
                        MaterialMessageBox.Show(MyDocker.FormInstance, false,
                                                failMsg + $"{Environment.NewLine}Error: {ex}.");
                    }
                }
            }
        }
        #endregion
    }
}
