namespace LeetCodeSolutions.Arrays;

/// <summary>
/// Runtime complexity: 0(n)
/// Space complexity: 0(n)
/// Runtime: 153ms
/// Memory: 63.18 MB
/// Solution pattern: Two Pointers (left and right)
/// Level: easy
/// </summary>

public class SortedSquares
{
   public int[] SortSquares(int[] nums) 
    {
        if (nums.Length == 0)
        {
            return nums;
        }
    
        int[] result = new int[nums.Length];
    
        int startPointer = 0;
        int endPointer = nums.Length - 1;
        int writeIndex = result.Length - 1;

        while (writeIndex >= 0)
        {
            int leftSquare = nums[startPointer] * nums[startPointer];
            int rightSquare = nums[endPointer] * nums[endPointer];
           
            if (rightSquare > leftSquare)
            {
                result[writeIndex] = rightSquare;
                endPointer--;
            }
            else
            {
                result[writeIndex] = leftSquare;
                startPointer++;
            }

            writeIndex--;
        }
    
        return result;
    }
}