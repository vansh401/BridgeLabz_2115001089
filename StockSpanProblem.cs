using System;
using System.Collections.Generic;

class StockSpanProblem
{
    static int[] CalculateSpan(int[] prices)
    {
        int[] span = new int[prices.Length];
        Stack<int> stack = new Stack<int>();

        for (int i = 0; i < prices.Length; i++)
        {
            while (stack.Count > 0 && prices[i] >= prices[stack.Peek()])
            {
                stack.Pop();
            }

            span[i] = (stack.Count == 0) ? (i + 1) : (i - stack.Peek());
            stack.Push(i);
        }

        return span;
    }

    static void Main(string[] args)
    {
        int[] prices = { 100, 80, 60, 70, 60, 75, 85 };
        int[] span = CalculateSpan(prices);

        Console.WriteLine("Stock prices: " + string.Join(", ", prices));
        Console.WriteLine("Spans: " + string.Join(", ", span));
    }
}