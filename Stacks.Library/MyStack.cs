using System;
using System.Collections.Generic;

namespace Stacks.Library
{
    public class MyStack<T>
    {
        private List<T> _items = new List<T>();

        public MyStack<T> Push(T item)
        {
            _items.Add(item);
            return this;
        }

        public T Pop()
        {
            int index = _items.Count - 1;
            if (index < 0)
            {
                return default(T);
            }

            var item = _items[index];
            _items.RemoveAt(index);
            return item;
        }
    }
}
