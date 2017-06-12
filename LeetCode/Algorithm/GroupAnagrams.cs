using System;
using System.Collections.Generic;

namespace LeetCode.Algorithm
{
    public partial class Solution
    {
        //49. Group Anagrams
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            Dictionary<string, IList<string>> dic = new Dictionary<string, IList<string>>();
            foreach (string s in strs)
            {
                var cs = s.ToCharArray();
                Array.Sort(cs);
                string tempcs = new string(cs);
                if (dic.ContainsKey(tempcs))
                {
                    //list[temp.IndexOf(tempcs)].Add(s);
                    dic[tempcs].Add(s);
                }
                else
                {
                    dic.Add(tempcs, new List<string>() { s });
                }
            }
            return new List<IList<string>>(dic.Values);
        }
    }
}