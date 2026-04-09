public class StackTests
{
    [Fact]
    public void Push_ShouldIncreaseCount()
    {
        CustomStack<int> stack = new CustomStack<int>();
        stack.Push(10);

        Assert.Equal(1, stack.Count());
    }

    [Fact]
    public void Pop_ShouldReturnLastPushedItem()
    {
        CustomStack<int> stack = new CustomStack<int>();

        stack.Push(1);
        stack.Push(2);
        stack.Push(3);

        int result = stack.Pop();
        Assert.Equal(3, result);
        Assert.Equal(2, stack.Count());
    }

    [Fact]
    public void Peek_ShouldReturnTopItemWithoutRemovingIt()
    {
        CustomStack<string> stack = new CustomStack<string>();
        stack.Push("Item1");
        stack.Push("Item2");

        string expectedResult = stack.Peek();

        Assert.Equal("Item2", expectedResult);
        Assert.Equal(2, stack.Count());
    }

    [Fact]
    public void Pop_OnAnEmptyStack_ShouldThrowInvalidOperationException()
    {
        CustomStack<int> emptyStack = new CustomStack<int>();

        Assert.Throws<InvalidOperationException>(() => emptyStack.Pop());
    }

    [Fact]
    public void Peek_OnAnEmptyStack_ShouldThrowInvalidOperationException()
    {
        CustomStack<int> emptyStack = new CustomStack<int>();

        Assert.Throws<InvalidOperationException>(() => emptyStack.Peek());
    }
}