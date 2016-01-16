using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    /// <summary>
    /// The Supplier of a Travel Product
    /// </summary>
    public class Supplier
    {
        public Supplier()
        {
        }

        //Class Fields.
        //private int supplierId;
        //private string supName;

        //Class properties.
        public int SupplierId { get; set; }

        public string SupName { get; set; }
    }
}
