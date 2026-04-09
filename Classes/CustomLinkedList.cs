using System.Collections;

public class CustomLinkedList<T> : IEnumerable<T>
{
    public Node<T>? Head { get; private set; }
    public Node<T>? Tail { get; private set; }
    public int Count { get; private set; }

    public void AddFirst(T value)
    {
        Node<T> newNode = new Node<T>(value);

    }

    public IEnumerator<T> GetEnumerator()
    {
        throw new NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}