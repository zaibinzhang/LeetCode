using LeetCode.Model;

namespace LeetCode.Algorithm
{
    public partial class Solution
    {
        //106. Construct Binary Tree from Inorder and Postorder Traversal
        public TreeNode BuildTree2(int[] inorder, int[] postorder)
        {
            return BuildTree2(0, postorder.Length - 1, postorder.Length - 1, inorder, postorder);
        }

        public TreeNode BuildTree2(int start, int end, int index, int[] inorder, int[] postorder)
        {
            if (start > end || index < 0)
            {
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
                node.right = BuildTree2(valIndex + 1, end, --index, inorder, postorder);
            }
            node.left = BuildTree2(start, valIndex - 1, index - 1, inorder, postorder);
            return node;
        }
    }
}