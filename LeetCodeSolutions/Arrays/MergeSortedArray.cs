namespace LeetCodeSolutions.Arrays;

/// <summary>
/// Runtime complexity: 0(m + n)
/// Space complexity: 0(1)
/// Runtime: 102ms
/// Memory: 49.90 MB
/// Solution pattern: Two pointers (actually 3 pointers.)
/// Level: Easy
/// </summary>


public class MergeSortedArray
{
   public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        if (n == 0)
        {
            return;
        }

        int writePointer = nums1.Length - 1;
        int firstArrayPointer = m - 1;
        int secondArrayPointer = n - 1;

        while (secondArrayPointer >= 0)
        {
            if (firstArrayPointer >= 0
                && nums1[firstArrayPointer] > nums2[secondArrayPointer])
            {
                nums1[writePointer] = nums1[firstArrayPointer];
                firstArrayPointer--;
            }
            else
            {
                nums1[writePointer] = nums2[secondArrayPointer];
                secondArrayPointer--;
            }

            writePointer--;
        }
    }
}