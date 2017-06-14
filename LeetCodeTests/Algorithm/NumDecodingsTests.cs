using LeetCode.Algorithm;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeTests.Algorithm
{

    public partial class SolutionTests
    {
        [TestMethod()]
        public void NumDecodingsTest1()
        {
            Assert.AreEqual(_sol.NumDecodings("12"), 2);
        }

        [TestMethod()]
        public void NumDecodingsTest2()
        {
            Assert.AreEqual(_sol.NumDecodings("123"), 3);
        }

        [TestMethod()]
        public void NumDecodingsTest3()
        {
            Assert.AreEqual(_sol.NumDecodings("10"), 1);
        }

        [TestMethod()]
        public void NumDecodingsTest4()
        {
            Assert.AreEqual(_sol.NumDecodings("230"), 0);
        }

        [TestMethod()]
        public void NumDecodingsTest5()
        {
            Assert.AreEqual(_sol.NumDecodings("17"), 2);
        }

        [TestMethod()]
        public void NumDecodingsTest6()
        {
            Assert.AreEqual(_sol.NumDecodings("19963"), 2);
        }

        [TestMethod()]
        public void NumDecodingsTest7()
        {
            Assert.AreEqual(_sol.NumDecodings("9371597631128776948387197132267188677349946742344217846154932859125134924241649584251978418763151253"), 3981312);
        }
    }
}