using System;
using System.Collections.Generic;
using System.Linq;
using LeetCode.Model;

namespace LeetCodeTests
{
    public static class TestHelper
    {
        public static bool CompareListByOrder<T>(IList<T> thisList, IList<T> thatList) where T : IComparable
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
            for (int i = 0; i < thisList.Count; i++)
            {
                if (thisList[i].CompareTo(thatList[i]) != 0)
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

        public static TreeNode CreateTreeNode(string nodestr)
        {
            if (string.IsNullOrEmpty(nodestr))
            {
                return null;
            }
            string[] nodes = nodestr.Split(',');
            Queue<string> queueNums = new Queue<string>(nodes);
            Queue<TreeNode> queueNodes = new Queue<TreeNode>();
            TreeNode head = new TreeNode(int.Parse(queueNums.Dequeue()));
            queueNodes.Enqueue(head);
            while (queueNums.Count > 1)
            {
                string nStr1 = queueNums.Dequeue();
                string nStr2 = queueNums.Dequeue();
                TreeNode node = queueNodes.Dequeue();
                var node1 = ConverToTreeNode(nStr1);
                var node2 = ConverToTreeNode(nStr2);
                node.left = node1;
                node.right = node2;
                if (node1 != null)
                {
                    queueNodes.Enqueue(node1);
                }
                if (node2 != null)
                {
                    queueNodes.Enqueue(node2);
                }
            }
            if (queueNums.Count != 0)
            {
                TreeNode node = queueNodes.Dequeue();
                node.left = ConverToTreeNode(queueNums.Dequeue());
            }
            return head;
        }

        private static TreeNode ConverToTreeNode(string str)
        {
            return str == "null" ? null : new TreeNode(int.Parse(str));
        }

        public static IList<IList<int>> CreateILists(string str)
        {
            IList<IList<int>> list = new List<IList<int>>();
            str = str.Substring(1, str.Length - 2);
            var strs = str.Split(new string[] { "],[" }, StringSplitOptions.None);
            foreach (string s in strs)
            {
                var temp = s.Trim('[', ']');
                var temps = temp.Split(',');
                IList<int> subList = new List<int>();
                foreach (string subTemp in temps)
                {
                    subList.Add(int.Parse(subTemp));
                }
                list.Add(subList);
            }
            return list;
        }
    }
}