namespace LeetCode.Algorithm
{
    public partial class Solution
    {
        public int Reverse(int x)
        {
            bool isfu = false;
            if (x < 0)
            {
                x = 0 - x;
                isfu = true;
            }

            int t = 0;
            int r = 0;
            while (x != 0)
            {
                t = x % 10;
                if (r > (int.MaxValue - t) / 10)
                { return 0; }
                r = r * 10 + t;
                x = x / 10;
            }
            return isfu ? (0 - r) : r;
        }
    }
}