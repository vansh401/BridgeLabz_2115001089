using System;
using System.Collections.Generic;

class ArrayPairSum
{
    static bool FindPairWithSum(int[] nums, int target)
    {
        HashSet<int> visitedNumbers = new HashSet<int>();

        foreach (int num in nums)
        {
            int complement = target - num;
            if (visitedNumbers.Contains(complement))
            {
                return true;
            }
            visitedNumbers.Add(num);
        }

        return false;
    }

    static void Main(string[] args)
    {
        int[] nums = { 2, 7, 11, 15 };
        int target = 9;

        bool pairExists = FindPairWithSum(nums, target);

        if (pairExists)
        {
            Console.WriteLine("There exists a pair of elements whose sum is equal to the target.");
        }
        else
        {
            Console.WriteLine("No pair of elements with the given sum exists in the array.");
        }
    }
}