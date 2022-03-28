using DataStructures.LinkedList.DoblyLinkedList;
using DataStructures.Queue.Contracts;
using System.Collections;

namespace DataStructures.Queue
{
    public class LinkedListQueue<T> : IQueue<T>
    {
        private readonly DoublyLinkedList<T> _linkedList;
        public LinkedListQueue()
        {
            _linkedList = new DoublyLinkedList<T>();
        }

        public LinkedListQueue(IEnumerable<T> collection) : this()
        {
            foreach (T item in collection)
            {
                Enqueue(item);
            }
        }

        public int Count => _linkedList.Count;

        public T Dequeue()
        {
            if (Count == 0)
            {
                throw new EmptyQueueException();
            }
            var temp = _linkedList.RemoveFirst();
            return temp;
        }

        public void Enqueue(T value)
        {
            _linkedList.AddLast(value);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return _linkedList.GetEnumerator();
        }

        public T Peek()
        {
            return Count==0 ? default(T) : _linkedList.Head.Value;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}