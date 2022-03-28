using DataStructures.Queue.Contracts;
using System.Collections;

namespace DataStructures.Queue
{
    public class Queue<T> : IQueue<T>
    {
        private readonly IQueue<T> _queue;

        public Queue(QueueType type = QueueType.LinkedListQueue)
        {
            switch(type)
            {
                case QueueType.LinkedListQueue:
                    _queue = new LinkedListQueue<T>();
                    break;
                case QueueType.ArrayQueue:
                    _queue = new ArrayQueue<T>();
                    break;
                default:
                    throw new Exception("Unsupported Queue type.");
                    break;
            }
        }

        public int Count => _queue.Count;

        public T Dequeue()
        {
            return _queue.Dequeue();
        }

        public void Enqueue(T value)
        {
            _queue.Enqueue(value);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return _queue.GetEnumerator();
        }

        public T Peek()
        {
            return _queue.Peek();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}