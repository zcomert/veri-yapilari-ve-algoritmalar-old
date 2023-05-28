using Stack.Contract;

namespace Stack
{
    public class Stack<T> : IStack<T>
    {
        private readonly IStack<T> _stack;
        public Stack()
        {
            _stack = new LinkedListStack<T>();
        }

        public int Count => _stack.Count;

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
    }
}
