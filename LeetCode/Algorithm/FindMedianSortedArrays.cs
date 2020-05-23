using System;
using System.Text.RegularExpressions;

namespace LeetCode.Algorithm
{
    public partial class Solution
    {
        //4. Median of Two Sorted Arrays
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int l = nums1.Length + nums2.Length;
            int jo = l % 2;
            int min = l / 2 - 1 + jo;
            int i = 0, i1 = 0, i2 = 0, r = 0;
            while (i <= min)
            {
                if (nums1.Length == i1)
                {
                    r = nums2[i2];
                    i2++;
                    i++;
                    continue;
                }

                if (nums2.Length == i2)
                {
                    r = nums1[i1];
                    i1++;
                    i++;
                    continue;
                }

                if (nums1[i1] > nums2[i2])
                {
                    r = nums2[i2];
                    i2++;
                }
                else
                {
                    r = nums1[i1];
                    i1++;
                }

                i++;
            }

            if (jo == 0)
            {
                if (nums2.Length == i2)
                {
                    i2--;
                }

                if (nums1.Length == i1)
                    i1--;
                return r + (double)Math.Min(nums1[i1], nums2[i2]) / 2;
            }
            else
            {
                return r;
            }
        }
    }
}