using System.Collections.Generic;
using System.Linq;
using LeetCode.Model;

namespace LeetCode.Algorithm
{
    public partial class Solution
    {
        public IList<Interval> Merge(IList<Interval> intervals)
        {
            IList<Interval> list = new List<Interval>();
            intervals = intervals.OrderBy(i => i.start).ToList();
            foreach (Interval interval in intervals)
            {
                if (list.Count > 0 && list[list.Count - 1].end >= interval.start)
                {
                    list[list.Count - 1].end = interval.end;
                }
                else
                {
                    list.Add(interval);
                }
            }
            return list;
        }
    }
}