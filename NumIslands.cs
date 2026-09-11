/* https://leetcode.com/problems/number-of-islands/ | Leetcode #200 - Number of Islands */

public class Solution
{
    public int NumIslands(char[][] grid)
    {
        int rows = grid.Length;
        int cols = grid[0].Length;
        int islands = 0;
        for (int r = 0; r < rows; r++)
        {
            for (int c = 0; c < cols; c++)
            {
                if (grid[r][c] == '1') // Found a new island
                {
                    islands++;
                    DFS(grid, r, c); // Remove entire island
                }
            }
        }
        return islands;
    }

    private void DFS(char[][] grid, int r, int c)
    {
        int rows = grid.Length;
        int cols = grid[0].Length;
        if (r < 0 || c < 0 || r >= rows || c >= cols) return; // Out of bounds
        if (grid[r][c] == '0') return; // Water or already visited            
        grid[r][c] = '0'; // Mark as visited
        // Explore 4 directions
        DFS(grid, r + 1, c); // Down
        DFS(grid, r - 1, c); // Up
        DFS(grid, r, c + 1); // Right
        DFS(grid, r, c - 1); // Left
    }
}

/*
200. Number of Islands

Given an m x n 2D binary grid grid which represents a map of '1's (land) and '0's (water), return the number of islands.
An island is surrounded by water and is formed by connecting adjacent lands horizontally or vertically. You may assume all four edges of the grid are all surrounded by water.

Example 1:

Input: grid = [
  ["1","1","1","1","0"],
  ["1","1","0","1","0"],
  ["1","1","0","0","0"],
  ["0","0","0","0","0"]
]
Output: 1
Example 2:

Input: grid = [
  ["1","1","0","0","0"],
  ["1","1","0","0","0"],
  ["0","0","1","0","0"],
  ["0","0","0","1","1"]
]
Output: 3

Constraints:

m == grid.length
n == grid[i].length
1 <= m, n <= 300
grid[i][j] is '0' or '1'.

Interview Explanation ~

Treat each land cell as a graph node. Iterate through the grid, and whenever an unvisited land ('1') is encountered, we've found a new island.
Increment the island count and perform DFS/BFS to visit all connected land cells in the four directions. Mark visited cells as water ('0') so they aren't counted again.
Since every cell is visited at most once, the time complexity is O(m × n). This is essentially counting the number of connected components in a grid graph.

*/
