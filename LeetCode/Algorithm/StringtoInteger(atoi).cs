namespace LeetCode.Algorithm
{
    public partial class Solution
    {
        public int MyAtoi(string str)
        {
            str = str.Trim();
            int length = 0;
            for (int i = 0; i < str.Length && i < 12; i++)
            {
                if (i == 0 && (str[i] == '+' || str[i] == '-'))
                {
                    continue;
                }
                if (str[i] < '0' || str[i] > '9')
                {
                    break;
                }
                length = i + 1;
            }
            if (length != 0)
            {
                long reti;
                long.TryParse(str.Substring(0, length), out reti);
                if (reti > int.MaxValue)
                {
                    return int.MaxValue;
                }
                if (reti < int.MinValue)
                {
                    return int.MinValue;
                }
                return (int)reti;
            }
            return 0;
        }
    }
}