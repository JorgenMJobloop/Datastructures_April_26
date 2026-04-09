namespace Datastrukturer;

class Program
{
    static void Main(string[] args)
    {
        CustomStack<string> myStack = new CustomStack<string>();

        myStack.Push("test4");
        myStack.Push("test3");
        myStack.Push("test2");
        myStack.Push("test1");

        myStack.PrintContents();
        Console.WriteLine(myStack.Count());

        myStack.Pop();
        Console.WriteLine(myStack.Peek());

        Console.WriteLine(myStack.Count());

        myStack.PrintContents();

        LinkedList<int> numbers = new LinkedList<int>();

        numbers.AddLast(10);
        numbers.AddLast(30);
        numbers.AddLast(40);
        numbers.AddLast(50);
        numbers.AddLast(60);
        numbers.AddLast(70);
        numbers.AddLast(80);
        numbers.AddLast(90);
        numbers.AddLast(100);

        LinkedListNode<int>? node = numbers.Find(10); // the first value, this node points to the number "10" that is also on position 0

        if (node is not null)
        {
            numbers.AddAfter(node, 20); // we found the value 10 on our node variable, and can then add the number 20 sequentially after 10 on position 1.
        }

        Console.WriteLine($"Linked list count: {numbers.Count}");

        foreach (int number in numbers)
        {
            Console.WriteLine(number); // 10,20,30,40,50.. correct assumption.
        }


        LinkedList<string> mockDataset = new LinkedList<string>();
        mockDataset.AddLast("John Doe");
        mockDataset.AddLast("Jane Doe");
        mockDataset.AddLast("John Smith");
        mockDataset.AddLast("Jane Smith");
        mockDataset.AddLast("Mr. Anderson");
        mockDataset.AddLast("Paul Atreides");
        mockDataset.AddLast("Baron Harkonnen");
        mockDataset.AddFirst("Kliff Greymane");

        LinkedListNode<string> villain = mockDataset.Find("Baron Harkonnen")!;

        if (villain is not null)
        {
            mockDataset.Remove(villain);
        }

        foreach (var people in mockDataset)
        {
            Console.WriteLine(people);
        }

    }
}