using System;
using System.Collections.Generic;

class SubarrayWithZeroSum
{
    static List<(int, int)> FindZeroSumSubarrays(int[] nums)
    {
        List<(int, int)> result = new List<(int, int)>();
        Dictionary<int, List<int>> sumMap = new Dictionary<int, List<int>>();
        int cumulativeSum = 0;

        sumMap[0] = new List<int> { -1 };

        for (int i = 0; i < nums.Length; i++)
        {
            cumulativeSum += nums[i];

            if (sumMap.ContainsKey(cumulativeSum))
            {
                foreach (int startIndex in sumMap[cumulativeSum])
                {
                    result.Add((startIndex + 1, i));
                }
                sumMap[cumulativeSum].Add(i);
            }
            else
            {
                sumMap[cumulativeSum] = new List<int> { i };
            }
        }

        return result;
    }

    static void Main(string[] args)
    {
        int[] nums = { 1, 2, -3, 4, -4, 5, -5, 6 };
        List<(int, int)> zeroSumSubarrays = FindZeroSumSubarrays(nums);

        Console.WriteLine("Subarrays with zero sum:");
        foreach ((int start, int end) in zeroSumSubarrays)
        {
            Console.WriteLine("Start Index: " + start + ", End Index: " + end);
        }
    }
}