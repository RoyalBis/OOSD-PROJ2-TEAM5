using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team5_OOSD_Fall2015_Project2
{
    class Package
    {
        //Class attributes.
        //private int packageId;
        //private string pkgName;
        //private datetime pkgStartDate;
        //private datetime pkgEndDate;
        //private string pkgDesc;
        //private decimal pkgBasePrice;
        //private decimal pkgAgencyCommission;

        //Class properties.
        public int PackageId { get; set; }
        public string PkgName { get; set; }
        public DateTime PkgStartDate { get; set; }
        public DateTime PkgEndDate { get; set; }
        public string PkgDesc { get; set; }
        public decimal PkgBasePrice { get; set; }
        public decimal PkgAgencyCommission { get; set; }
    }
}
