public class Solution {
    public int[][] Merge(int[][] intervals) {
        Array.Sort(intervals, (a, b) => a[0] - b[0]);
        var res = new List<int[]>();

        foreach (var cur in intervals) {
            if (res.Count == 0 || res[^1][1] < cur[0])
                res.Add(cur);
            else
                res[^1][1] = Math.Max(res[^1][1], cur[1]);
        }

        return res.ToArray();  
    }
}