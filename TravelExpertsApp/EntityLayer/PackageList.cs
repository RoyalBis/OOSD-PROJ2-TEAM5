using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class PackageList : IEnumerable<Package>
    {
        public List<Package> Packages;

        public delegate void ChangeHandler(PackageList packages);

        public event ChangeHandler OnChanged;

        public PackageList()
        {
            Packages = new List<Package>();
        }

        public int Count => Packages.Count;

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

        public void Add(Package package)
        {
            Packages.Add(package);
        }

        public void Remove(Package product)
        {
            Packages.Remove(product);
            OnChanged(this);
        }

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
