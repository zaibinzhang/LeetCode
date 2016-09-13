namespace LeetCode.Algorithm
{
    public partial class Solution
    {
        public bool IsPalindrome(int x)
        {
            if (x < 0)
            {
                return false;
            }
            if (x < 10)
            {
                return true;
            }
            int t = 0;
            int y = x;
            while (y != 0)
            {
                t = t * 10 + y % 10;
                y = y / 10;
            }
            return x == t;
        }
    }
}