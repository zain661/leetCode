//Remove Duplicates from Sorted Array
public class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        int pointer = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (pointer == 0 || nums[pointer - 1] != nums[i])
            {
                nums[pointer] = nums[i];
                pointer++;
            }
        }
        return pointer;
    }
}