/* https://leetcode.com/problems/kth-largest-element-in-an-array/ | Leetcode #215 - Kth Largest Element in an Array */

public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        PriorityQueue<int,int> heap = new(nums.Length);
        foreach(int i in nums) {
            heap.Enqueue(i,i);
            if(heap.Count > k)
                heap.Dequeue();
        }
        return heap.Peek();
    }
}

/*
215. Kth Largest Element in an Array

Given an integer array nums and an integer k, return the kth largest element in the array.
Note that it is the kth largest element in the sorted order, not the kth distinct element.

Can you solve it without sorting?

Example 1:

Input: nums = [3,2,1,5,6,4], k = 2
Output: 5
Example 2:

Input: nums = [3,2,3,1,2,4,5,5,6], k = 4
Output: 4
 
Constraints:

1 <= k <= nums.length <= 105
-104 <= nums[i] <= 104

Interview Explanation ~

We maintain a Min Heap of size k. As we iterate through the array, we insert each number into the heap. If the heap size exceeds k, we remove the smallest element.
This ensures the heap always contains the k largest elements seen so far. At the end, the root of the Min Heap is the kth largest element.

*/
