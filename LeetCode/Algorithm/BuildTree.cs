using System.Collections.Generic;
using System.Linq;
using LeetCode.Model;

namespace LeetCode.Algorithm
{
    public partial class Solution
    {
        //105. Construct Binary Tree from Preorder and Inorder Traversal
        public TreeNode BuildTree(int[] preorder, int[] inorder)
        {
            return BuildTree(0, 0, inorder.Length - 1, preorder, inorder);
        }

        private TreeNode BuildTree(int preStart, int inStart, int inEnd, int[] preorder, int[] inorder)
        {
            if (preStart > preorder.Length - 1 || inStart > inEnd)
            {
                return null;
            }
            TreeNode root = new TreeNode(preorder[preStart]);
            int inIndex = 0; // Index of current root in inorder
            for (int i = inStart; i <= inEnd; i++)
            {
                if (inorder[i] == root.val)
                {
                    inIndex = i;
                }
            }
            root.left = BuildTree(preStart + 1, inStart, inIndex - 1, preorder, inorder);
            root.right = BuildTree(preStart + inIndex - inStart + 1, inIndex + 1, inEnd, preorder, inorder);
            return root;
        }
    }
}