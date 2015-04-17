using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingClassLibrary
{
    class MyCollection<T>
    {
        private T[] _array = new T[100];

        public T this[int key]
        {
            get { return _array[key]; }
            set { _array[key] = value; }
        }
    }
}
