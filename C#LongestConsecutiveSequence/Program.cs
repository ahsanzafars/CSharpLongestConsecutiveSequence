using System;
using System.Collections.Generic;

class Program{
    static void Main()
    {
        int[][] testCases = 
        {
            [100, 4, 200, 1, 3, 2],  // Expected: 4 (1,2,3,4)
            [0, 3, 7, 2, 5, 8, 4, 6, 1, 9], // Expected: 10 (0-9)
            [10, 20, 30, 40],  // Expected: 1 (no consecutive numbers)
            [1, 9, 3, 10, 2, 20],  // Expected: 3 (1,2,3)
            []  // Expected: 0 (empty array)
        };

        foreach (var nums in testCases)
        {
            Console.WriteLine($"Input: {string.Join(", ", nums)}");
            Console.WriteLine($"Longest Consecutive Sequence: {LongestConsecutive(nums)}");
            Console.WriteLine(new string('-', 40));
        }
    }

    public static int LongestConsecutive(int[] nums){
        
        if (nums == null || nums.Length == 0)
        {
        return 0;
        }

        HashSet<int> set = [..nums];
       

        int longestStreak = 0;
        foreach(int num in set){
            if(!set.Contains(num - 1)){
                int currentNum = num;
                int currentStreak = 1;

                while(set.Contains(currentNum + 1)){
                    currentNum += 1;
                    currentStreak += 1;
                }

                longestStreak = Math.Max(longestStreak, currentStreak);
            }
        }

        return longestStreak;
    }
}

