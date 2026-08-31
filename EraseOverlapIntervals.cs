/* https://leetcode.com/problems/non-overlapping-intervals/ | Leetcode #435 - Non-overlapping Intervals */

public class Solution {
    public int EraseOverlapIntervals(int[][] intervals) {
        // Input: intervals = [[1,2],[2,3],[3,4],[1,3]]
        // also needs to consider smallest array in intervals
        Array.Sort(intervals, (a,b) => a[1].CompareTo(b[1])); // checking last elements
        // after sorting [[1,2],[2,3],[1,3],[3,4]]
        int removedCount = 0;
        int PreviousEnd = intervals[0][1]; // 2
        for(int i = 1; i < intervals.Length; i++) {
            if(intervals[i][0] < PreviousEnd) {  // 2 < 2 = false
                removedCount++;
            } else {
                PreviousEnd = intervals[i][1];
            }
        }
        return removedCount;
    }
}

/*
435. Non-overlapping Intervals

Given an array of intervals intervals where intervals[i] = [starti, endi], return the minimum number of intervals you need to remove to make the rest of the intervals non-overlapping.

Note that intervals which only touch at a point are non-overlapping. For example, [1, 2] and [2, 3] are non-overlapping.

Example 1:

Input: intervals = [[1,2],[2,3],[3,4],[1,3]]
Output: 1
Explanation: [1,3] can be removed and the rest of the intervals are non-overlapping.
Example 2:

Input: intervals = [[1,2],[1,2],[1,2]]
Output: 2
Explanation: You need to remove two [1,2] to make the rest of the intervals non-overlapping.
Example 3:

Input: intervals = [[1,2],[2,3]]
Output: 0
Explanation: You don't need to remove any of the intervals since they're already non-overlapping.
 
Constraints:

1 <= intervals.length <= 105
intervals[i].length == 2
-5 * 104 <= starti < endi <= 5 * 104

Interview Explanation ~

"We sort intervals by their ending time and greedily keep the interval that finishes first because it leaves the most room for future intervals.
While iterating, if the current interval starts before the previously kept interval ends, an overlap exists and we count it as a removal. Otherwise,
we keep the interval and update the previous end. This produces the maximum number of non-overlapping intervals, and therefore the minimum number of removals."

*/
