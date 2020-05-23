using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeTests.Algorithm
{
    public partial class SolutionTests
    {
        [TestMethod()]
        public void FindMedianSortedArrays1()
        {
            Assert.AreEqual(_sol.FindMedianSortedArrays(new[] { 1, 3 }, new[] { 2 }), 2);
        }
        [TestMethod()]
        public void FindMedianSortedArrays2()
        {
            Assert.AreEqual(_sol.FindMedianSortedArrays(new[] { 1, 2 }, new[] { 3, 4 }), 2.5);
        }
    }
}