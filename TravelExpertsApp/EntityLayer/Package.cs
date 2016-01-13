using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
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
        public int ProductSupplierId { get; set; }
        public byte[] PkgImage;

        /// <summary>
        /// Stores a Package Image as a byte array in this.PkgImage
        /// </summary>
        /// <param name="path">The Path to the package image</param>
        public void StoreImage(string path)
        {
            // Read the file into a byte array
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
            using (MemoryStream ms = new MemoryStream(this.PkgImage))
            {
                return Image.FromStream(ms);
            }
        }
    }
}
