using System.Collections.Generic;
using LeetCode.Model;

namespace LeetCode.Algorithm
{
    public partial class Solution
    {
        //92. Reverse Linked List II
        public ListNode ReverseBetween(ListNode head, int m, int n)
        {
            if (m == n)
            {
                return head;
            }
            List<ListNode> list = new List<ListNode>();
            ListNode tempNode = head;
            while (tempNode != null)
            {
                list.Add(tempNode);
                tempNode = tempNode.next;
            }
            if (m > 1)
            {
                list[m - 2].next = list[n - 1];
                list[n - 2].next = list[m - 1];
                tempNode = list[m - 1].next;
                list[m - 1].next = list[n - 1].next;
                list[n - 1].next = tempNode;
            }
            else
            {
                list[n - 2].next = list[m - 1];
                tempNode = list[m - 1].next;
                list[m - 1].next = list[n - 1].next;
                list[n - 1].next = tempNode;
                head = list[n - 1];
            }
            return head;
        }
    }
}