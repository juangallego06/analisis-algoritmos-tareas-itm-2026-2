public class Solution {
    public int NumIslands(char[][] grid) {
       int m = grid.Length, n = grid[0].Length, count = 0;
        int[] dr = { 1, -1, 0, 0 }, dc = { 0, 0, 1, -1 };

        for (int i = 0; i < m; i++)
            for (int j = 0; j < n; j++) {
                if (grid[i][j] != '1') continue;
                count++;
                var stack = new Stack<(int, int)>();
                stack.Push((i, j));
                grid[i][j] = '0';

                while (stack.Count > 0) {
                    var (r, c) = stack.Pop();
                    for (int d = 0; d < 4; d++) {
                        int nr = r + dr[d], nc = c + dc[d];
                        if (nr >= 0 && nr < m && nc >= 0 && nc < n && grid[nr][nc] == '1') {
                            grid[nr][nc] = '0';
                            stack.Push((nr, nc));
                        }
                    }
                }
            }

        return count;
    }
}