public class MinStack
{
    private Stack<int> stack;
    private Stack<int> minStack;

    public MinStack()
    {
        stack = new Stack<int>();
        minStack = new Stack<int>();
    }

    public void push(int val)
    {
        stack.Push(val);
        if (minStack.Count == 0 || val <= minStack.Peek())
        {
            minStack.Push(val);
        }
        else
        {
            minStack.Push(minStack.Peek());
        }
    }

    public void pop()
    {
        stack.Pop();
        minStack.Pop();
    }

    public int top()
    {
        return stack.Peek();
    }

    public int getMin()
    {
        return minStack.Peek();
    }
}