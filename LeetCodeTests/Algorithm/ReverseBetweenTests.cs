using LeetCode.Algorithm;
using LeetCode.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeTests.Algorithm
{
    public partial class SolutionTests
    {
        private ListNode CreateListNode(int[] array)
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

        [TestMethod()]
        public void ReverseBetweenTest1()
        {
            Solution sol = new Solution();
            Assert.AreEqual(sol.ReverseBetween(CreateListNode(new[] { 1, 2, 3, 4, 5 }), 2, 4).ToString(), "[1,4,3,2,5]"); ;
        }

        [TestMethod()]
        public void ReverseBetweenTest2()
        {
            Solution sol = new Solution();
            Assert.AreEqual(sol.ReverseBetween(CreateListNode(new[] { 3, 5 }), 1, 2).ToString(), "[5,3]"); ;
        }

        [TestMethod()]
        public void ReverseBetweenTest3()
        {
            Solution sol = new Solution();
            Assert.AreEqual(sol.ReverseBetween(CreateListNode(new[] { 1, 2, 3, 4 }), 1, 4).ToString(), "[4,3,2,1]"); ;
        }


        [TestMethod()]
        public void ReverseBetweenTest4()
        {
            Solution sol = new Solution();
            Assert.AreEqual(sol.ReverseBetween(CreateListNode(new[] { 1, 2, 3, 4, 5 }), 2, 5).ToString(), "[1,5,4,3,2]"); ;
        }
    }
}