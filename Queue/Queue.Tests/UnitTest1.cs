using Xunit;

namespace Queue.Tests;

public class Queue_Enqueue
{
    [Fact]
    public void EnqueueDifferentTypes()
    {
        TCCollections.Queue queue = new();

        queue.Enqueue("A");
        queue.Enqueue(2);
        queue.Enqueue(3.0f);
        queue.Enqueue(new object());
        Assert.Equal(4, queue.Count);
    }

    [Fact]
    public void EnqueueDequeuePairsShouldEndWithZeroCount()
    {
        TCCollections.Queue queue = new();

        queue.Enqueue("A");
        queue.Dequeue();
        queue.Enqueue("B");
        queue.Dequeue();
        queue.Enqueue("C");
        queue.Dequeue();
        Assert.Equal(0, queue.Count);
    }

    [Fact]
    public void DequeueCorrectElement()
    {
        TCCollections.Queue queue = new();

        queue.Enqueue("A");
        queue.Enqueue("B");
        queue.Enqueue("C");
        queue.Dequeue(); //Next is now B
        queue.Enqueue("D");
        queue.Enqueue("E");
        queue.Enqueue("F");
        queue.Dequeue(); //Next is now C
        Assert.Equal("C", queue.Dequeue());
    }
}