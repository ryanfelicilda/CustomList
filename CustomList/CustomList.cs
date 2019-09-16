using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T>
    {
        private T[] array;
        int count;
        int capacity;
        public T this[int i]
        {
            get { return array[i]; }
            set { array[i] = value; }
        }
        public CustomList()
        {
            count = 0;
            capacity = 4;
            array = new T[capacity];
        }
        public void DoubleCapacity()
        {
            capacity = capacity * 2;
        }
        public void Add(T value)
        {
            if(VerifyCapacity())
            {
                DoubleArray();
            }
            array[count] = value;
            count++;
        }
        public void DoubleArray()
        {
            T[] value = new T[capacity];
            for(int i = 0; i < count; i++)
            {
                value[i] = array[i];
            }
            array = value;
        }
        public bool VerifyCapacity()
        {
            if(count >= capacity)
            {
                DoubleCapacity();
                return true;
            }
            else
            {
                return false;
            }
        }
        public int Count
        {
            get { return count; }
        }
        public void Remove(T value)
        {
            // { 1, 7, 2, 3, 2, 5, 0, 0, 0 }
            // find the index of the first match to the value user is trying to remove
            int indexToStartAt = 0;
            for (int i = 0; i < count; i++)
            {
                if (array[i].Equals(value))
                {
                    indexToStartAt = i;
                }
            }

            for (int i = indexToStartAt; i < count; i++)
            {
                array[i] = array[i + 1];
            }



            // { 1, 7, 2, 3, 2, 5, 0, 0, 0 } count 6 array size 9
            // { 7, 2, 3, 2, 5, 5, 0, 0, 0 } count 5

            // { 1, 7, 2, 3, 2, 5, 0, 0, 0 } count 6 array size 9
            // { 1, 7, 3, 2, 5, 5,, 0, 0 } count 5



            // shift values in your array (think overwrite) the value you are getting rid of
            //ShiftArray();



            count--;
        }
        //public void ShiftArray()
        //{
        //    for (int i = 0; i < count; i++)
        //    {
        //        array[i] = array[i + 1];
        //    }
        //}
    }
}
