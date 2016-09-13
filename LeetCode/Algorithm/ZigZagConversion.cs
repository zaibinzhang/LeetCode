namespace LeetCode.Algorithm
{
    public partial class Solution
    {
        public string Convert(string s, int numRows)
        {
            if (numRows == 1)
            {
                return s;
            }
            int n = (numRows - 1) * 2;
            string res = "";
            for (int i = 0; i < numRows; i++)
            {
                //if (i % numRows == 0 || i % numRows == numRows - 1)
                //{
                int j = i;
                while (j < s.Length)
                {
                    res += s[j];
                    if (i % numRows != 0 && i % numRows != numRows - 1 && j + (n - 2 * i) < s.Length)
                    {
                        res += s[j + (n - 2 * i)];
                    }
                    j += n;
                }

            }
            return res;
        }
    }
}