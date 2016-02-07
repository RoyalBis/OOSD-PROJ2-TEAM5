using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

// <Code Comment>
// Author: Anne Ali
// Date: Jan 28, 2016
// Class: OOSD Oct 2015
// Description: Entity class for package table
// </Comment>

public class Package
{
    //Constructor
    public Package() { }

    //Class properties
    public int PackageId { get; set; }

    public string PkgName { get; set; }

    public DateTime PkgStartDate { get; set; }

    public DateTime PkgEndDate { get; set; }

    public string PkgDesc { get; set; }

    public decimal PkgBasePrice { get; set; }

    public decimal PkgAgencyCommission { get; set; }

    public byte[] PkgImage { get; set; }
}