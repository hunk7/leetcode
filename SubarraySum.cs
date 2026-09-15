/* https://leetcode.com/problems/subarray-sum-equals-k/ | Leetcode #560 - Subarray Sum Equals K */

public class Solution
{
    public int SubarraySum(int[] nums, int k)
    {
        // Input: nums = [1,1,1] | k = 2
        Dictionary<int, int> map = new(); // prefixSum -> frequency
        map[0] = 1; // {0:1} => empty prefix before processing any elements
        int sum = 0;
        int count = 0;
        foreach (int num in nums)
        {
            sum += num; // Iter1: sum=1, Iter2: sum=2, Iter3: sum=3
            if (map.ContainsKey(sum - k))
                count += map[sum - k];
                // Iter1: 1-2=-1 -> not found -> count=0
                // Iter2: 2-2=0  -> map[0]=1 -> count=1
                // Iter3: 3-2=1  -> map[1]=1 -> count=2
            if (map.ContainsKey(sum))
                map[sum]++; // Increase frequency if prefix sum already exists
            else
                map[sum] = 1; // Add new prefix sum
            // Map after each iteration:
            // Iter1: {0:1, 1:1}
            // Iter2: {0:1, 1:1, 2:1}
            // Iter3: {0:1, 1:1, 2:1, 3:1}
        }
        return count; // 2
    }
}

/*
560. Subarray Sum Equals K

Given an array of integers nums and an integer k, return the total number of subarrays whose sum equals to k.
A subarray is a contiguous non-empty sequence of elements within an array.

Example 1:

Input: nums = [1,1,1], k = 2
Output: 2
Example 2:

Input: nums = [1,2,3], k = 3
Output: 2

Constraints:

1 <= nums.length <= 2 * 104
-1000 <= nums[i] <= 1000
-107 <= k <= 107

Interview Explanation ~

Maintain a running prefixSum.
If a previous prefix sum equals prefixSum - k, then the subarray between them sums to k.
Store frequencies of all previously seen prefix sums in a dictionary.
Add the frequency of (prefixSum - k) to the answer.
Update the current prefix sum frequency.

*/
