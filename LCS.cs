using System;
using System.Collections.Generic;

class LCS
{
    static int LongestConsecutiveSequence(int[] nums)
    {
        if (nums.Length == 0)
        {
            return 0;
        }

        HashSet<int> numSet = new HashSet<int>(nums);
        int longestStreak = 0;

        foreach (int num in numSet)
        {
            if (!numSet.Contains(num - 1))
            {
                int currentNum = num;
                int currentStreak = 1;

                while (numSet.Contains(currentNum + 1))
                {
                    currentNum++;
                    currentStreak++;
                }

                longestStreak = Math.Max(longestStreak, currentStreak);
            }
        }

        return longestStreak;
    }

    static void Main(string[] args)
    {
        int[] nums = { 100, 4, 200, 1, 3, 2 };
        int longestStreak = LongestConsecutiveSequence(nums);

        Console.WriteLine("The length of the longest consecutive elements sequence is: " + longestStreak);
    }
}