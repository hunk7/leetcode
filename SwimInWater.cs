/* https://leetcode.com/problems/swim-in-rising-water/ | Leetcode #778 - Swim in Rising Water */

public class Solution {
    public int SwimInWater(int[][] grid) {
        int n = grid.Length; // length of Grid
        var visited = new bool[n, n]; // Created position which is visted
        var pq = new PriorityQueue<(int r, int c), int>(); // (row,col), Priority
        (int dr, int dc)[] dirs = [(-1, 0), (1, 0), (0, -1), (0, 1)]; // Directions to go up dowm left right
        pq.Enqueue((0, 0), grid[0][0]); // Starting Cell Position + Starting cell priority
        visited[0, 0] = true; // Marking Starting cell visited
        while (pq.TryDequeue(out var curr, out int t)) { // Pop cell with lowest required water level t
            if (curr.r == n - 1 && curr.c == n - 1) return t; // Reached bottom-right target, return min time t
            foreach (var (dr, dc) in dirs)  { // Check all 4 adjacent neighbors
                int nr = curr.r + dr, nc = curr.c + dc; // Calculate neighbor row and column coordinates
                if (nr >= 0 && nr < n && nc >= 0 && nc < n && !visited[nr, nc]) { // Check within boundaries and not visited
                    visited[nr, nc] = true; // Mark neighbor visited so it is not processed again
                    pq.Enqueue((nr, nc), Math.Max(t, grid[nr][nc])); // Add neighbor with max of current time and its elevation
                }
            }
        }
        return 0; // Fallback return for empty grid or start already at target
    }
}

/*
778. Swim in Rising Water

You are given an n x n integer matrix grid where each value grid[i][j] represents the elevation at that point (i, j).

It starts raining, and water gradually rises over time. At time t, the water level is t, meaning any cell with elevation less than equal to t is submerged or reachable.

You can swim from a square to another 4-directionally adjacent square if and only if the elevation of both squares individually are at most t
You can swim infinite distances in zero time. Of course, you must stay within the boundaries of the grid during your swim.

Return the minimum time until you can reach the bottom right square (n - 1, n - 1) if you start at the top left square (0, 0).

Example 1:

Input: grid = [[0,2],[1,3]]
Output: 3
Explanation:
At time 0, you are in grid location (0, 0).
You cannot go anywhere else because 4-directionally adjacent neighbors have a higher elevation than t = 0.
You cannot reach point (1, 1) until time 3.
When the depth of water is 3, we can swim anywhere inside the grid.
Example 2:

Input: grid = [[0,1,2,3,4],[24,23,22,21,5],[12,13,14,15,16],[11,17,18,19,20],[10,9,8,7,6]]
Output: 16
Explanation: The final route is shown.
We need to wait until time 16 so that (0, 0) and (4, 4) are connected.

Constraints:

n == grid.length
n == grid[i].length
1 <= n <= 50
0 <= grid[i][j] < n2
Each value grid[i][j] is unique.

Key Idea:
- We need to find a path from (0, 0) to (n - 1, n - 1) such that the maximum 
  elevation (bottleneck) encountered along the path is minimized.
- Swimming is instantaneous, so time t corresponds to the water level.
- Moving to a neighbor cell (nr, nc) requires waiting until:
    candidateTime = Math.Max(currentTime, grid[nr][nc])
- A Min-Heap (PriorityQueue) guarantees that we always expand the cell with the 
  globally lowest bottleneck time. The first time (n - 1, n - 1) is popped, 
  its time is guaranteed to be optimal.

Complexity:
- Time Complexity:  O(n^2 * log(n)) -> Every cell is pushed/popped at most once;
                    each heap operation takes O(log(n^2)) = O(log(n)).
- Space Complexity: O(n^2) -> Boolean matrix for visited tracking and priority queue.

Complete Dry Run: Example

Input:
  grid = [
    [0,  2, 4],
    [3, 10, 5],
    [1,  1, 1]
  ]
  n = 3, Target = (2, 2)

Initial State:
  visited[0, 0] = true (all others false)
  PQ: [ ((0, 0), priority: 0) ]

Iteration 1:
  - Dequeue: curr = (0, 0), t = 0
  - Neighbors of (0, 0):
      * Down  (1, 0): unvisited -> priority = Math.Max(0, grid[1][0]=3)  = 3
        visited[1, 0] = true; PQ.Enqueue((1, 0), 3)
      * Right (0, 1): unvisited -> priority = Math.Max(0, grid[0][1]=2)  = 2
        visited[0, 1] = true; PQ.Enqueue((0, 1), 2)
  - PQ State: [ ((0, 1), 2), ((1, 0), 3) ]

Iteration 2:
  - Dequeue: curr = (0, 1), t = 2  (lowest priority in heap)
  - Neighbors of (0, 1):
      * Left  (0, 0): visited -> skip
      * Right (0, 2): unvisited -> priority = Math.Max(2, grid[0][2]=4)  = 4
        visited[0, 2] = true; PQ.Enqueue((0, 2), 4)
      * Down  (1, 1): unvisited -> priority = Math.Max(2, grid[1][1]=10) = 10
        visited[1, 1] = true; PQ.Enqueue((1, 1), 10)
  - PQ State: [ ((1, 0), 3), ((0, 2), 4), ((1, 1), 10) ]

Iteration 3:
  - Dequeue: curr = (1, 0), t = 3  (3 < 4 < 10)
  - Neighbors of (1, 0):
      * Up    (0, 0): visited -> skip
      * Right (1, 1): visited -> skip
      * Down  (2, 0): unvisited -> priority = Math.Max(3, grid[2][0]=1)  = 3
        visited[2, 0] = true; PQ.Enqueue((2, 0), 3)
  - PQ State: [ ((2, 0), 3), ((0, 2), 4), ((1, 1), 10) ]

Iteration 4:
  - Dequeue: curr = (2, 0), t = 3
  - Neighbors of (2, 0):
      * Up    (1, 0): visited -> skip
      * Right (2, 1): unvisited -> priority = Math.Max(3, grid[2][1]=1)  = 3
        visited[2, 1] = true; PQ.Enqueue((2, 1), 3)
  - PQ State: [ ((2, 1), 3), ((0, 2), 4), ((1, 1), 10) ]

Iteration 5:
  - Dequeue: curr = (2, 1), t = 3
  - Neighbors of (2, 1):
      * Left  (2, 0): visited -> skip
      * Up    (1, 1): visited -> skip
      * Right (2, 2): unvisited -> priority = Math.Max(3, grid[2][2]=1)  = 3
        visited[2, 2] = true; PQ.Enqueue((2, 2), 3)
  - PQ State: [ ((2, 2), 3), ((0, 2), 4), ((1, 1), 10) ]

Iteration 6:
  - Dequeue: curr = (2, 2), t = 3
  - Check: curr.r == 2 && curr.c == 2 -> Target reached!
  - Return: 3

Path Taken: (0, 0) -> (1, 0) -> (2, 0) -> (2, 1) -> (2, 2)
Bottleneck Elevations: [0, 3, 1, 1, 1] => Max is 3

*/
