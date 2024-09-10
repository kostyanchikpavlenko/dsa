namespace LeetCodeSolutions.Arrays;

public class SortColor
{
   public void SortColors(int[] nums) 
    {
        if(nums is null || nums.Length == 0)
        {
            return;
        }

        int[] colors = new int[3];

        foreach (var t in nums)
        {
            colors[t]++;
        }

        int colorPointer = 0;
        int index = 0;

        while (index < nums.Length)
        {
            if (colors[colorPointer] == 0)
            {
                colorPointer++;
                continue;
            }

            nums[index] = colorPointer;
            colors[colorPointer]--;
            index++;
        }
    }
}