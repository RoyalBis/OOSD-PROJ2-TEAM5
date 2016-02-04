using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    /// <summary>
    /// Package Wrapper Class, Holds packages
    /// </summary>
    public class PackageList : IEnumerable<Package>
    {
        //the list of packages
        public List<Package> Packages;
        //change handlers to monitor changes to the list of packages
        public delegate void ChangeHandler(PackageList packages);
        //the onchanged event for the package list
        public event ChangeHandler OnChanged;
        //this.Count will return a count of the List of Packages
        public int Count => Packages.Count;

        //when we make a new package list, make a new Lust of Package
        public PackageList()
        {
            Packages = new List<Package>();
        }

        /// <summary>
        /// get and set the the package at index 'i' of the list of packages
        /// </summary>
        /// <param name="i">this index to get/set</param>
        /// <returns>Package at index 'i'</returns>
        public Package this[int i]
        {
            get
            {
                if ( i < 0 )
                {
                    throw new ArgumentOutOfRangeException(i.ToString());
                }
                else if ( i >= Packages.Count )
                {
                    throw new ArgumentOutOfRangeException(i.ToString());
                }
                return Packages[i];
            }
            set
            {
                Packages[i] = value;
                OnChanged(this);
            }
        }

        /// <summary>
        /// Add a new Package to the list of packages
        /// </summary>
        /// <param name="package">A Package Object</param>
        public void Add(Package package)
        {
            Packages.Add(package);
        }

        /// <summary>
        /// Remove a Package from the list of packages
        /// </summary>
        /// <param name="product">A Package Object</param>
        public void Remove(Package product)
        {
            Packages.Remove(product);
            OnChanged(this);
        }

        /// <summary>
        /// Allows enumerating through the list of pacakges
        /// </summary>
        /// <returns>IEnumerator of Package</returns>
        public IEnumerator<Package> GetEnumerator()
        {
            for (int i = 0; i < Packages.Count; i++)
            {
                yield return Packages[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
