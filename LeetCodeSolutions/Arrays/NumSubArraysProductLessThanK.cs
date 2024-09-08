namespace LeetCodeSolutions.Arrays;

public class NumSubArraysProductLessThanK
{
    public int FindNumSubarrayProductLessThanK(int[] nums, int k) 
    {
        if (k == 0)
        {
            return 0;
        }
        
        int subArraysCount = 0;
        int startWindow = 0;
        int product = 1;

        for(int endWindow = 0; endWindow < nums.Length; endWindow++)
        {
            product *= nums[endWindow];

            while(product >= k)
            {
                product /= nums[startWindow];
                startWindow++;
            }

            subArraysCount += (endWindow - startWindow) + 1;
        }
        
        return subArraysCount;
    }
}