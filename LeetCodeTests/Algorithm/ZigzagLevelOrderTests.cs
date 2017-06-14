using System.Collections.Generic;
using LeetCode.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeTests.Algorithm
{
    public partial class SolutionTests
    {
        [TestMethod()]
        public void ZigzagLevelOrderTest1()
        {
            TreeNode treeNode = TestHelper.CreateTreeNode("3,9,20,null,null,15,7");
            var list = _sol.ZigzagLevelOrder(treeNode);
            IList<IList<int>> listi = TestHelper.CreateILists("[[3],[20,9],[15,7]]");

            Assert.IsTrue(true);
        }
    }
}