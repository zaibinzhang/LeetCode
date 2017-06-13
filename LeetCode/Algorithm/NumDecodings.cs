using System;

namespace LeetCode.Algorithm
{
    public partial class Solution
    {
        //91. Decode Ways
        //问题出于没有把已经走过的路径保存下来
        public int NumDecodings(string s)
        {
            if (string.IsNullOrEmpty(s) || s[0] == '0')
            {
                return 0;
            }

            int[] rs = new int[s.Length + 1];

            rs[s.Length] = 1;

            if (s[s.Length - 1] != '0')
            {
                rs[s.Length - 1] = 1;
            }

            for (int i = s.Length - 2; i >= 0; i--)
            {
                if (s[i] == '0')
                {
                    continue;
                }
                if (s[i] == '1' || s[i] == '2' && s[i + 1] <= '6')
                {
                    rs[i] = rs[i + 1] + rs[i + 2];
                }
                else
                {
                    rs[i] = rs[i + 1];
                }
            }
            return rs[0];
        }
    }
}