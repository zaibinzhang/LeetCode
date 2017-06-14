using System.Collections.Generic;
using LeetCode.Model;

namespace LeetCode.Algorithm
{
    public partial class Solution
    {
        //103. Binary Tree Zigzag Level Order Traversal
        public IList<IList<int>> ZigzagLevelOrder(TreeNode root)
        {
            return ZigzagLevelOrder(new List<TreeNode>() { root });
        }

        private IList<IList<int>> ZigzagLevelOrder(List<TreeNode> nodes)
        {
            if (nodes.Count == 0)
            {
                return new List<IList<int>>();
            }
            List<IList<int>> rList = new List<IList<int>>();
            IList<int> list = new List<int>();
            List<TreeNode> nList = new List<TreeNode>();
            for (int i = 0; i < nodes.Count; i++)
            {
                var n = nodes.Count - i - 1;
                list.Add(nodes[n].val);
                nList.Add(nodes[n]);
            }
            rList.Add(list);
            var subList = ZigzagLevelOrder(nList);
            if (subList.Count != 0)
            {
                rList.AddRange(subList);
            }
            return rList;
        }
    }
}