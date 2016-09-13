using System;

namespace LeetCode.Algorithm
{
    public partial class Solution
    {
        public int LengthOfLongestSubstring(string s)
        {
            int[] R = new int[256];
            int max = 0;
            int n = 1;
            for (int i = 0; i < s.Length; i++)
            {
                if (R[s[i]] == 0)
                {
                    R[s[i]] = n++;
                }
                else
                {
                    max = Math.Max(max, n - 1);
                    int m = R[s[i]];
                    for (int j = 0; j < m; j++)//把超过的设置为0
                    {
                        R[s[i - n + 1 + j]] = 0;
                    }
                    for (int j = 0; j < n - 1 - m; j++)//把还在数组里的减去
                    {
                        R[s[i - j - 1]] -= m;
                    }
                    n -= m;
                    R[s[i]] = n++;
                }
            }
            max = Math.Max(max, n - 1);
            return max;
        }
    }
}