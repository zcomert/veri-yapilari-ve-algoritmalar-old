using System.Collections;

namespace DataStructures.Trees.BinaryTree;

public class BinaryTreeEnumerator<T> : IEnumerator<T>
{
    private readonly Queue<Node<T>> _queue;
    private Node<T>? _currentNode;

    public BinaryTreeEnumerator(Node<T> root)
    {
        _queue = new Queue<Node<T>>();
        _currentNode = null;
        EnqueueNode(root);
    }

    public T Current => _currentNode.Value;

    object IEnumerator.Current => Current;

    public bool MoveNext()
    {
        if (_queue.Count == 0)
        {
            _currentNode = null;
            return false;
        }

        _currentNode = _queue.Dequeue();
        EnqueueNode(_currentNode.Left);
        EnqueueNode(_currentNode.Right);
        return true;
    }

    public void Reset()
    {
        _queue.Clear();
        _currentNode = null;
        EnqueueNode(_currentNode);
    }

    public void Dispose()
    {
        _queue.Clear();
        _currentNode = null;
    }

    private void EnqueueNode(Node<T>? node)
    {
        if (node != null)
        {
            _queue.Enqueue(node);
        }
    }
}