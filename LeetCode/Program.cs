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

            Console.WriteLine(sol.RemoveDuplicates(new[] { 1, 1, 1, 2, 2, 3 }));

            Console.ReadKey();
        }
    }
}
