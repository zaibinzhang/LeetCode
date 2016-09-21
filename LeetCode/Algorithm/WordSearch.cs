using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;

namespace LeetCode.Algorithm
{
    public partial class Solution
    {
        public bool Exist(char[,] board, string word)
        {
            if (string.IsNullOrEmpty(word))
            {
                return true;
            }
            return Exist(board, word, new List<Point>(), new Point(0, 0));
        }

        private bool Exist(char[,] board, string word, List<Point> list, Point p)
        {
            if (p.X < 0 || p.Y < 0 || p.X >= board.GetLength(0) || p.Y >= board.GetLength(1))
            {
                return false;
            }

            if (list.Contains(p))
            {
                return false;
            }

            if (word[0] != board[p.X, p.Y])
            {
                if (list.Count == 0)
                {
                    return Exist(board, word, list, new Point(p.X + 1, p.Y)) ||
                           Exist(board, word, list, new Point(p.X, p.Y + 1));
                }

                return false;
            }

            List<Point> temp = list.ToList();

            temp.Add(p);

            word = word.Remove(0, 1);

            if (word.Length == 0)
            {
                return true;
            }

            return Exist(board, word, temp, new Point(p.X + 1, p.Y)) ||
                   Exist(board, word, temp, new Point(p.X - 1, p.Y)) ||
                   Exist(board, word, temp, new Point(p.X, p.Y + 1)) ||
                   Exist(board, word, temp, new Point(p.X, p.Y - 1));

        }

        private class Point
        {
            public Point(int x, int y)
            {
                X = x;
                Y = y;
            }

            public int X { get; set; }

            public int Y { get; set; }

            public override bool Equals(object obj)
            {
                Point that = obj as Point;
                if (that == null)
                {
                    return false;
                }
                return this.X == that.X && this.Y == that.Y;
            }
        }
    }

    
}