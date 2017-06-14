using System;
using System.Collections.Generic;
using System.Linq;
using LeetCode.Model;

namespace LeetCodeTests
{
    public static class TestHelper
    {
        public static bool CompareList<T>(IList<T> thisList, IList<T> thatList) where T : IComparable
        {
            if (thisList == thatList)
            {
                return true;
            }
            if (thisList == null || thatList == null)
            {
                return false;
            }
            if (thisList.Count != thatList.Count)
            {
                return false;
            }
            var ti = thisList.OrderBy(t => t).ToArray();
            var ta = thatList.OrderBy(t => t).ToArray();
            for (int i = 0; i < ti.Length; i++)
            {
                if (ti[i].CompareTo(ta[i]) != 0)
                {
                    return false;
                }
            }
            return true;
        }

        public static ListNode CreateListNode(int[] array)
        {
            if (array == null || array.Length == 0)
            {
                return null;
            }
            ListNode head = new ListNode(array[0]);
            ListNode temp = head;
            for (int i = 1; i < array.Length; i++)
            {
                temp.next = new ListNode(array[i]);
                temp = temp.next;
            }
            return head;
        }
    }
}