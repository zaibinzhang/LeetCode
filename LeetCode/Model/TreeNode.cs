using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Model
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
        public override string ToString()
        {
            Queue<TreeNode> queue = new Queue<TreeNode>();
            StringBuilder sb = new StringBuilder();
            queue.Enqueue(this);
            while (queue.Count > 0)
            {
                TreeNode node = queue.Dequeue();
                if (node != null)
                {
                    sb.Append(node.val + ",");
                    queue.Enqueue(node.left);
                    queue.Enqueue(node.right);
                }
                else
                {
                    sb.Append("null,");
                }
            }
            return sb.ToString().Trim(',', 'n', 'u', 'l');
        }

    }
}