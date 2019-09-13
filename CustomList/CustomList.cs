using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T>
    {
        private T[] arr = new T[4];
        int nextIndex = 0;
        int count;
        public T this[int i] => arr[i];
        public void Add(T value)
        {

        }

        public int Count
        {
            get { return count; }
        }

        private T[] item;
        public CustomList()
        {
            item = new T[4];
        }
    }
}
