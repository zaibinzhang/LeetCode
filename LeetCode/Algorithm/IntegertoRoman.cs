namespace LeetCode.Algorithm
{
    public partial class Solution
    {
        public string IntToRoman(int num)
        {
            string[] s = new string[] { "", "M", "MM", "MMM" };
            string[] h = new string[] { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
            string[] t = new string[] { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
            string[] o = new string[] { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
            return s[num / 1000] + h[num / 100 % 10] + t[num / 10 % 10] + o[num % 10];
        }
    }
}