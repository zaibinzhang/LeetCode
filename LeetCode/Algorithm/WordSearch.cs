using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;

namespace LeetCode.Algorithm
{
    public partial class Solution
    {
        private class Node
        {
            public int X;

            public int Y;

            public char Val;

            public int Dir;//0上,1右,2下,3左

            public Node(int x, int y, char val, int dir)
            {
                X = x;
                Y = y;
                Val = val;
                Dir = dir;
            }
        }


        public bool Exist(char[,] board, string word)
        {
            Stack<Node> stack = new Stack<Node>();
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    if (board[i, j] == word[0])
                    {
                        stack.Push(new Node(i, j, board[i, j], 0));
                        board[i, j] = '.';
                        int n = 1;
                        while (stack.Count != 0)
                        {
                            if (stack.Count == word.Length)
                            {
                                return true;
                            }
                            Node node = stack.Peek();
                            if (node.Dir == 0)
                            {
                                node.Dir = 1;
                                if (node.Y != 0 && board[node.X, node.Y - 1] == word[n])
                                {
                                    stack.Push(new Node(node.X, node.Y - 1, word[n++], 0));
                                    board[node.X, node.Y - 1] = '.';
                                    continue;
                                }
                            }

                            if (node.Dir == 1)
                            {
                                node.Dir = 2;
                                if (node.X != board.GetLength(0) - 1 && board[node.X + 1, node.Y] == word[n])
                                {
                                    stack.Push(new Node(node.X + 1, node.Y, word[n++], 0));
                                    board[node.X + 1, node.Y] = '.';
                                    continue;
                                }
                            }

                            if (node.Dir == 2)
                            {
                                node.Dir = 3;
                                if (node.Y != board.GetLength(1) - 1 && board[node.X, node.Y + 1] == word[n])
                                {
                                    stack.Push(new Node(node.X, node.Y + 1, word[n++], 0));
                                    board[node.X, node.Y + 1] = '.';
                                    continue;
                                }
                            }

                            if (node.Dir == 3)
                            {
                                node.Dir = 4;
                                if (node.X != 0 && board[node.X - 1, node.Y] == word[n])
                                {
                                    stack.Push(new Node(node.X - 1, node.Y, word[n++], 0));
                                    board[node.X - 1, node.Y] = '.';
                                    continue;
                                }
                            }
                            stack.Pop();
                            board[node.X, node.Y] = node.Val;
                            n--;
                        }
                    }
                }
            }
            return false;
        }
    }
}