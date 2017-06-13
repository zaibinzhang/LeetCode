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

            if (s.Length > 2)
            {
                if (s[0] == '1' || s[0] == '2' && s[1] <= '6')
                {
                    if (s[1] == '0')
                    {
                        return NumDecodings(s.Substring(2));
                    }
                    return NumDecodings(s.Substring(1)) + NumDecodings(s.Substring(2));
                }

                return NumDecodings(s.Substring(1));

            }

            if (s.Length == 2)
            {
                if ((s[0] == '1' || s[0] == '2' && s[1] <= '6') && s[1] != '0')
                {
                    return 2;
                }
                else if (s[0] >= '3' && s[1] == '0')
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }

            return 1;
        }
    }
}