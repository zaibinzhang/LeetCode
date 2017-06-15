using System.Linq;
using LeetCode.Model;

namespace LeetCode.Algorithm
{
    public partial class Solution
    {
        //105. Construct Binary Tree from Preorder and Inorder Traversal
        public TreeNode BuildTree(int[] preorder, int[] inorder)
        {
            if (preorder == null || preorder.Length == 0)
            {
                return null;
            }
            TreeNode node = new TreeNode(preorder[0]);
            var index = inorder.ToList().IndexOf(preorder[0]);
            var firsti = inorder.Take(index);
            var lasti = inorder.Skip(index + 1);
            var firstp = from i in preorder where i != preorder[0] && !firsti.Contains(i) select i;
            var lastp = from i in preorder where i != preorder[0] && !lasti.Contains(i) select i;
            node.left = BuildTree(firstp.ToArray(), firsti.ToArray());
            node.right = BuildTree(lastp.ToArray(), lasti.ToArray());
            return node;
        }
    }
}