/* https://leetcode.com/problems/rotting-oranges/ | Leetcode #994 - Rotting Oranges */

public class Solution
{
    public int OrangesRotting(int[][] grid)
    {
        int rows = grid.Length;
        int cols = grid[0].Length;
        Queue<(int row, int col)> queue = new();
        int freshCount = 0;
        for (int r = 0; r < rows; r++) // Find all rotten oranges and count fresh oranges
        {
            for (int c = 0; c < cols; c++)
            {
                if (grid[r][c] == 2)
                    queue.Enqueue((r, c));
                else if (grid[r][c] == 1)
                    freshCount++;
            }
        }
        if (freshCount == 0) return 0;
        int minutes = 0;
        int[][] directions = {
            new[] { 1, 0 },   // Down
            new[] { -1, 0 },  // Up
            new[] { 0, 1 },   // Right
            new[] { 0, -1 }   // Left
        };
        while (queue.Count > 0 && freshCount > 0)
        {
            int size = queue.Count;
            for (int i = 0; i < size; i++)
            {
                var (row, col) = queue.Dequeue();
                foreach (var direction in directions)
                {
                    int newRow = row + direction[0];
                    int newCol = col + direction[1];
                    if (newRow >= 0 && newCol >= 0 && newRow < rows && newCol < cols && grid[newRow][newCol] == 1)
                    {
                        grid[newRow][newCol] = 2;
                        freshCount--;
                        queue.Enqueue((newRow, newCol));
                    }
                }
            }
            minutes++;
        }
        return freshCount == 0 ? minutes : -1;
    }
}

/*
994. Rotting Oranges

You are given an m x n grid where each cell can have one of three values:

0 representing an empty cell,
1 representing a fresh orange, or
2 representing a rotten orange.
Every minute, any fresh orange that is 4-directionally adjacent to a rotten orange becomes rotten.

Return the minimum number of minutes that must elapse until no cell has a fresh orange. If this is impossible, return -1.

Example 1:

Input: grid = [[2,1,1],[1,1,0],[0,1,1]]
Output: 4
Example 2:

Input: grid = [[2,1,1],[0,1,1],[1,0,1]]
Output: -1
Explanation: The orange in the bottom left corner (row 2, column 0) is never rotten, because rotting only happens 4-directionally.
Example 3:

Input: grid = [[0,2]]
Output: 0
Explanation: Since there are already no fresh oranges at minute 0, the answer is just 0.
 
Constraints:

m == grid.length
n == grid[i].length
1 <= m, n <= 10
grid[i][j] is 0, 1, or 2.

Interview Explanation ~

"This is a Multi-Source BFS problem. We put all initially rotten oranges into the queue, count fresh oranges, and perform level-order BFS where each level represents one minute of rotting.
If all fresh oranges become rotten, return the minutes; otherwise return -1."

*/
