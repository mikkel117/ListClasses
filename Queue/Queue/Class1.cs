
namespace TCCollections;
public class Queue
{
    object[] queue = new object[10];
    public void Enqueue(object obj)
    {
        queue[Count++] = obj;
    }
    public object Dequeue()
    {
        object p = Peak();
        for (int i = 0; i < Count; i++)
        {
            queue[i] = queue[i + 1];
        }
        Count--;
        return p;
    }


    public object Peak()
    {
        return queue[0];
    }

    public int Count { get; private set; }
}
