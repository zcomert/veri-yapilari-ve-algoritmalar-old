using DataStructures.Queue.Contracts;
using System.Collections;
using System.Runtime.Serialization;

namespace DataStructures.Queue
{
    public class ArrayQueue<T> : IQueue<T>
    {
        private readonly List<T> _innerArray;

        public ArrayQueue()
        {
            _innerArray = new List<T>();
        }

        public ArrayQueue(IEnumerable<T> collection) : this()
        {
            foreach (var item in collection)
            {
                Enqueue(item);
            }
        }

        public int Count => _innerArray.Count;

        public T Dequeue()
        {
            if (Count == 0)
            {
                throw new EmptyQueueException("Queue is empty.");
            }
            // FIFO
            var temp = _innerArray[0];
            _innerArray.RemoveAt(0);
            return temp;
        }

        public void Enqueue(T value)
        {
            _innerArray.Add(value);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return _innerArray.GetEnumerator(); 
        }

        public T Peek()
        {
            return Count == 0 ? default(T) : _innerArray[0];
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}