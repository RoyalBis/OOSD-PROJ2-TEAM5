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
        DockPkgViewer MyPkgViewer { get; set; }
        PackageList MyPackageList { get; set; }
        int ActivePkgId { get; set; }
        Panel PanDock { get; }
        Panel PanForm { get; }

        /// <summary>
        /// Just return "this"
        /// </summary>
        Form FormInstance { get; }

        /// <summary>
        /// Get all Packages
        /// </summary>
        void FillPackages();
    }
}
