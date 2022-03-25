
using System.Collections;
using System.Collections.Generic;

namespace DataStructures.LinkedList.DoblyLinkedList
{
    internal class DoublyLinkedListEnumerator<T> : IEnumerator<T>
    {
        private DbNode<T> Head;
        private DbNode<T> Curr;

        public DoublyLinkedListEnumerator(DbNode<T> head)
        {
            Head = head;
            Curr = null;
        }

        public T Current => Curr.Value;

        object IEnumerator.Current => Current;


        public void Dispose()
        {
            Head = null;
        }

        public bool MoveNext()
        {
            if (Curr == null)
            {
                Curr = Head;
                return true;
            }
            else
            {
                if (Curr.Next == null)
                {
                    return false;
                }
                else
                {
                    Curr = Curr.Next;
                    return true;
                }
            }
        }

        public void Reset()
        {
            Curr = null;
        }
    }
}