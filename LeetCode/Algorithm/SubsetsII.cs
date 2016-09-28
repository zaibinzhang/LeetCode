using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Algorithm
{
    public partial class Solution
    {
        public IList<IList<int>> SubsetsWithDup(int[] nums)
        {
            List<int> list = new List<int>();
            list.AddRange(nums);
            list.Sort();
            return SubsetsWithDup(list, 0, new List<int>());
        }

        private IList<IList<int>> SubsetsWithDup(List<int> numsList, int index, List<int> one)
        {
            List<IList<int>> list = new List<IList<int>>() { one };
            if (numsList.Count == index)
            {
                return list;
            }

            for (int i = index; i < numsList.Count; i++)
            {
                List<int> temp = one.ToList();
                temp.Add(numsList[i]);
                if (i > index && numsList[i] == numsList[i - 1])
                {
                    continue;
                }
                list.AddRange(SubsetsWithDup(numsList, i + 1, temp));
            }

            return list;
        }
    }
}