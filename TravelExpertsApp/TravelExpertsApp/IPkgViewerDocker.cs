using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityLayer;

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
