using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeTests.Algorithm
{
    public partial class SolutionTests
    {
        [TestMethod()]
        public void BuildTreeTest1()
        {
            Assert.AreEqual(_sol.BuildTree(new[] { 1, 2 }, new[] { 2, 1 }).ToString(), "1,2");
        }
    }
}