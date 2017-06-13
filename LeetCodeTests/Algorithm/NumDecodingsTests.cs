using LeetCode.Algorithm;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeTests.Algorithm
{
    [TestClass()]
    public partial class SolutionTests
    {
        [TestMethod()]
        public void NumDecodingsTest1()
        {
            Solution sol = new Solution();
            Assert.AreEqual(sol.NumDecodings("12"), 2);
        }

        [TestMethod()]
        public void NumDecodingsTest2()
        {
            Solution sol = new Solution();
            Assert.AreEqual(sol.NumDecodings("123"), 3);
        }

        [TestMethod()]
        public void NumDecodingsTest3()
        {
            Solution sol = new Solution();
            Assert.AreEqual(sol.NumDecodings("10"), 1);
        }

        [TestMethod()]
        public void NumDecodingsTest4()
        {
            Solution sol = new Solution();
            Assert.AreEqual(sol.NumDecodings("230"), 0);
        }

        [TestMethod()]
        public void NumDecodingsTest5()
        {
            Solution sol = new Solution();
            Assert.AreEqual(sol.NumDecodings("17"), 2);
        }

        [TestMethod()]
        public void NumDecodingsTest6()
        {
            Solution sol = new Solution();
            Assert.AreEqual(sol.NumDecodings("19963"), 2);
        }

        [TestMethod()]
        public void NumDecodingsTest7()
        {
            Solution sol = new Solution();
            Assert.AreEqual(sol.NumDecodings("9371597631128776948387197132267188677349946742344217846154932859125134924241649584251978418763151253"), 3981312);
        }
    }
}