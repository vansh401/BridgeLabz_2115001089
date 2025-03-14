using System;
using System.Collections.Generic;

class SortStackRecursion
{
    static void SortStack(Stack<int> stack)
    {
        if (stack.Count > 0)
        {
            int top = stack.Pop();
            SortStack(stack);
            InsertSorted(stack, top);
        }
    }

    static void InsertSorted(Stack<int> stack, int element)
    {
        if (stack.Count == 0 || stack.Peek() <= element)
        {
            stack.Push(element);
        }
        else
        {
            int top = stack.Pop();
            InsertSorted(stack, element);
            stack.Push(top);
        }
    }

    static void PrintStack(Stack<int> stack)
    {
        foreach (int item in stack)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        Stack<int> stack = new Stack<int>();
        stack.Push(3);
        stack.Push(1);
        stack.Push(4);
        stack.Push(2);
        stack.Push(5);

        Console.WriteLine("Original stack:");
        PrintStack(stack);

        SortStack(stack);

        Console.WriteLine("Sorted stack:");
        PrintStack(stack);
    }
}