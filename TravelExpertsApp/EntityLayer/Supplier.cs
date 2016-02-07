using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

/**********************************************************************
Title:                Supplier.cs  
 Project:          Travel Experts Desktop App
Authors:         Royal Bissell, Kevin Liao, Annie Ali, Lee Harrold
Class:               OOSD Fall 2015 
Date:               2016/02/07
Description:  Entity Class for Suppliers.  
**********************************************************************/

namespace EntityLayer
{
    /// <summary>
    /// Entity Supplier Class
    /// </summary>
    public class Supplier
    {
        //Class Fields.
        //private int supplierId;
        //private string supName;

        //Class properties.
        public int SupplierId { get; set; }
        public string SupName { get; set; }
    }
}
