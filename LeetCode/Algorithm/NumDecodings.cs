using System;

namespace LeetCode.Algorithm
{
    public partial class Solution
    {
        public int NumDecodings(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return 0;
            }

            if (s.Length == 1)
            {
                if (s[0]=='0')
                {
                    return 0;
                }
                return 1;
            }

            if (s[1] == '0' && (s[0] == '1' || s[0] == '2'))
            {
                return 1 + NumDecodings(s.Substring(2));
            }

            int num = System.Convert.ToInt32(s.Substring(0, 2));
            if (num <= 26)
            {
                return 1 + NumDecodings(s.Substring(1)) + NumDecodings(s.Substring(2));
            }
            else
            {
                return 1 + NumDecodings(s.Substring(1));
            }
        }
    }
}