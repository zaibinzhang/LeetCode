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
        private bool CompareList<T>(IList<T> thisList, IList<T> thatList) where T : IComparable
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

        [TestMethod()]
        public void RestoreIpAddressesTest1()
        {
            Solution sol = new Solution();
            Assert.IsTrue(CompareList(sol.RestoreIpAddresses("25525511135"), new List<string>() { "255.255.11.135", "255.255.111.35" }));
        }

        [TestMethod()]
        public void RestoreIpAddressesTest2()
        {
            Solution sol = new Solution();
            Assert.IsTrue(CompareList(sol.RestoreIpAddresses("010010"), new List<string>() { "0.10.0.10", "0.100.1.0" }));
        }
    }
}