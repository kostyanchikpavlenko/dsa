using System.Collections.Generic;

namespace LeetCodeSolutions.Arrays;

public class TwoSum
{
    public int[] Solve(int[] nums, int target)
    {
        var map = new Dictionary<int, int>();
        int[] result = new int[] { };

        for (var i = 0; i <= nums.Length; i++)
        {
            var currentValue = nums[i];
            var complement = target - currentValue;

            if (map.ContainsKey(complement))
            {
                result = new int[] { map[complement], i };
                break;
            }

            map[nums[i]] = i;
        }

        return result;
    }
}