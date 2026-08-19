/* https://leetcode.com/problems/largest-rectangle-in-histogram/ | Leetcode #84 - Largest Rectangle in Histogram */

public class Solution
{
    public int LargestRectangleArea(int[] heights)
    {
        Stack<int> stack = new();   // Stores indices of bars in increasing height order
        int maxArea = 0;            // Tracks the largest rectangle found so far
        for (int i = 0; i <= heights.Length; i++) // Loop one extra time using a dummy height 0
        {
            int currentHeight = (i == heights.Length) ? 0 : heights[i]; // Use 0 at the end to force all remaining bars to be processed
            // If current bar is smaller than stack top bar,
            // we have found the right boundary for taller bars in the stack
            while (stack.Count > 0 && currentHeight < heights[stack.Peek()])
            {
                int height = heights[stack.Pop()]; // Rectangle height = popped bar height
                int width;
                if (stack.Count == 0)
                {
                    // No smaller element on the left
                    // Rectangle extends from index 0 to i-1
                    width = i;
                }
                else
                {
                    // Current index i = first smaller element on the right
                    // stack.Peek() = first smaller element on the left
                    // Width is everything between them
                    width = i - stack.Peek() - 1;
                }
                // Calculate area using current height and width
                maxArea = Math.Max(maxArea, height * width);
            }
            // Push current index into stack
            // Stack always maintains increasing heights
            stack.Push(i);
        }
        return maxArea; // Return the largest rectangle area found
    }
}

/*
84. Largest Rectangle in Histogram

Given an array of integers heights representing the histogram's bar height where the width of each bar is 1, return the area of the largest rectangle in the histogram.

Index:    0 1 2 3 4 5
Height:   2 1 5 6 2 3

             █
             █
         █   █
         █   █
█        █   █      █
█   █    █   █   █  █
-----------------------
0   1   2    3   4   5

Example 1:

Input: heights = [2,1,5,6,2,3]
Output: 10
Explanation: The above is a histogram where width of each bar is 1.
The largest rectangle is shown in the red area, which has an area = 10 units.
Example 2:

Input: heights = [2,4]
Output: 4
 
Constraints:

1 <= heights.length <= 105
0 <= heights[i] <= 104

Interview Explanation ~

We maintain a monotonic increasing stack of indices. Whenever the current bar is smaller than the top bar in the stack,
we know we've found the right boundary for that taller bar. After popping, the new stack top represents the left boundary.
Using these two boundaries we calculate the width and area for the popped bar. Each index is pushed and popped at most once, giving O(n) time complexity.

STACK = Bars waiting to find their RIGHT smaller element.
When a smaller bar arrives:
✅ Pop
✅ Right boundary = current index
✅ Left boundary = new stack top
✅ Calculate area

*/
