﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    //Author: Lee Harold
    public class Supplier
    {
        private int supplierId;

        public Supplier()
        {
        }

        //Class Fields.
        //private int supplierId;
        //private string supName;

        //Class properties.
        public int SupplierId
        {
            get { return supplierId; }
            set { supplierId = value; }
        }

        public string SupName { get; set; }
    }
}
