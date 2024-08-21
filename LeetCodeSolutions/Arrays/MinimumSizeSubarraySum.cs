namespace LeetCodeSolutions.Arrays;
/// <summary>
/// Runtime complexity: 0(n)
/// Space complexity: 0(1)
/// Runtime: 133ms
/// Memory: 51.74 MB
/// Solution pattern: Sliding Window
/// Level: Medium
/// </summary>

public class MinimumSizeSubarraySum {
    public int MinSubArrayLen(int target, int[] nums) {

        if(nums.Length == 0)
        {
            return 0;
        }

        int subArrayMinSize = int.MaxValue;
        int windowStart = 0;
        int sum = 0;

        for(int windowEnd = 0; windowEnd < nums.Length; windowEnd++)
        {
            sum += nums[windowEnd];

            while(sum >= target)
            {
                subArrayMinSize = Math.Min(subArrayMinSize, (windowEnd - windowStart) + 1);
                sum -= nums[windowStart];
                windowStart++;
            }
        }

        return subArrayMinSize == int.MaxValue ? 0 : subArrayMinSize;
    }
}