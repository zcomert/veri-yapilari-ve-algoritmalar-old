using DataStructures.Stack.Contracts;
using System.Collections;

namespace DataStructures.Stack
{
    public class Stack<T> : IStack<T>
    {
        private readonly IStack<T> _stack;

        public Stack(StackType type = StackType.LinkedList)
        {
            switch(type)
            {
                case StackType.LinkedList:
                    _stack = new LinkedListStack<T>();
                    break;
                case StackType.Array:
                    _stack = new ArrayStack<T>();
                    break;
                default:
                    throw new Exception("Undefined type!");
            }
        }

        public int Count => _stack.Count;

        public IEnumerator<T> GetEnumerator()
        {
            return _stack.GetEnumerator();
        }

        public T Peek()
        {
            return _stack.Peek();
        }

        public T Pop()
        {
            return _stack.Pop();
        }

        public void Push(T item)
        {
            _stack.Push(item);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}