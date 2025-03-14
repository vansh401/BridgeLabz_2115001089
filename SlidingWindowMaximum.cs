using System;
using System.Collections.Generic;

class SlidingWindowMaximum
{
    static List<int> FindMaxInSlidingWindow(int[] nums, int k)
    {
        List<int> result = new List<int>();
        Deque<int> deque = new Deque<int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (deque.Count > 0 && deque.First.Value <= i - k)
            {
                deque.RemoveFirst();
            }

            while (deque.Count > 0 && nums[deque.Last.Value] < nums[i])
            {
                deque.RemoveLast();
            }

            deque.AddLast(i);

            if (i >= k - 1)
            {
                result.Add(nums[deque.First.Value]);
            }
        }

        return result;
    }

    static void Main(string[] args)
    {
        int[] nums = { 1, 3, -1, -3, 5, 3, 6, 7 };
        int k = 3;
        List<int> maxElements = FindMaxInSlidingWindow(nums, k);

        Console.WriteLine("Maximum elements in each sliding window:");
        foreach (int max in maxElements)
        {
            Console.Write(max + " ");
        }
    }
}

public class Deque<T> : LinkedList<T>
{
    public void AddFirst(T item)
    {
        AddFirst(new LinkedListNode<T>(item));
    }

    public void AddLast(T item)
    {
        AddLast(new LinkedListNode<T>(item));
    }

    public T RemoveFirst()
    {
        T value = First.Value;
        RemoveFirst();
        return value;
    }

    public T RemoveLast()
    {
        T value = Last.Value;
        RemoveLast();
        return value;
    }
}