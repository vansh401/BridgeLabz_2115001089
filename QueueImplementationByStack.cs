using System;
using System.Collections.Generic;

class QueueUsingStacks<T>
{
    private Stack<T> stack1 = new Stack<T>();
    private Stack<T> stack2 = new Stack<T>();

    public void Enqueue(T item)
    {
        stack1.Push(item);
    }

    public T Dequeue()
    {
        if (stack2.Count == 0)
        {
            while (stack1.Count > 0)
            {
                stack2.Push(stack1.Pop());
            }
        }

        if (stack2.Count == 0)
        {
            throw new InvalidOperationException("Queue is empty.");
        }

        return stack2.Pop();
    }

    public T Peek()
    {
        if (stack2.Count == 0)
        {
            while (stack1.Count > 0)
            {
                stack2.Push(stack1.Pop());
            }
        }

        if (stack2.Count == 0)
        {
            throw new InvalidOperationException("Queue is empty.");
        }

        return stack2.Peek();
    }

    public bool IsEmpty()
    {
        return stack1.Count == 0 && stack2.Count == 0;
    }
}

class QueueImplementationByStack
{
    static void Main()
    {
        QueueUsingStacks<int> queue = new QueueUsingStacks<int>();

        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);

        Console.WriteLine("Dequeue: " + queue.Dequeue());
        Console.WriteLine("Peek: " + queue.Peek());
        Console.WriteLine("Dequeue: " + queue.Dequeue());

        queue.Enqueue(4);
        queue.Enqueue(5);

        Console.WriteLine("Dequeue: " + queue.Dequeue());
        Console.WriteLine("Dequeue: " + queue.Dequeue());
        Console.WriteLine("Dequeue: " + queue.Dequeue());

        Console.WriteLine("Is Queue Empty: " + queue.IsEmpty());
    }
}