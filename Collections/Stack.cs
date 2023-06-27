using System.Collections;

namespace Collections
{
    public class Stack <T> : IEnumerable<T> 
    {
        #region PrivateFields
        private Array<T> _stack;
        private T _head;
        #endregion
        public Stack()
        {
            _stack = new Array<T>();
        }
        #region Functions
        public void Push(T value)
        {
           _stack.Add(value);
           _head = value;
        }
        public T Pop() => _stack.Pop();
        public T Peek()=> _head;
        public int Count() => _stack.Length;
        public bool IsEmpty => _stack.Length == 0;        
        public bool Contains(T value)
        {
            foreach (T item in _stack)
            {
                if (item.Equals(value)) return true;
            }
            return false;
        }
        public void Clear()
        {
            _stack = new Array<T>();
        }
        #endregion 
        #region ImplementIEnumerable
        public IEnumerator<T> GetEnumerator()
        {
            return ((IEnumerable<T>)_stack).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _stack.GetEnumerator();
        }
        #endregion
    }
}
