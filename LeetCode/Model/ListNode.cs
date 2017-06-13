using System.Text;

namespace LeetCode.Model
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("[");
            ListNode temp = this;
            sb.Append(this.val);
            while (temp.next != null)
            {
                sb.Append("," + temp.next.val);
                temp = temp.next;
            }
            sb.Append("]");
            return sb.ToString();
        }
    }
}