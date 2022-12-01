//Majority Element
public class Solution
{
    public int MajorityElement(int[] nums)
    {
        int majority = nums[0];
        int counter = 1;
        for (int num = 1; num < nums.Length; num++)
        {
            if (counter == 0)
            {
                majority = nums[num];
            }
            if (nums[num] == majority)
            {
                counter++;
            }
            else
            {
                counter--;
            }


        }
        return majority;
    }
}