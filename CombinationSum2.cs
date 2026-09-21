/* https://leetcode.com/problems/combination-sum-ii/ | Leetcode #40 - Combination Sum II */

/*
 * COMBINATION SUM II - OPTIMIZED BACKTRACKING TREE
 * Input: [10,1,2,7,6,1,5] -> Sorted: [1, 1, 2, 5, 6, 7, 10], Target: 8
 * Node Format: (Remaining Target)
 * 
 *                                        (8)
 *                /                /             |           |       \   \   \
 *              [1]          [1](SKIP)          [2]         [5]      [6] [7] [10]
 *             (7)         Duplicate of 1       (6)         (3)      (2) (1) (BREAK)
 *         /  /  |  \  \                      /  |  \      /   \      |   |
 *       [1][2] [5] [6][7]                  [5] [6] [7]  [6]   [7]   [7] [10]
 *      (6)(5) (2) (1)(0)*                  (1) (0)* (BRK)(BRK) (BRK)(BRK)(BRK)
 *     / |  |    |    SUCCESS                |  SUCCESS
 *   [2][5][6]  [5]                         [6]
 *  (4)(1)(0)*  (0)*                       (BRK)
 *   |  | SUCCESS SUCCESS
 *  [5][6]
 *(BRK)(BRK) 
 * 
 * LEGEND:
 * - [X]: The candidate number chosen inside the for-loop.
 * - (Y): The remaining target after choosing X.
 * - *: SUCCESS! A valid combination is found (remaining target == 0).
 * - (SKIP): Loop 'continue' executed because candidates[i] == candidates[i-1].
 * - (BRK): Loop 'break' executed because candidates[i] > remaining target.
 **/

public class Solution 
{
    public IList<IList<int>> CombinationSum2(int[] candidates, int target) {
        var results = new List<IList<int>>();        
        Array.Sort(candidates);         
        Backtrack(0, target, candidates, new List<int>(), results); // call recursive Function
        return results;
    }
    private void Backtrack(int startIndex, int target, int[] candidates, List<int> currentPath, IList<IList<int>> results)  {
        if (target == 0) {  // Found target so Adding list on result
            results.Add(new List<int>(currentPath));
            return;
        }                
        for (int i = startIndex; i < candidates.Length; i++)  {      
            if (candidates[i] > target) break; // if the current element is greater than the remaining target, stop the loop entirely.
            if (i > startIndex && candidates[i] == candidates[i - 1]) continue;  // SKIP DUPLICATES
            currentPath.Add(candidates[i]); // Choose            
            Backtrack(i + 1, target - candidates[i], candidates, currentPath, results); // Recurse:'i + 1' So, element can only be used ONCE
            currentPath.RemoveAt(currentPath.Count - 1); // Un-choose (Backtrack)
        }
    }
}

/*
40. Combination Sum II

Given a collection of candidate numbers (candidates) and a target number (target), find all unique combinations in candidates where the candidate numbers sum to target.

Each number in candidates may only be used once in the combination.
Note: The solution set must not contain duplicate combinations.

Example 1:

Input: candidates = [10,1,2,7,6,1,5], target = 8
Output: 
[
[1,1,6],
[1,2,5],
[1,7],
[2,6]
]
Example 2:

Input: candidates = [2,5,2,1,2], target = 5
Output: 
[
[1,2,2],
[5]
]
 
Constraints:

1 <= candidates.length <= 100
1 <= candidates[i] <= 50
1 <= target <= 30

Interview Explanation ~

To solve this problem, I used an optimized, loop-based backtracking approach to systematically explore all valid combinations while aggressively pruning the decision tree.
I begin by sorting the input array, which is crucial for two main optimizations. First, sorting groups duplicate numbers together, allowing me to skip identical elements
at the same recursive depth to prevent duplicate combinations in the final result. Second, it enables early stopping: inside the recursive loop, if the current number is
greater than the remaining target, I immediately break out of the loop because all subsequent numbers will also be too large. When a candidate is valid, I add it to the current path,
reduce the target, and recurse using the next index to ensure each element is used at most once. The algorithm cleanly backtracks by removing the last element to test the next branch,
capturing a deep copy of the path whenever the target hits exactly zero.

* **Time Complexity:** $O(2^N)$ (where $N$ is the number of candidates). In the absolute worst-case scenario without duplicates, each element is either included or excluded,
creating a binary decision tree of depth $N$. However, sorting and the early-stopping `break` condition drastically prune the tree, making it run significantly faster in practice.

* **Space Complexity:** $O(N)$ for the recursion call stack and the temporary working list. In the worst case, the maximum depth of the recursive tree will equal the length
of the candidates array.

*/
