/* https://leetcode.com/problems/merge-intervals/ | Leetcode #56 - Merge Intervals */

public class Solution {
    public int[][] Merge(int[][] intervals) {
        // input [[1,3],[2,6],[8,10],[15,18]]
        Array.Sort(intervals, (a,b) => a[0].CompareTo(b[0])); // Sorting based on First element of the Arrays
        List<int[]> res = new();
        res.Add(intervals[0]); // Added [1,3]
        for(int i =1; i < intervals.Length;i++) {
            int[] previousIntervals = res[res.Count - 1]; // [1,3]
            if(intervals[i][0] <= previousIntervals[1]) { // 2 <= 3 
                previousIntervals[1] = Math.Max(previousIntervals[1],intervals[i][1]);  // previousIntervals[1] = Math.Max(3,6)
            } else {
                res.Add(intervals[i]);
            }
        }
        return res.ToArray();
    }
}

/*
56. Merge Intervals

Given an array of intervals where intervals[i] = [starti, endi], merge all overlapping intervals, and return an array of the non-overlapping intervals that cover all the intervals in the input.

Example 1:

Input: intervals = [[1,3],[2,6],[8,10],[15,18]]
Output: [[1,6],[8,10],[15,18]]
Explanation: Since intervals [1,3] and [2,6] overlap, merge them into [1,6].
Example 2:

Input: intervals = [[1,4],[4,5]]
Output: [[1,5]]
Explanation: Intervals [1,4] and [4,5] are considered overlapping.
Example 3:

Input: intervals = [[4,7],[1,4]]
Output: [[1,7]]
Explanation: Intervals [1,4] and [4,7] are considered overlapping.
 
Constraints:

1 <= intervals.length <= 104
intervals[i].length == 2
0 <= starti <= endi <= 104

Interview Explanation ~

The idea is to first sort all intervals by their start time so that any overlapping intervals appear next to each other.
We add the first interval to the result list and then iterate through the remaining intervals. For each interval, we compare
it with the last interval already stored in the result, called previousInterval. If the current interval's start is less than
or equal to the end of previousInterval, the two intervals overlap, so we merge them by updating the end of previousInterval
to the larger of the two end values using Math.Max(). If they do not overlap, we simply add the current interval to the result as a separate interval.
By always comparing with the last merged interval in the result, we efficiently merge all overlapping intervals in a single pass after sorting.
The time complexity is O(n log n) due to sorting, and the merge step takes O(n). The space complexity is O(n) for the result list.

*/
