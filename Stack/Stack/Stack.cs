namespace TCCollections;
public class Stack
{
    object[] list = new object[10];
    int top = -1;
    public void Push(object obj)
    {
        if (obj != null)
        {
            top++;
            list[top] = obj;
            Count++;
        }
    }
    public object Pop()
    {
        Count--;
        return list[top--];
    }
    public object Top()
    {
        return list[top];
    }
    public bool Contains(object obj)
    {
        for (int i = 0; i < top; i++)
        {
            if (list[i] == obj)
            {
                return true;
            }
        }
        return false;
    }
    public int Count { get; private set; } = 0;

}
