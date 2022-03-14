using System.Collections;

namespace DataStructures.LinkedList.SinglyLinkedList
{
    public class SinglyLinkedListEnumerator<T> : IEnumerator<T>
    {
        private SinglyLinkedListNode<T> Head { get; set;}
        private SinglyLinkedListNode<T> Curr { get; set; }

        public SinglyLinkedListEnumerator(SinglyLinkedListNode<T> head)
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
            if (Head is null)
                return false;

            if (Curr==null)
            {
                Curr = Head;
                return true;
            }

            if (Curr.Next!=null)
            {
                Curr = Curr.Next;
                return true;
            }

            return false;
        }

        public void Reset()
        {
            Curr = null;
            Head = null;
        }
    }
}
