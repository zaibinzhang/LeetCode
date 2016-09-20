using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Algorithm
{
    public partial class Solution
    {
        public IList<IList<int>> Subsets(int[] nums)
        {
            List<int> list = new List<int>();
            list.AddRange(nums);
            return Subsets(list, 0, new List<int>());
        }

        private IList<IList<int>> Subsets(List<int> numsList, int index, List<int> one)
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
                list.AddRange(Subsets(numsList, i + 1, temp));
            }

            return list;
        }
    }
}