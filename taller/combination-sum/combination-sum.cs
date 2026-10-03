public class Solution {
    public IList<IList<int>> CombinationSum(int[] candidates, int target) {
        var res = new List<IList<int>>();
        Backtrack(candidates, target, 0, new List<int>(), res);
        return res;
    }

    void Backtrack(int[] c, int remain, int start, List<int> path, List<IList<int>> res) {
        if (remain == 0) { res.Add(new List<int>(path)); return; }

        for (int i = start; i < c.Length; i++) {
            if (c[i] > remain) continue;
            path.Add(c[i]);
            Backtrack(c, remain - c[i], i, path, res);
            path.RemoveAt(path.Count - 1);
        }
    }
}