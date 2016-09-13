namespace LeetCode.Algorithm
{
    public partial class Solution
    {
        public int RomanToInt(string s)
        {
            int[] romans = new int[s.Length];
            for (int i = 0; i < s.Length; i++)
            {
                romans[i] = GetRomanInt(s[i]);
            }
            int total = 0, last = 0;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (romans[i] < last)
                {
                    total -= romans[i];
                }
                else
                {
                    total += romans[i];
                }
                last = romans[i];
            }
            return total;
        }

        private int GetRomanInt(char r)
        {
            int roman = 0;
            switch (r)
            {
                case 'I':
                    roman = 1;
                    break;
                case 'X':
                    roman = 10;
                    break;
                case 'C':
                    roman = 100;
                    break;
                case 'M':
                    roman = 1000;
                    break;
                case 'V':
                    roman = 5;
                    break;
                case 'L':
                    roman = 50;
                    break;
                case 'D':
                    roman = 500;
                    break;
            }
            return roman;
        }

    }
}