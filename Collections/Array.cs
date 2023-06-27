using System.Collections;
using System.Security.Cryptography;

namespace Collections
{
    public class Array<T> : IEnumerable<T>
    {
        private T[] _array;
        private int _length;
        
        public int Length
        {
            get => _length;
            private set { _length = value; }
        }

        public T this[int index]
        {
            get => _array[index];
            set => _array[index] = value;
        }

        public Array()
        {
            _length = 0;
            _array = new T[_length];
        }

        public void Add(T value)
        {
            _length++;
            T[] tmp = new T[_length];
            for (int i = 0; i < _array.Length; i++)
            {
                tmp[i] = _array[i];
            }

            tmp[_length - 1] = value;
            _array = tmp;
        }
        
        public T Pop()
        {          
            _length--;
            T result = _array[_length];
            T[] tmp = new T[_length];
            for (int i = 0; i < _length; i++)
            {
                tmp[i] = _array[i];
            }

            _array = tmp;
            return result;
        }
        public bool Contains(T value)
        {
            foreach (T item in _array)
            {
                if (item.Equals(value)) return true;
            }
            return false;
        }
        public int IndexOf(T value)
        {
            for (int i = 0; i < Length; i++)
            {
                if (_array[i].Equals(value)) return i;               
            }
            return -1;
        }
        public bool RemoveAt(int index)
        {
            if (index >= _length || index < 0) return false;
            _length--;
            T[] tmp = new T[_length];
            for (int i = 0; i < index; i++)
            {
                tmp[i] = _array[i];
            }

            for (int i = index + 1; i < _array.Length; i++)
            {
                tmp[i - 1] = _array[i];
            }
            _array = tmp;
            return true;
        }
        public bool Remove(T value) => RemoveAt(IndexOf(value));
        public void Clear()
        {
            _length = 0;
            _array = new T[_length];
        }
        public bool Insert(int index, T value)
        {
            if (index >= _length || index < 0) return false;
            _length++;
            T[] tmp = new T[_length];
            for (int i = 0; i < index; i++)
            {
                tmp[i] = _array[i];
            }

            tmp[index] = value;

            for (int i = index; i < _length - 1; i++)
            {
                tmp[i + 1] = _array[i];
            }

            _array = tmp;
            return true;
        }
        public IEnumerable<T> Distinct()
        {
            //MyArray<T> result = new();
            var result = new Array<T>();
            for (int i = 0; i < _length; i++)
            {
                if (!result.Contains(_array[i]))
                    result.Add(_array[i]);
            }
            return result;
        }
        public IEnumerator<T> GetEnumerator()
        {
            return ((IEnumerable<T>)_array).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _array.GetEnumerator();
        }
    }

}