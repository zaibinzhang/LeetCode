using System.Collections.Generic;
using LeetCode.Algorithm;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeTests.Algorithm
{
    public partial class SolutionTests
    {
        private bool CompareList<T>(IList<T> thisList, IList<T> thatList)
        {
            foreach (T t in thatList)
            {
                if (!thisList.Contains(t))
                {
                    return false;
                }
                thisList.Remove(t);
            }
            if (thisList.Count>0)
            {
                return false;
            }
            return true;
        }

        [TestMethod()]
        public void RestoreIpAddressesTest1()
        {
            Solution sol = new Solution();
            Assert.IsTrue(CompareList(sol.RestoreIpAddresses("25525511135"), new List<string>() { "255.255.11.135", "255.255.111.35" }));
        }
    }
}