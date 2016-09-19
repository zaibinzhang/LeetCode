using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Algorithm
{
    public partial class Solution
    {
        /// <summary>
        /// url:https://leetcode.com/problems/simplify-path/
        /// Given an absolute path for a file (Unix-style), simplify it.
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public string SimplifyPath(string path)
        {
            if (string.IsNullOrEmpty(path))
            {
                return "/";
            }
            string[] paths = path.Split('/');
            if (paths.Length < 2)
            {
                return "/";
            }
            Stack<string> stack = new Stack<string>();
            for (int i = 0; i < paths.Length; i++)
            {
                if (paths[i] == "" || paths[i] == ".")
                {
                    continue;
                }

                if (paths[i] == "..")
                {
                    if (stack.Count != 0)
                    {
                        stack.Pop();
                    }
                    continue;
                }

                stack.Push(paths[i]);
            }

            string ret = "";
            while (stack.Count != 0)
            {
                ret = $"/{stack.Pop()}{ret}";
            }
            return ret == "" ? "/" : ret;
        }
    }
}