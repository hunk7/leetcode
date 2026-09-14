/* https://leetcode.com/problems/longest-increasing-subsequence/ | Leetcode #300 - Longest Increasing Subsequence */

public class Solution
{
    public int LengthOfLIS(int[] nums)
    {
        List<int> tails = new(nums.Length);
        foreach (int num in nums)
        {
            int left = 0;
            int right = tails.Count;
            while (left < right)
            {
                int mid = left + (right - left) / 2;
                if (tails[mid] < num)
                    left = mid + 1;
                else
                    right = mid;
            }
            if (left == tails.Count)
                tails.Add(num);
            else
                tails[left] = num;
        }
        return tails.Count;
    }
}


/*
300. Longest Increasing Subsequence

Given an integer array nums, return the length of the longest strictly increasing subsequence.

Example 1:

Input: nums = [10,9,2,5,3,7,101,18]
Output: 4
Explanation: The longest increasing subsequence is [2,3,7,101], therefore the length is 4.
Example 2:

Input: nums = [0,1,0,3,2,3]
Output: 4
Example 3:

Input: nums = [7,7,7,7,7,7,7]
Output: 1
 
Constraints:

1 <= nums.length <= 2500
-104 <= nums[i] <= 104
 
Follow up: Can you come up with an algorithm that runs in O(n log(n)) time complexity?

Interview Answer ~

"I maintain a tails array where tails[i] stores the smallest possible ending value of an increasing subsequence of length i+1. For each number,
I use binary search to find its position in tails, replacing an existing tail or appending it if it's larger than all tails. This keeps the tails optimal and yields an O(n log n) solution."

*/
