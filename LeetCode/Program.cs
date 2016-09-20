using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode.Algorithm;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution sol = new Solution();
            var ret = sol.Subsets(new[] { 1, 2, 3 });
            Console.WriteLine(ret);
            Console.ReadKey();
        }
    }
}
