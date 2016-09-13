using System;

namespace LeetCode.Algorithm
{
    public partial class Solution
    {
        public int MaxArea(int[] height)
        {
            int i = 0, j = height.Length - 1, max = 0;
            while (i < j)
            {
                max = Math.Max(max, Math.Min(height[i], height[j]) * (j - i));
                if (height[i] > height[j])
                {
                    j--;
                }
                else
                {
                    i++;
                }
            }
            return max;
        }
    }
}