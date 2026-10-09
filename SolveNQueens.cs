/* https://leetcode.com/problems/n-queens/ | Leetcode #51 - N-Queens */

public class Solution {
    public IList<IList<string>> SolveNQueens(int n) {
        var result = new List<IList<string>>();
        
        // Initialize the empty board
        var board = new char[n][];
        for (int i = 0; i < n; i++) {
            board[i] = new char[n];
            Array.Fill(board[i], '.');
        }

        // r: current row
        // cols: bitmask of occupied columns
        // diag1: bitmask of occupied main diagonals (r - c)
        // diag2: bitmask of occupied anti-diagonals (r + c)
        void Backtrack(int r, int cols, int diag1, int diag2) {
            if (r == n) {
                var currentSolution = new List<string>(n);
                for (int i = 0; i < n; i++) {
                    currentSolution.Add(new string(board[i]));
                }
                result.Add(currentSolution);
                return;
            }

            for (int c = 0; c < n; c++) {
                // Calculate bit positions for the current square
                int colMask = 1 << c;
                int d1Mask = 1 << (r - c + n); // + n prevents negative bit shifts
                int d2Mask = 1 << (r + c);

                // If the bit is already set (1), the square is under attack
                if ((cols & colMask) != 0 || (diag1 & d1Mask) != 0 || (diag2 & d2Mask) != 0) {
                    continue;
                }

                // Place the queen
                board[r][c] = 'Q';
                
                // Recurse down, combining current masks with the new queen's attack zones
                Backtrack(r + 1, cols | colMask, diag1 | d1Mask, diag2 | d2Mask);
                
                // Backtrack: remove the queen (masks revert automatically via call stack)
                board[r][c] = '.';
            }
        }

        Backtrack(0, 0, 0, 0);
        return result;
    }
}

/*
51. N-Queens

The n-queens puzzle is the problem of placing n queens on an n x n chessboard such that no two queens attack each other.
Given an integer n, return all distinct solutions to the n-queens puzzle. You may return the answer in any order.
Each solution contains a distinct board configuration of the n-queens' placement, where 'Q' and '.' both indicate a queen and an empty space, respectively.

Example 1:

Input: n = 4
Output: [[".Q..","...Q","Q...","..Q."],["..Q.","Q...","...Q",".Q.."]]
Explanation: There exist two distinct solutions to the 4-queens puzzle as shown above
Example 2:

Input: n = 1
Output: [["Q"]]

 *   Solution 1: [".Q..", "...Q", "Q...", "..Q."]
 *
 *         0   1   2   3
 *       ┌───┬───┬───┬───┐
 *     0 │   │ Q │   │   │  -> row 0, col 1
 *       ├───┼───┼───┼───┤
 *     1 │   │   │   │ Q │  -> row 1, col 3
 *       ├───┼───┼───┼───┤
 *     2 │ Q │   │   │   │  -> row 2, col 0
 *       ├───┼───┼───┼───┤
 *     3 │   │   │ Q │   │  -> row 3, col 2
 *       └───┴───┴───┴───┘
 *
 *   Solution 2: ["..Q.", "Q...", "...Q", ".Q.."]
 *
 *         0   1   2   3
 *       ┌───┬───┬───┬───┐
 *     0 │   │   │ Q │   │  -> row 0, col 2
 *       ├───┼───┼───┼───┤
 *     1 │ Q │   │   │   │  -> row 1, col 0
 *       ├───┼───┼───┼───┤
 *     2 │   │   │   │ Q │  -> row 2, col 3
 *       ├───┼───┼───┼───┤
 *     3 │   │ Q │   │   │  -> row 3, col 1
 *       └───┴───┴───┴───┘

Constraints:

1 <= n <= 9

Explanation ~

N-QUEENS (BITMASK BACKTRACKING WALKTHROUGH)

HOW BITMASKS ENCODE OCCUPIED LINES:
  Instead of HashSets, integers act as compact bit arrays (0 = free, 1 = occupied):
    1. Column Mask (cols)   : colMask = 1 << c
    2. Main Diag \ (diag1)  : d1Mask  = 1 << (r - c + n)   [+n avoids negative shift]
    3. Anti Diag / (diag2)  : d2Mask  = 1 << (r + c)

  Safety check : (cols & colMask) == 0 && (diag1 & d1Mask) == 0 && (diag2 & d2Mask) == 0
  Pass state   : cols | colMask, diag1 | d1Mask, diag2 | d2Mask (no manual undo needed!)

--------------------------------------------------------------------------------
TRACING SOLUTION 1 (n = 4, offset = 4):
--------------------------------------------------------------------------------

  [r = 0] Place Q at (0, 1):
        0   1   2   3
      ┌───┬───┬───┬───┐    colMask = 1 << 1          = 0b00010
    0 │ . │ Q │ . │ . │    d1Mask  = 1 << (0 - 1 + 4) = 1 << 3 = 0b01000
      └───┴───┴───┴───┘    d2Mask  = 1 << (0 + 1)     = 1 << 1 = 0b00010

  [r = 1] Try c = 0, 1, 2 (Blocked by masks) -> Place Q at (1, 3):
        0   1   2   3
      ┌───┬───┬───┬───┐    colMask = 1 << 3          = 0b01000
    0 │ . │ Q │ . │ . │    d1Mask  = 1 << (1 - 3 + 4) = 1 << 2 = 0b00100
      ├───┼───┼───┼───┤    d2Mask  = 1 << (1 + 3)     = 1 << 4 = 0b10000
    1 │ . │ . │ . │ Q │
      └───┴───┴───┴───┘    Accumulated: cols=0b01010, d1=0b01100, d2=0b10010

  [r = 2] Try c = 1, 2, 3 (Blocked) -> Place Q at (2, 0):
        0   1   2   3
      ┌───┬───┬───┬───┐    colMask = 1 << 0          = 0b00001
    0 │ . │ Q │ . │ . │    d1Mask  = 1 << (2 - 0 + 4) = 1 << 6 = 0b1000000
      ├───┼───┼───┼───┤    d2Mask  = 1 << (2 + 0)     = 1 << 2 = 0b00100
    1 │ . │ . │ . │ Q │
      ├───┼───┼───┼───┤
    2 │ Q │ . │ . │ . │
      └───┴───┴───┴───┘    Accumulated: cols=0b01011, d1=0b1001100, d2=0b10110

  [r = 3] Only c = 2 passes all bitwise AND tests -> Place Q at (3, 2):
        0   1   2   3
      ┌───┬───┬───┬───┐
    0 │ . │ Q │ . │ . │    -> [".Q..",
      ├───┼───┼───┼───┤       "...Q",
    1 │ . │ . │ . │ Q │       "Q...",
      ├───┼───┼───┼───┤       "..Q."]
    2 │ Q │ . │ . │ . │
      ├───┼───┼───┼───┤
    3 │ . │ . │ Q │ . │    -> Base case reached (r == 4), snapshot added!
      └───┴───┴───┴───┘

--------------------------------------------------------------------------------
COMPLEXITY:
  Time  : O(N!) - Bitwise tests run in O(1) time per cell.
  Space : O(N)  - O(N) stack frames; bit integers pass by value (no heap sets).

*/
