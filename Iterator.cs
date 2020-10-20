using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator_pract
{
    interface I_Iterator<T>
    {
        T First();
        T Next();
        bool IsDone();
        T CurrentItem();
    }

    class Iterator<T> : I_Iterator<T>
    {
        private readonly IterableCollection<T> iterable;

        private int _currentElemIndex;
        
        public Iterator(IterableCollection<T> iterable)
        {
            this.iterable = iterable;
        }

        public T CurrentItem()
        {
            return iterable[_currentElemIndex];
        }

        public T First()
        {
            return iterable[0];
        }

        public bool IsDone()
        {
            return _currentElemIndex >= iterable.Count;
        }

        public T Next()
        {
            T obj = default(T);

            _currentElemIndex++;

            if (_currentElemIndex < iterable.Count)
                obj = iterable[_currentElemIndex];

            return obj;
        }
    }
}
