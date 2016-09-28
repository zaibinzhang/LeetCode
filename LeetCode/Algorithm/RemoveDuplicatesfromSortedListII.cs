using LeetCode.Model;

namespace LeetCode.Algorithm
{
    public partial class Solution
    {
        public ListNode DeleteDuplicates(ListNode head)
        {
            if (head==null)
            {
                return null;
            }
            int cur = head.val;
            bool b = false;
            while (head.next != null)
            {
                if (head.next.val == cur)
                {
                    head.next = head.next.next;
                    b = true;
                }
                else
                {
                    head.next = DeleteDuplicates(head.next);
                    break;
                }
            }
            if (b)
            {
                return head.next;
            }
            else
            {
                return head;
            }
        }
    }
}