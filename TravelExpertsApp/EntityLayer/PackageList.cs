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
        private List<Package> packages;

        public delegate void ChangeHandler(PackageList packages);

        public event ChangeHandler OnChanged;

        public int Count => packages.Count;

        public Package this[int i]
        {
            get
            {
                if ( i < 0 )
                {
                    throw new ArgumentOutOfRangeException(i.ToString());
                }
                else if ( i >= packages.Count )
                {
                    throw new ArgumentOutOfRangeException(i.ToString());
                }
                return packages[i];
            }
            set
            {
                packages[i] = value;
                OnChanged(this);
            }
        }

        public void Add(Package package)
        {
            packages.Add(package);
            OnChanged(this);
        }

        public void Remove(Package product)
        {
            packages.Remove(product);
            OnChanged(this);
        }

        public IEnumerator<Package> GetEnumerator()
        {
            for (int i = 0; i < packages.Count; i++)
            {
                yield return packages[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
