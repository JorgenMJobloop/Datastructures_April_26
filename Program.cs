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
    }
}