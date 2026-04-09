using System.Collections;

public class CustomList<T> : IEnumerable<T>
{
    /// <summary>
    /// The default capacity(size) of our List
    /// </summary>
    private const int DefaultCapacity = 5;
    /// <summary>
    /// Items held in our list
    /// </summary>
    private T[] _items;

    /// <summary>
    /// Primary constructor, creates a new array T with the size of our default capacity
    /// </summary>
    public CustomList()
    {
        _items = new T[DefaultCapacity];
    }

    public int Count { get; private set; }

    public T this[int index]
    {
        get
        {
            ValidateIndex(index);
            return _items[index];
        }
        set
        {
            ValidateIndex(index);
            _items[index] = value;
        }
    }

    public IEnumerator<T> GetEnumerator()
    {
        throw new NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    // Helper methods

    private void EnsureCapacityIsExpandingDynamically(int minCapacity)
    {
        if (_items.Length >= minCapacity)
        {
            return;
        }

        int newCapacity = _items.Length == 0 ? DefaultCapacity : _items.Length * 2;

        while (newCapacity < minCapacity)
        {
            newCapacity *= 2;
        }

        T[] newArray = new T[newCapacity];

        for (int i = 0; i < Count; i++)
        {
            newArray[i] = _items[i];
        }

        _items = newArray;
    }

    /// <summary>
    /// Validate the index of the list
    /// </summary>
    /// <param name="index">valid index in the list</param>
    private void ValidateIndex(int index)
    {
        if (index < 0 || index >= Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }
    }

    /// <summary>
    /// Validate the index of the insert in the list
    /// </summary>
    /// <param name="index">index of the inserted item</param>
    private void ValidateInsertIndex(int index)
    {
        if (index < 0 || index > Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }
    }
}