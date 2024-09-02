namespace LeetCodeSolutions.Arrays;

/// <summary>
/// Runtime complexity: 0(n)
/// Space complexity: 0(1)
/// Runtime: 120ms
/// Memory: 49.93 MB
/// Solution pattern: Two Pointers
/// Level: Easy
/// </summary>

public class RemoveDuplicatesFromSortedArray
{
   public int RemoveDuplicates(int[] nums) {

        if (nums is null || nums.Length == 0)
        {
            return 0;
        }

        int writePointer = 0;
        int readPointer = 1;

        while (readPointer < nums.Length)
        {
            if(nums[readPointer] == nums[writePointer])
            { 
                readPointer++; 
                continue;
            }
        
            writePointer++;
            nums[writePointer] = nums[readPointer];
        }

        return writePointer + 1;
    }
}