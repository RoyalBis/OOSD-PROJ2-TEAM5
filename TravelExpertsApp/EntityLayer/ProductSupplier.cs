using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    /// <summary>
    /// Entity Class of Product Suppliers
    /// </summary>
    public class ProductSupplier
    {
        public int ProductSupplierId { get; set; }
        public Product MyProduct { get; set; }  //hold a Product Object here
        public Supplier MySupplier { get; set; } //hold a Supplier Object here
        //public int ProductId { get; set; }
        //public int SupplierId { get; set; }
        //public string SupName { get; set; }
        //public string ProdName { get; set; }
    }
}
