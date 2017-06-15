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
            return Log(this).Trim(',', 'n', 'u', 'l');
        }

        private string Log(TreeNode node)
        {
            if (node == null)
            {
                return "null";
            }
            return node.val + "," + Log(node.left) + "," + Log(node.right);
        }
    }
}