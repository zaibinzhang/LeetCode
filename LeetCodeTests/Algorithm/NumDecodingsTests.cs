using LeetCode.Algorithm;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeTests.Algorithm
{
    [TestClass()]
    public partial class SolutionTests
    {
        [TestMethod()]
        public void NumDecodingsTest()
        {
            Solution sol = new Solution();
            Assert.AreEqual(sol.NumDecodings("12"), 2);
        }
    }
}