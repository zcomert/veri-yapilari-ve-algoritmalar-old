var node1 = new SinglyLinkedListNode<char>('a');
var node2 = new SinglyLinkedListNode<char>('b');
var node3 = new SinglyLinkedListNode<char>('c');
var node4 = new SinglyLinkedListNode<char>('d');

node1.Next = node2;
node2.Next = node3;
node3.Next = node4;

AddFirst<char>('z', ref node1);
AddLast<char>('x', node1);

Traverse<char>(node1);

Console.ReadKey();

static void Traverse<T>(SinglyLinkedListNode<T> Head)
{
    if(Head is null)
        throw new ArgumentNullException(nameof(Head));
    
    var Current = Head;
    while (Current != null)
    {
        Console.WriteLine(Current);
        Current = Current.Next;
    }
}
static void AddFirst<T>(T value, ref SinglyLinkedListNode<T> Head) // O(1)
{
    if (Head is null)
        throw new ArgumentNullException();
    
    var newNode = new SinglyLinkedListNode<T>(value);
    newNode.Next = Head;
    Head = newNode;
}
static void AddLast<T>(T value, SinglyLinkedListNode<T> Head) // O(n)
{
    var newNode = new SinglyLinkedListNode<T>(value);
    var current = Head;
    while (current.Next!=null)
    {
        current = current.Next;
    }
    current.Next = newNode;
    return;
}
public class SinglyLinkedListNode<T>
{
    public T Value { get; set; }
    public SinglyLinkedListNode<T> Next { get; set; }
    public SinglyLinkedListNode(T value)
    {
        Value = value;
    }

    public override string ToString() => $"{Value}";
    
}



