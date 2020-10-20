using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Iterator_pract
{
    interface I_IterableCollection<T>
    {
        Iterator<T> CreateIterator();
        int Count { get; }
        T this[int index] { get; set; }
    }

    class IterableCollection<T> : I_IterableCollection<T>
    {
        List<T> list = new List<T>();

        public T this[int index] 
        { 
            get => list[index];
            set => list.Insert(index, value);
        }

        public int Count => list.Count;

        public Iterator<T> CreateIterator()
        {
            return new Iterator<T>(this);
        }
    }
}
