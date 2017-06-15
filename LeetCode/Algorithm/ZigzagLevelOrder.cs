using System.Collections.Generic;
using LeetCode.Model;

namespace LeetCode.Algorithm
{
    public partial class Solution
    {
        //103. Binary Tree Zigzag Level Order Traversal
        public IList<IList<int>> ZigzagLevelOrder(TreeNode root)
        {
            return ZigzagLevelOrder(new List<TreeNode>() { root }, true);
        }

        private IList<IList<int>> ZigzagLevelOrder(List<TreeNode> nodes, bool isLeft)
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
                if (nodes[n]==null)
                {
                    continue;
                }
                list.Add(nodes[n].val);
                if (!isLeft)
                {
                    nList.Add(nodes[n].right);
                    nList.Add(nodes[n].left);
                }
                else
                {
                    nList.Add(nodes[n].left);
                    nList.Add(nodes[n].right);
                }
            }
            if (list.Count!=0)
            {
                rList.Add(list);
            }
            var subList = ZigzagLevelOrder(nList, !isLeft);
            if (subList.Count != 0)
            {
                rList.AddRange(subList);
            }
            return rList;
        }
    }
}