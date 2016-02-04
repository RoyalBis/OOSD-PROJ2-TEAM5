using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    /// <summary>
    /// Package Entity Class
    /// </summary>
    public class Package
    {
        //Class properties
        public int PackageId { get; set; }
        public string PkgName { get; set; }
        public DateTime PkgStartDate { get; set; }
        public DateTime PkgEndDate { get; set; }
        public string PkgDesc { get; set; }
        public decimal PkgBasePrice { get; set; }
        public decimal PkgAgencyCommission { get; set; }
        public int ProductSupplierId { get; set; }
        //image is converted to a byte array to be stored in the database
        public byte[] PkgImage { get; set; }
        public List<ProductSupplier> PkgProductSuppliers { get; set; } = new List<ProductSupplier>();

        /// <summary>
        /// Converts an image file into a byte array and stores it in this.PkgImage
        /// </summary>
        /// <param name="path">The path to the package image</param>
        public void StoreImage(string path)
        {
            //Read the file into a byte array
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                byte[] imageData = new Byte[fs.Length];
                fs.Read(imageData, 0, (int)fs.Length);
                PkgImage = imageData;
            }
        }

        /// <summary>
        /// Converts a byte[] array back into an image.
        /// </summary>
        /// <returns>The Package Image</returns>
        public Image ImageFromBytes()
        {
            //if the byte array has a length, we can change it back into a image 
            if(PkgImage?.Length > 0)
            {
	            using (MemoryStream ms = new MemoryStream(this.PkgImage))
	            {
                    //Still need this, because It could fail.
	                Image myBitmap = Image.FromStream(ms);
	                return myBitmap;
	            }
            }
            //else we throw an exception, and catch this.
            throw new ArgumentOutOfRangeException(nameof(this.PkgImage),this.PkgImage,"Unable to create an Image for data stored in the database");
        }
    }
}
