using System.Collections;

namespace TCCollections;
public class List : IEnumerable<object>
{
    object[] list = new object[10];
    public void Add(object obj)
    {
        if (obj != null)
        {
            if (Count != list.Length)
            {
                list[Count++] = obj;
            }
            else
            {
                object[] Temp = new object[list.Length * 10];
                for (int i = 0; i < list.Length; i++)
                {
                    Temp[i] = list[i];
                }
                list = Temp;
                list[Count++] = obj;
            }
        }
    }
    public void Remove(object obj)
    {
        int Index = Find(obj);
        if (Index != -1)
        {
            for (int i = Index; i < Count; i++)
            {
                list[i] = list[i + 1];
            }
            Count--;
        }
    }
    public object? Get(int index)
    {
        return list[index];
    }
    public bool Contains(object obj)
    {
        for (int i = 0; i < Count; i++)
        {
            if (list[i] == obj)
            {
                return true;
            }
        }
        return false;
    }
    public int Find(object obj)
    {
        for (int i = 0; i < Count; i++)
        {
            if (obj == list[i])
            {
                return i;
            }
        }
        return -1;
    }

    public IEnumerator<object> GetEnumerator()
    {
        throw new NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        throw new NotImplementedException();
    }

    public int Count { get; private set; } = 0;

    static void Main(string[] args)
    {
        List array = new List();
        foreach (int i in array)
        {

        }

    }
}
