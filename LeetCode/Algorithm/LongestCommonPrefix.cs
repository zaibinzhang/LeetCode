namespace LeetCode.Algorithm
{
    public partial class Solution
    {
        public string LongestCommonPrefix(string[] strs)
        {
            if (strs == null || strs.Length == 0)
            {
                return "";
            }
            int longest = strs[0].Length;
            for (int i = 1; i < strs.Length; i++)
            {
                if (strs[i].Length < longest)
                {
                    longest = strs[i].Length;
                }
                for (int j = 0; j < longest; j++)
                {
                    if (strs[0][j] != strs[i][j])
                    {
                        longest = j;
                        break;
                    }
                }
            }
            return strs[0].Substring(0, longest);
        }
    }
}