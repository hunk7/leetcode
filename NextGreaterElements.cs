/* https://leetcode.com/problems/next-greater-element-ii/ | Leetcode #503 - Next Greater Element II */

public class Solution {
    public int[] NextGreaterElements(int[] nums) {
        int n = nums.Length;
        int[] result = new int[n];
        Array.Fill(result, -1);
        Stack<int> stack = new();
        for(int i=0;i<2*n;i++){
            int currentIndex = i % n;
            while(stack.Count > 0 && nums[currentIndex] > nums[stack.Peek()]) {
                int index = stack.Pop();
                result[index] = nums[currentIndex];
            }
            if(i < n)
                stack.Push(currentIndex);
        }
        return result;
    }
}

/*
503. Next Greater Element II

Given a circular integer array nums (i.e., the next element of nums[nums.length - 1] is nums[0]), return the next greater number for every element in nums.

The next greater number of a number x is the first greater number to its traversing-order next in the array,
which means you could search circularly to find its next greater number. If it doesn't exist, return -1 for this number.

Example 1:

Input: nums = [1,2,1]
Output: [2,-1,2]
Explanation: The first 1's next greater number is 2; 
The number 2 can't find next greater number. 
The second 1's next greater number needs to search circularly, which is also 2.
Example 2:

Input: nums = [1,2,3,4,3]
Output: [2,3,4,-1,4]
 
Constraints:

1 <= nums.length <= 104
-109 <= nums[i] <= 109

Interview Answer ~

I use a monotonic decreasing stack of indices. The stack stores elements whose next greater value hasn't been found yet.
As I traverse the array, whenever the current element is greater than the element at the top index of the stack, I pop that index and set its next greater element.
Since the array is circular, I iterate 2 * n times and use i % n to wrap around. Each index is pushed and popped at most once, giving O(n) time and O(n) space complexity.

*/
