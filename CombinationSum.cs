/* https://leetcode.com/problems/combination-sum/ | Leetcode #39 - Combination Sum */

/* 
 * COMBINATION SUM #39 - INCLUDE/EXCLUDE DECISION TREE
 * Input: Candidates = [2, 3], Target = 6
 * Node Format: (Remaining Target, Index) -> e.g., (R:6, i:0)
 * 
 *                                  (R:6, i:0)
 *                                 /          \
 *                         [+2]  /              \  [Skip 2]
 *                             /                  \
 *                       (R:4, i:0)             (R:6, i:1)
 *                       /        \              /        \
 *               [+2]  /            \          / [+3]       \  [Skip 3]
 *                   /      [Skip 2]  \      /                \
 *             (R:2, i:0)           (R:4, i:1)   (R:3, i:1)     (R:6, i:2)
 *             /        \           /      \       /      \       [DEAD END]
 *     [+2]  /   [Skip 2] \   [+3] / [Skip] \ [+3]/ [Skip] \
 *         /                \    /            \ /            \
 *    (R:0, i:0)        (R:2, i:1)           (R:0, i:1)    (R:3, i:2)
 *    [SUCCESS!]        /        \           [SUCCESS!]    [DEAD END]
 *   Path: [2,2,2] [+3]/          \[Skip 3]  Path: [3,3]
 *                   /              \
 *             (R:-1, i:1)      (R:2, i:2)
 *             [DEAD END]       [DEAD END]
 *
 * LEGEND:
 * - [+X]: Include candidate (Remaining Target decreases, Index stays same)
 * - [Skip X]: Exclude candidate (Remaining Target stays same, Index + 1)
 * - SUCCESS: Remaining target hit 0 exactly.
 * - DEAD END: Target went below 0, or index ran out of bounds.
 **/

public class Solution {
    public IList<IList<int>> CombinationSum(int[] candidates, int target) {
        IList<IList<int>> result = new List<IList<int>>();
        List<int> currentPath = new();
        Backtrack(0, target, candidates, currentPath, result); // calling recursive function
        return result;
    }
    private void Backtrack(int index,int target,int[] candidates,List<int> currentPath, IList<IList<int>> result) {
        if(target == 0) { // path == sum so found the right combination
            result.Add(new List<int>(currentPath)); // Adding the base case result with the currentPath which matched
            return;
        }
        if(target < 0 || index == candidates.Length) return; // Handling Dead Ends
        currentPath.Add(candidates[index]); // 
        Backtrack(index, target - candidates[index], candidates, currentPath, result); // recursive target calculation
        currentPath.RemoveAt(currentPath.Count - 1); // Backtrack to Previous Index
        Backtrack(index + 1, target, candidates, currentPath, result); // Move one Index Ahead
    }
}

/*
39. Combination Sum

Given an array of distinct integers candidates and a target integer target, return a list of all unique combinations of candidates where the chosen numbers sum to target. 
You may return the combinations in any order.
The same number may be chosen from candidates an unlimited number of times. Two combinations are unique if the frequency of at least one of the chosen numbers is different.
The test cases are generated such that the number of unique combinations that sum up to target is less than 150 combinations for the given input.

Example 1:

Input: candidates = [2,3,6,7], target = 7
Output: [[2,2,3],[7]]
Explanation:
2 and 3 are candidates, and 2 + 2 + 3 = 7. Note that 2 can be used multiple times.
7 is a candidate, and 7 = 7.
These are the only two combinations.
Example 2:

Input: candidates = [2,3,5], target = 8
Output: [[2,2,2,2],[2,3,3],[3,5]]
Example 3:

Input: candidates = [2], target = 1
Output: []
 
Constraints:

1 <= candidates.length <= 30
2 <= candidates[i] <= 40
All elements of candidates are distinct.
1 <= target <= 40

Interview Explanation ~

I chose a backtracking approach because the problem requires generating all exhaustive valid combinations, and backtracking allows us to systematically explore the entire decision space
while efficiently pruning invalid paths early. Specifically, I utilized an include/exclude recursive pattern because it elegantly handles the requirement that elements can be reused
an unlimited number of times. To solve this, I maintain a single shared list to track the current combination and monitor a remaining target value. At every step, the algorithm branches
into two distinct decisions: it either includes the current candidate—subtracting its value from the target but keeping the pointer at the same index to allow for reuse—or it excludes
the candidate entirely and advances the pointer to the next number. The recursion terminates successfully when the remaining target hits exactly zero, at which point I capture a deep copy
of the current path. If the target drops below zero or the index goes out of bounds, I immediately prune that branch. Finally, to keep the algorithm space-efficient, I rely on a
single dynamic list for the state, explicitly backtracking by removing the last added element after exploring the "include" branch so that the "exclude" branch starts with a
perfectly clean historical state.

Time Complexity: O(N^(T/M + 1)), where N is the number of candidates, T is the target, and M is the smallest candidate. The recursion tree can have a depth of T/M,
and each level may branch into up to N choices.

Space Complexity: O(T/M) for the recursion stack and current combination being built. (Result storage not included.)

*/
