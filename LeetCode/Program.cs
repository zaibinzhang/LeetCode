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
//            ["CAA","AAA","BCD"]
//"AAB"
            char[,] board = new char[,]
            {
                {'C', 'A', 'A'},
                {'A', 'A', 'A'},
                {'B', 'C', 'D'}
            };

            Console.WriteLine(sol.Exist(board, "AAB"));

            Console.ReadKey();
        }
    }
}
