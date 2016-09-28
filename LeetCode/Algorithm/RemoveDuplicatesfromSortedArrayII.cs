namespace LeetCode.Algorithm
{
    public partial class Solution
    {
        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0)
            {
                return 0;
            }
            int count = 1;
            int n = 0;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] == nums[i - 1])
                {
                    n++;
                    if (n < 2)
                    {
                        nums[count++] = nums[i];
                    }
                }
                else
                {
                    n = 0;
                    nums[count++] = nums[i];
                }
            }
            return count;
        }
    }
}