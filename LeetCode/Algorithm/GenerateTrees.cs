using System.Collections.Generic;
using System.Linq;
using LeetCode.Model;

namespace LeetCode.Algorithm
{
    //95. Unique Binary Search Trees II
    public partial class Solution
    {
        public IList<TreeNode> GenerateTrees(int n)
        {
            if (n == 0)
            {
                return new List<TreeNode>();
            }
            List<int> list = new List<int>();
            for (int i = 0; i < n; i++)
            {
                list.Add(i + 1);
            }
            return GenerateTrees(list);
        }

        private IList<TreeNode> GenerateTrees(List<int> numbers)
        {
            List<TreeNode> list = new List<TreeNode>();
            for (int i = 0; i < numbers.Count; i++)
            {
                var newNumbers = numbers.ToList();
                newNumbers.Remove(numbers[i]);
                var littleNums = (from n in numbers where n < numbers[i] select n).ToList();
                var bigNums = (from n in numbers where n > numbers[i] select n).ToList();
                var littleList = GenerateTrees(littleNums);
                var bigList = GenerateTrees(bigNums);
                if (littleList.Count == 0 && bigList.Count == 0)
                {
                    TreeNode node = new TreeNode(numbers[i]);
                    list.Add(node);
                }
                else
                {
                    foreach (TreeNode node in bigList)
                    {
                        foreach (TreeNode ll in littleList)
                        {
                            TreeNode n = new TreeNode(numbers[i]);
                            n.right = node;
                            n.left = ll;
                            list.Add(n);
                        }
                    }
                }
            }
            if (list.Count == 0)
            {
                list.Add(null);
            }
            return list;
        }
    }
}