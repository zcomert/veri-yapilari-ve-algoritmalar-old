using DataStructures.LinkedList.SinglyLinkedList;
using DataStructures.Stack.Contracts;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Stack
{
    public class LinkedListStack<T> : IStack<T>
    {
        private readonly SinglyLinkedList<T> _list;
        public LinkedListStack()
        {
            _list = new SinglyLinkedList<T>();
        }
        public LinkedListStack(IEnumerable<T> collection) : this()
        {
            foreach (var item in collection)
                Push(item);
        }

        public int Count => _list.Count;

        public IEnumerator<T> GetEnumerator()
        {
            return _list.GetEnumerator();
        }

        public T Peek()
        {
            return Count == 0 ? default(T) : _list.Head.Value;
        }

        public T Pop()
        {
            if (Count==0)
            {
                throw new Exception("Empty stack!");
            }
            var result = _list.RemoveFirst();
            return result;
        }

        public void Push(T item)
        {
            _list.AddFirst(item);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
