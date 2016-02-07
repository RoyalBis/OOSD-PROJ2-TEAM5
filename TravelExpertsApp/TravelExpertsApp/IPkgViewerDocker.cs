using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityLayer;

/**********************************************************************
Title:                IPkgViewerDocker.cs  
 Project:          Travel Experts Desktop App
Authors:         Royal Bissell, Kevin Liao, Annie Ali, Lee Harrold
Class:               OOSD Fall 2015 
Date:               2016/02/07
Description:  Interface for any form to implement that allows it to dock a PkgViewerDock
                           Allows the maintaince of the Active Package to be centrally controlled
**********************************************************************/

namespace TravelExpertsApp
{
    /// <summary>
    /// Interface for any Form that can Dock a PackageViewerDock
    /// </summary>
    public interface IPkgViewerDocker
    {
        //the docking user control from the form
        DockPkgViewer MyPkgViewer { get; set; }
        PackageList MyPackageList { get; set; }
        //variable that allows setting the active package
        int ActivePkgId { get; set; }
        //the panel that holds the docking control
        Panel PanDock { get; }
        //this sibling panel of the dock
        Panel PanForm { get; }

        /// <summary>
        /// Just return "this"
        /// </summary>
        Form FormInstance { get; }

        /// <summary>
        /// Get all Packages
        /// </summary>
        void FillPackages();
        /// <summary>
        /// Edit the Active Package
        /// </summary>
        void EditPackage();
    }
}
