using LeetCode.Model;

namespace LeetCode.Algorithm
{
    public partial class Solution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            long sum = AddTwoNumbers(l1) + AddTwoNumbers(l2);
            ListNode node = new ListNode((int)(sum % 10));
            ListNode head = node;
            sum /= 10;
            while (sum != 0)
            {
                node.next = new ListNode((int)(sum % 10));
                sum /= 10;
                node = node.next;
            }
            return head;
        }

        private long AddTwoNumbers(ListNode node)
        {
            long i = 1;
            long sum = 0;
            while (node != null)
            {
                sum += i * node.val;
                node = node.next;
                i *= 10;
            }
            return sum;
        }
    }
}