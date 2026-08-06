/* https://leetcode.com/problems/container-with-most-water/ | Leetcode #11 - Container With Most Water */

public class Solution
{
    public int MaxArea(int[] height)
    {
        int left = 0;
        int right = height.Length - 1;
        int maxArea = 0;
        while (left < right)
        {
            int width = right - left;
            int minHeight = Math.Min(height[left], height[right]);
            int area = width * minHeight;
            maxArea = Math.Max(maxArea, area);
            // Move the shorter line
            if (height[left] < height[right])
                left++;
            else
                right--;
        }
        return maxArea;
    }
}

/*
11. Container With Most Water

You are given an integer array height of length n. There are n vertical lines drawn such that the two endpoints of the ith line are (i, 0) and (i, height[i]).

Find two lines that together with the x-axis form a container, such that the container contains the most water.

Return the maximum amount of water a container can store.

Notice that you may not slant the container.

Example 1:

Input: height = [1,8,6,2,5,4,8,3,7]
Output: 49
Explanation: The above vertical lines are represented by array [1,8,6,2,5,4,8,3,7]. In this case, the max area of water (blue section) the container can contain is 49.
Example 2:

Input: height = [1,1]
Output: 1
 
Constraints:

n == height.length
2 <= n <= 105
0 <= height[i] <= 104

interview answer:

Since the area is limited by the shorter line, moving the taller line can never increase the limiting height while the width definitely decreases.
Therefore, we always move the shorter line because that is the only way to potentially find a taller boundary and increase the area.

Algo ~ 

1. Place left pointer at start.
2. Place right pointer at end.
3. Compute current area.
4. Update max area.
5. Move smaller-height pointer.
6. Repeat until pointers meet.

*/
