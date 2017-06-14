﻿using LeetCode.Model;
// ReSharper disable All

namespace LeetCode.Algorithm
{
    //98. Validate Binary Search Tree
    public partial class Solution
    {
        public bool IsValidBST(TreeNode root)
        {
            if (root == null)
            {
                return true;
            }
            if (root.left != null)
            {
                var left = root.left;
                while (left.right != null)
                {
                    left = left.right;
                }
                if (left.val >= root.val)
                {
                    return false;
                }
            }
            if (root.right != null)
            {
                var right = root.right;
                while (right.left != null)
                {
                    right = right.left;
                }
                if (right.val <= root.val)
                {
                    return false;
                }
            }
            return IsValidBST(root.left) && IsValidBST(root.right);
        }

    }
}