public class Solution {
    public int EraseOverlapIntervals(int[][] intervals) {
        Array.Sort(intervals, (a, b) => a[1].CompareTo(b[1]));
        int removed = 0, end = int.MinValue;

        foreach (var cur in intervals) {
            if (cur[0] >= end) end = cur[1];
            else removed++;
        }

        return removed;  
    }
}