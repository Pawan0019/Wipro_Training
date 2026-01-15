using System.Collections.Generic;

public class Linked_List
{
    static void Main()
    {

        LinkedList<int> numbers = new LinkedList<int>();

        numbers.AddLast(10);
        numbers.AddFirst(20);
        numbers.AddLast(6);

        foreach( int n in numbers)
        {
            Console.WriteLine(n);
        }

        numbers.Remove(20);
        numbers.RemoveFirst();
        numbers.RemoveLast();

        bool exists = numbers.Contains(6);

        LinkedListNode<int> node = numbers.First;
        Console.WriteLine(node.Value);
        
    }
}