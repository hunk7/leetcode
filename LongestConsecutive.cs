/* https://leetcode.com/problems/longest-consecutive-sequence/ | Leetcode #128 - Longest Consecutive Sequence */

public class Solution
{
    public int LongestConsecutive(int[] nums)
    {
        HashSet<int> set = new(nums);
        int longestSequence = 0;
        foreach (int i in set)
        {
            bool hasPreviousNumber = set.Contains(i - 1);
            if (hasPreviousNumber == false)
            {
                int currentNum = i;
                int currentLength = 1;
                while (set.Contains(currentNum + 1))
                {
                    currentNum++;
                    currentLength++;
                }
                longestSequence = Math.Max(longestSequence, currentLength);
            }
        }
        return longestSequence;
    }
}

/*
128. Longest Consecutive Sequence

Given an unsorted array of integers nums, return the length of the longest consecutive elements sequence.

You must write an algorithm that runs in O(n) time.

Example 1:

Input: nums = [100,4,200,1,3,2]
Output: 4
Explanation: The longest consecutive elements sequence is [1, 2, 3, 4]. Therefore its length is 4.
Example 2:

Input: nums = [0,3,7,2,5,8,4,6,0,1]
Output: 9
Example 3:

Input: nums = [1,0,1,2]
Output: 3
 
Constraints:

0 <= nums.length <= 105
-109 <= nums[i] <= 109

Interview Explanation

"I use a HashSet for O(1) lookups. For each number, I first check whether it is the start of a sequence by verifying that num - 1 is not present in the set.
If it is a starting point, I extend the sequence using a while loop and count its length. I keep track of the maximum sequence length encountered.
Since every number is processed at most once, the overall time complexity is O(n) and space complexity is O(n)."

*/
