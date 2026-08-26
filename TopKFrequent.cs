/* https://leetcode.com/problems/top-k-frequent-elements/ | Leetcode #347 - Top K Frequent Elements */

public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        PriorityQueue<int,int> heap = new(nums.Length);
        Dictionary<int,int> dict = new(nums.Length);
        foreach(int i in nums) {
            if(!dict.ContainsKey(i))
                dict[i] = 0;
            else 
                dict[i]++;
        }
        foreach(var i in dict) {
            int number = i.Key;
            int frequency = i.Value;
            heap.Enqueue(number,frequency);
            if(heap.Count > k)
                heap.Dequeue();
        }
        int[] result = new int[k];
        for(int i = 0; i < k; i++) {
            result[i] = heap.Dequeue();
        }
        return result;
    }
}

/*
347. Top K Frequent Elements

Given an integer array nums and an integer k, return the k most frequent elements. You may return the answer in any order.

Example 1:

Input: nums = [1,1,1,2,2,3], k = 2

Output: [1,2]

Example 2:

Input: nums = [1], k = 1

Output: [1]

Example 3:

Input: nums = [1,2,1,2,1,2,3,1,3,2], k = 2

Output: [1,2]

Constraints:

1 <= nums.length <= 105
-104 <= nums[i] <= 104
k is in the range [1, the number of unique elements in the array].
It is guaranteed that the answer is unique.
 
Follow up: Your algorithm's time complexity must be better than O(n log n), where n is the array's size.

Interview Explanation ~

First, count the frequency of each number using a Dictionary. Then maintain a Min Heap of size k. Each heap node stores a number with its frequency as the priority.
When the heap size exceeds k, remove the element with the smallest frequency. This guarantees that after processing all unique numbers, the heap contains exactly the k most frequent elements.
The time complexity is O(n + m log k), where m is the number of unique elements, and the space complexity is O(m).

*/
