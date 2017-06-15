using LeetCode.Model;

namespace LeetCode.Algorithm
{
    public partial class Solution
    {
        //106. Construct Binary Tree from Inorder and Postorder Traversal
        public TreeNode BuildTree2(int[] inorder, int[] postorder)
        {
            int index = postorder.Length - 1;
            return BuildTree2(0, postorder.Length - 1, ref index, inorder, postorder);
        }

        public TreeNode BuildTree2(int start, int end, ref int index, int[] inorder, int[] postorder)
        {
            if (index < 0)
            {
                return null;
            }
            if (start > end)
            {
                index++;
                return null;
            }
            if (start == end)
            {
                return new TreeNode(inorder[start]);
            }
            int val = postorder[index];
            TreeNode node = new TreeNode(val);
            int valIndex = 0;
            for (int i = start; i <= end; i++)
            {
                if (inorder[i] == val)
                {
                    valIndex = i;
                    break;
                }
            }
            if (end > valIndex)
            {
                index--;
                node.right = BuildTree2(valIndex + 1, end, ref index, inorder, postorder);
            }
            index--;
            node.left = BuildTree2(start, valIndex - 1, ref index, inorder, postorder);
            return node;
        }
    }
}