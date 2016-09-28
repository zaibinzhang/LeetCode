using LeetCode.Model;

namespace LeetCode.Algorithm
{
    public partial class Solution
    {
        public ListNode Partition(ListNode head, int x)
        {
            ListNode l = null, g = null, lt = null, gt = null;
            while (head != null)
            {
                if (head.val < x)
                {
                    if (l == null)
                    {
                        l = lt = head;
                    }
                    else
                    {
                        lt.next = head;
                        lt = lt.next;
                    }
                }
                else
                {
                    if (g == null)
                    {
                        g = gt = head;
                    }
                    else
                    {
                        gt.next = head;
                        gt = gt.next;
                    }
                }
                head = head.next;
            }
            if (lt != null) lt.next = g;
            if (gt != null) gt.next = null;
            return l ?? g;
        }
    }
}