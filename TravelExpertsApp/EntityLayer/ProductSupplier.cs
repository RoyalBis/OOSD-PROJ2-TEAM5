using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class ProductSupplier
    {
        public int ProductSupplierId { get; set; }
        public Product MyProduct { get; set; }
        public Supplier MySupplier { get; set; }
        //public int ProductId { get; set; }
        //public int SupplierId { get; set; }
        //public string SupName { get; set; }
        //public string ProdName { get; set; }
    }
}
