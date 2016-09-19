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
            Console.WriteLine(sol.SimplifyPath("/home/foo/.ssh/../.ssh2/authorized_keys/"));


            Console.ReadKey();
        }
    }
}
