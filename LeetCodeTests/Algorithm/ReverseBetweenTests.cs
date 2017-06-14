using LeetCode.Algorithm;
using LeetCode.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeTests.Algorithm
{
    public partial class SolutionTests
    {
        [TestMethod()]
        public void ReverseBetweenTest1()
        {
            Assert.AreEqual(_sol.ReverseBetween(TestHelper.CreateListNode(new[] { 1, 2, 3, 4, 5 }), 2, 4).ToString(), "[1,4,3,2,5]"); ;
        }

        [TestMethod()]
        public void ReverseBetweenTest2()
        {
            Assert.AreEqual(_sol.ReverseBetween(TestHelper.CreateListNode(new[] { 3, 5 }), 1, 2).ToString(), "[5,3]"); ;
        }

        [TestMethod()]
        public void ReverseBetweenTest3()
        {
            Assert.AreEqual(_sol.ReverseBetween(TestHelper.CreateListNode(new[] { 1, 2, 3, 4 }), 1, 4).ToString(), "[4,3,2,1]"); ;
        }

        [TestMethod()]
        public void ReverseBetweenTest4()
        {
            Assert.AreEqual(_sol.ReverseBetween(TestHelper.CreateListNode(new[] { 1, 2, 3, 4, 5 }), 2, 5).ToString(), "[1,5,4,3,2]"); ;
        }
    }
}