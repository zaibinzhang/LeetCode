using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using LeetCode.Algorithm;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeTests.Algorithm
{
    public partial class SolutionTests
    {
        [TestMethod()]
        public void RestoreIpAddressesTest1()
        {
            Assert.IsTrue(TestHelper.CompareListByOrder(_sol.RestoreIpAddresses("25525511135"), new List<string>() { "255.255.11.135", "255.255.111.35" }));
        }

        [TestMethod()]
        public void RestoreIpAddressesTest2()
        {
            Assert.IsTrue(TestHelper.CompareListByOrder(_sol.RestoreIpAddresses("010010"), new List<string>() { "0.10.0.10", "0.100.1.0" }));
        }
    }
}