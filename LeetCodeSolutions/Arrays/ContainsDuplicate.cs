namespace LeetCodeSolutions.Arrays;

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