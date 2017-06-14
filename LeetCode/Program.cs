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

            var list = sol.GenerateTrees(3);
            Console.WriteLine(list);
            

            Console.ReadKey();
        }
    }
}
