namespace LeetCode.Algorithm
{
    public partial class Solution
    {
        private int _begin = 0;
        private int _length = 1;

        public string LongestPalindrome(string s)
        {
            for (int i = 0; i < s.Length - 1; i++)
            {
                LongestPalindrome(s, i, i);
                LongestPalindrome(s, i, i + 1);
            }
            return s.Substring(_begin, _length);
        }

        private void LongestPalindrome(string s, int i, int j)
        {
            while (i >= 0 && j < s.Length)
            {
                if (s[i] == s[j])
                {
                    i--;
                    j++;
                    continue;
                }
                if (--j - ++i + 1 > _length)
                {
                    _length = j - i + 1;
                    _begin = i;
                }
                return;
            }
            i++;
            j--;
            if (j - i + 1 > _length)
            {
                _length = j - i + 1;
                _begin = i;
            }

        }
    }
}