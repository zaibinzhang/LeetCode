using System;

namespace LeetCode.Algorithm
{
    public partial class Solution
    {
        public int NumDecodings(string s)
        {
            if (string.IsNullOrEmpty(s) || s[0] == '0')
            {
                return 0;
            }

            if (s.Length == 1)
            {
                if (s[0] == '0')
                {
                    return 0;
                }
                return 1;
            }

            int num = System.Convert.ToInt32(s.Substring(0, 2));
            if (num <= 26)
            {
                var i = s.Length == 2 ? 1 : NumDecodings(s.Substring(2));
                return NumDecodings(s.Substring(1)) + i;
            }
            else
            {
                return NumDecodings(s.Substring(1));
            }
        }
    }
}