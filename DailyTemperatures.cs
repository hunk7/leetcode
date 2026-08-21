/* https://leetcode.com/problems/daily-temperatures/ | Leetcode #739 - Daily Temperatures */

public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        int n = temperatures.Length;
        int[] answer = new int[n];
        Stack<int> stack = new();
        for(int i = 0; i < n; i++) {
            while(stack.Count > 0 && temperatures[i] > temperatures[stack.Peek()]) {
                int index = stack.Pop();
                answer[index] = i - index;
            }
            stack.Push(i);
        }
        return answer;
    }
}

/*
739. Daily Temperatures

Given an array of integers temperatures represents the daily temperatures, return an array answer such that answer[i] is the number of days
you have to wait after the ith day to get a warmer temperature. If there is no future day for which this is possible, keep answer[i] == 0 instead.

Example 1:

Input: temperatures = [73,74,75,71,69,72,76,73]
Output: [1,1,4,2,1,1,0,0]
Example 2:

Input: temperatures = [30,40,50,60]
Output: [1,1,1,0]
Example 3:

Input: temperatures = [30,60,90]
Output: [1,1,0]
 
Constraints:

1 <= temperatures.length <= 105
30 <= temperatures[i] <= 100

Interview Explanation

The while loop keeps popping indices whose temperatures are lower than the current temperature,
because the current day is the first warmer day for all those indices. For each popped index, we calculate the waiting days as currentIndex - poppedIndex.
Any day that finds a warmer future temperature is popped from the stack and gets its answer calculated.
Days left in the stack after the loop ends never found a warmer future temperature, so their values remain the default 0 already present in the answer array.

*/
