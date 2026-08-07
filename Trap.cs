/* https://leetcode.com/problems/trapping-rain-water/ | Leetcode #42 - Trapping Rain Water */

public class Solution
{
    public int Trap(int[] height)
    {
        if (height == null || height.Length < 3)
            return 0;
        int left = 0, right = height.Length - 1 ,leftMax = 0,rightMax = 0, water = 0;
        while (left < right)
        {
            if (height[left] < height[right])
            {
                if (height[left] >= leftMax)
                    leftMax = height[left];
                else
                    water += leftMax - height[left];
                left++;
            }
            else
            {
                if (height[right] >= rightMax)
                    rightMax = height[right];
                else
                    water += rightMax - height[right];
                right--;
            }
        }
        return water;
    }
}

/*
42. Trapping Rain Water

Given n non-negative integers representing an elevation map where the width of each bar is 1, compute how much water it can trap after raining.

Example 1:

Input: height = [0,1,0,2,1,0,1,3,2,1,2,1]
Output: 6
Explanation: The above elevation map (black section) is represented by array [0,1,0,2,1,0,1,3,2,1,2,1].
In this case, 6 units of rain water (blue section) are being trapped.
Example 2:

Input: height = [4,2,0,3,2,5]
Output: 9 

Constraints:

n == height.length
1 <= n <= 2 * 104
0 <= height[i] <= 105

Interview Explanation

At any position, the water level is determined by the smaller of the tallest bars on the left and right. Using two pointers,
we process the side with the smaller height because the trapped water on that side is already guaranteed by the taller boundary on the opposite side.
We maintain leftMax and rightMax and accumulate trapped water in one pass, achieving O(n) time and O(1) extra space.

*/
