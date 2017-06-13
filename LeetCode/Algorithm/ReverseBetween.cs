using System.Collections.Generic;
using LeetCode.Model;

namespace LeetCode.Algorithm
{
    public partial class Solution
    {
        //92. Reverse Linked List II
        public ListNode ReverseBetween(ListNode head, int m, int n)
        {
            ListNode mhead, thead = head, nhead;
            int i;
            if (m != 1)
            {
                i = 1;
                while (i < m)
                {
                    i++;
                    thead = thead.next;
                }
                mhead = thead;
            }
            i = 1;
            thead = head;
            while (i < n)
            {
                i++;
                thead = thead.next;
            }
            nhead = thead;

            return null;
        }
    }
}