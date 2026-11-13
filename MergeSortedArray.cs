/* https://leetcode.com/problems/merge-sorted-array/ | Leetcode #88 - Merge Sorted Array */

public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        Array.Copy(nums2, 0, nums1, m, n);
        Array.Sort(nums1, 0, m + n);
    }
}

/*
Step-by-Step Breakdown ~

1. Array.Copy(nums2, 0, nums1, m, n);

This line copies all valid elements from nums2 into the trailing placeholder slots (0s) of nums1:
• nums2: The source array we are copying from.
• 0: Start copying from index 0 of nums2.
• nums1: The destination array we are copying into.
• m: Start pasting at index m of nums1 (right after its first m valid elements).
• n: Copy exactly n elements.
Example state after line 1:
• nums1 starts as [1, 2, 3, 0, 0, 0] (m = 3)
• nums2 is [2, 5, 6] (n = 3)
• After Array.Copy, nums1 becomes [1, 2, 3, 2, 5, 6].

2. Array.Sort(nums1, 0, m + n);

Now that all numbers are inside nums1 (though out of order), this line sorts them in-place:
• nums1: The array to sort.
• 0: Start sorting at index 0.
• m + n: Sort a total of m + n elements (the entire combined length).
Example state after line 2:
• nums1 is sorted in-place into [1, 2, 2, 3, 5, 6].


88. Merge Sorted Array

You are given two integer arrays nums1 and nums2, sorted in non-decreasing order, and two integers m and n, representing the number of elements in nums1 and nums2 respectively.
Merge nums1 and nums2 into a single array sorted in non-decreasing order.

The final sorted array should not be returned by the function, but instead be stored inside the array nums1. To accommodate this, nums1 has a length of m + n,
where the first m elements denote the elements that should be merged, and the last n elements are set to 0 and should be ignored. nums2 has a length of n.

 
Example 1:

Input: nums1 = [1,2,3,0,0,0], m = 3, nums2 = [2,5,6], n = 3
Output: [1,2,2,3,5,6]
Explanation: The arrays we are merging are [1,2,3] and [2,5,6].
The result of the merge is [1,2,2,3,5,6] with the underlined elements coming from nums1.
Example 2:

Input: nums1 = [1], m = 1, nums2 = [], n = 0
Output: [1]
Explanation: The arrays we are merging are [1] and [].
The result of the merge is [1].
Example 3:

Input: nums1 = [0], m = 0, nums2 = [1], n = 1
Output: [1]
Explanation: The arrays we are merging are [] and [1].
The result of the merge is [1].
Note that because m = 0, there are no elements in nums1. The 0 is only there to ensure the merge result can fit in nums1.
 

Constraints:

nums1.length == m + n
nums2.length == n
0 <= m, n <= 200
1 <= m + n <= 200
-109 <= nums1[i], nums2[j] <= 109
 

Follow up: Can you come up with an algorithm that runs in O(m + n) time?

*/
