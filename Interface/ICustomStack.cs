public interface ICustomStack<T>
{
    /// <summary>
    /// "Push/Adds" an item onto the stack
    /// </summary>
    /// <param name="item">item</param>
    void Push(T item);
    /// <summary>
    /// remove an item from the stacks last index [-1]
    /// </summary>
    /// <returns>T</returns>
    T Pop();
    /// <summary>
    /// get the first item in the stack
    /// </summary>
    /// <returns>T</returns>
    T Peek();
    /// <summary>
    /// Get the number of items in our stack
    /// </summary>
    /// <returns>int</returns>
    int Count();
}