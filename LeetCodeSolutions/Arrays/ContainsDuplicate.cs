namespace LeetCodeSolutions.Arrays;

/// <summary>
/// Runtime complexity: 0(n)
/// Space complexity: 0(n)
/// Runtime: 262ms
/// Memory: 68.01 MB
/// Solution pattern: HashSet or Sorting
/// Level: Easy
/// </summary>


public class ContainsDuplicate
{
    public bool Solve(int[] nums) {
        HashSet<int> uniqueValues = new HashSet<int>();

        for(int i = 0; i < nums.Length; i++)
        {
            int currentValue = nums[i];
            if(uniqueValues.Contains(currentValue))
            {
                return true;
            }
            uniqueValues.Add(currentValue);
        }

        return false;
    }
}