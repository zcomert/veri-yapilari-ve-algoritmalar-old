using LinkedList.Singly;


var linkedList = new SinglyLinkedList<char>();
linkedList.AddLast('a');
linkedList.AddLast('b');
linkedList.AddLast('c');
linkedList.AddFirst('x');
linkedList.AddBefore(linkedList.Head.Next, 'y');

// x y a b c
foreach (var item in linkedList)
{
    Console.WriteLine(item);
}

Console.ReadKey();