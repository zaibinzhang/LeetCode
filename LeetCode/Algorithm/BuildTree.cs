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
            if (preorder == null || preorder.Length == 0)
            {
                return null;
            }
            TreeNode node = new TreeNode(preorder[0]);
            List<int> inleft = new List<int>();
            List<int> inright = new List<int>();
            List<int> preleft = new List<int>();
            List<int> preright = new List<int>();
            bool isleft = true;
            for (int i = 0; i < inorder.Length; i++)
            {
                if (inorder[i] == preorder[0])
                {
                    isleft = false;
                    continue;
                }
                if (isleft)
                {
                    inleft.Add(inorder[i]);
                }
                else
                {
                    inright.Add(inorder[i]);
                }
            }

            if (inright.Count > 0)
            {
                isleft = true;
                for (int i = 1; i < preorder.Length; i++)
                {
                    if (!isleft || inright.Contains(preorder[i]))
                    {
                        isleft = false;
                    }
                    if (isleft)
                    {
                        preleft.Add(preorder[i]);
                    }
                    else
                    {
                        preright.Add(preorder[i]);
                    }
                }
            }
            else
            {
                for (int i = 1; i < preorder.Length; i++)
                {
                    preleft.Add(preorder[i]);
                }
            }

            node.left = BuildTree(preleft.ToArray(), inleft.ToArray());
            node.right = BuildTree(preright.ToArray(), inright.ToArray());

            return node;
        }
    }
}