/* https://leetcode.com/problems/maximum-subarray/ | Leetcode #53 - Maximum Subarray */

public class Solution
{
    public int MaxSubArray(int[] nums)
    {
        int currentSum = nums[0];
        int maxSum = nums[0];
        for (int i = 1; i < nums.Length; i++) {
            currentSum = Math.Max(nums[i], currentSum + nums[i]);
            maxSum = Math.Max(maxSum, currentSum);
        }
        return maxSum;
    }
}

/*
53. Maximum Subarray
Solved
Medium
Topics
premium lock icon
Companies
Given an integer array nums, find the subarray with the largest sum, and return its sum.

 

Example 1:

Input: nums = [-2,1,-3,4,-1,2,1,-5,4]
Output: 6
Explanation: The subarray [4,-1,2,1] has the largest sum 6.
Example 2:

Input: nums = [1]
Output: 1
Explanation: The subarray [1] has the largest sum 1.
Example 3:

Input: nums = [5,4,-1,7,8]
Output: 23
Explanation: The subarray [5,4,-1,7,8] has the largest sum 23.
 

Constraints:

1 <= nums.length <= 105
-104 <= nums[i] <= 104
 

Follow up: If you have figured out the O(n) solution, try coding another solution using the divide and conquer approach, which is more subtle.

So:

Time: O(n)
Space: O(1)
Pattern to remember for interviews

For problems asking:

"Maximum/Minimum contiguous subarray"

Think:

C#
current = Math.Max(nums[i], current + nums[i]);
answer = Math.Max(answer, current);
 

This is the Kadane pattern.

*/
