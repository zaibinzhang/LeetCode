using System.Collections.Generic;

namespace LeetCode.Algorithm
{
    public partial class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (list.Contains(target - nums[i]))
                {
                    int[] rets = new int[2];
                    rets[0] = list.IndexOf(target - nums[i]);
                    rets[1] = i;
                    return rets;
                }
                list.Add(nums[i]);
            }
            return new int[2];
        }
    }
}