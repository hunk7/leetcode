/* https://leetcode.com/problems/two-sum/  |  LeetCode #1 — Two Sum */

public class Solution {
    public int[] TwoSum(int[] nums, int target){ 
    Dictionary<int, int> map = new(nums.Length);
        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];
            if (map.TryGetValue(complement, out int index))
            { 
                return new[] { index, i };
            } map[nums[i]] = i;
        } return Array.Empty<int>();
    }
}


/*  
1. Two Sum ~ leetcode

Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
You may assume that each input would have exactly one solution, and you may not use the same element twice.
You can return the answer in any order.

Example 1:

Input: nums = [2,7,11,15], target = 9
Output: [0,1]
Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
Example 2:

Input: nums = [3,2,4], target = 6
Output: [1,2]
Example 3:

Input: nums = [3,3], target = 6
Output: [0,1]

Constraints:

2 <= nums.length <= 104
-109 <= nums[i] <= 109
-109 <= target <= 109
Only one valid answer exists.
 
Follow-up: Can you come up with an algorithm that is less than O(n2) time complexity?

Interview Answer
If asked:

Can you optimize further?

Answer:

No algorithm can improve the asymptotic time complexity beyond O(n) because every element must potentially be examined.
The current hash table solution is already optimal with O(n) time and O(n) space.
Minor implementation optimizations include pre-sizing the Dictionary and using TryGetValue to avoid double lookups,
but the overall complexity remains the same.

Interview Answer
If asked:

what is the space and time complexity?

We iterate through the array once, and each Dictionary lookup and insertion is O(1) on average. Therefore, the overall time complexity is O(n).
The Dictionary may store up to n elements, so the space complexity is O(n).
This is the optimal solution for the unsorted Two Sum problem because every element may need to be examined at least once.

*/
