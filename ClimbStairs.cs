/* https://leetcode.com/problems/climbing-stairs/ | Leetcode #70 - Climbing Stairs */

public class Solution
{
    public int ClimbStairs(int n)
    {
        if (n <= 2) return n;
        int prev2 = 1, prev1 = 2;
        for (int i = 3; i <= n; i++)
        {
            int current = prev1 + prev2;
            prev2 = prev1;
            prev1 = current;
        }
        return prev1;
    }
}

/*
70. Climbing Stairs

You are climbing a staircase. It takes n steps to reach the top.
Each time you can either climb 1 or 2 steps. In how many distinct ways can you climb to the top?

Example 1:

Input: n = 2
Output: 2
Explanation: There are two ways to climb to the top.
1. 1 step + 1 step
2. 2 steps
Example 2:

Input: n = 3
Output: 3
Explanation: There are three ways to climb to the top.
1. 1 step + 1 step + 1 step
2. 1 step + 2 steps
3. 2 steps + 1 step

Constraints:

1 <= n <= 45

Interview Explanation ~

To reach stair n, the last move must have come either from stair n-1 (taking 1 step) or stair n-2 (taking 2 steps). Since these are the only possibilities,
the total number of ways to reach stair n is the sum of the ways to reach n-1 and n-2. This gives the recurrence dp[n] = dp[n-1] + dp[n-2].
Since each state depends only on the previous two states, we can optimize the DP solution to O(1) space.

*/
