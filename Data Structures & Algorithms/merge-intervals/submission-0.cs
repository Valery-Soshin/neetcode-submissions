public class Solution {
    public int[][] Merge(int[][] intervals) {
        if (intervals.Length <= 1){
            return intervals;
        }
        
        Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));

        var resultIntervals = new List<int[]>();

        var p1 = 0;
        var p2 = 1;

        var minPoint = intervals[0][0];
        var maxPoint = intervals[0][1];

        while (p2 < intervals.Length)
        {
            if (Math.Min(maxPoint, intervals[p2][1]) >= Math.Max(minPoint, intervals[p2][0]))
            {
                maxPoint = Math.Max(maxPoint, intervals[p2][1]);

                p2++;

                if (p2 == intervals.Length)
                {
                    resultIntervals.Add([minPoint, maxPoint]);
                }
            }
            else
            {
                resultIntervals.Add([minPoint, maxPoint]);

                minPoint = intervals[p2][0];
                maxPoint = intervals[p2][1];

                if ((p2 + 1) == intervals.Length)
                {
                    resultIntervals.Add([intervals[p2][0], intervals[p2][1]]);
                }

                p1 = p2;
                p2++;
            }
        }

        return resultIntervals.ToArray();
    }
}
