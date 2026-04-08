public class CustomStack<T> : ICustomStack<T>
{
    private T[] _items;
    private int _top;

    public CustomStack(int capacity = 10)
    {
        _items = new T[capacity];
        _top = -1;
    }

    public int Count()
    {
        return _top + 1;
    }

    public T Peek()
    {
        if (_top < 0)
        {
            throw new InvalidOperationException("The stack is currently empty.");
        }

        return _items[_top];
    }

    public T Pop()
    {
        if (_top < 0)
        {
            throw new InvalidOperationException("The stack is currently empty.");
        }

        return _items[_top--];
    }

    public void Push(T item)
    {
        if (_top == _items.Length - 1)
        {
            throw new InvalidOperationException("The stack is full.");
        }
        _items[++_top] = item;
    }

    public void PrintContents()
    {
        for (int i = 0; i <= _top; i++)
        {
            Console.WriteLine(_items[i]);
        }
    }
}