/* https://leetcode.com/problems/insert-interval/ | Leetcode #57 - Insert Interval */

public class Solution {
    public int[][] Insert(int[][] intervals, int[] newInterval) {
        List<int[]> res = new();
        int i = 0;
        int n = intervals.Length;
        while(i < n && intervals[i][1] < newInterval[0]) {
            res.Add(intervals[i]);
            i++;
        }
        while(i < n && intervals[i][0] <= newInterval[1]) {
            newInterval[0] = Math.Min(intervals[i][0],newInterval[0]);
            newInterval[1] = Math.Max(intervals[i][1],newInterval[1]);
            i++;
        }
        res.Add(newInterval);
        while(i < n) {
            res.Add(intervals[i]);
            i++;
        }
        return res.ToArray();
    }
}

Brute Force Approach ~

public class Solution {
    public int[][] Insert(int[][] intervals, int[] newInterval) {
        // Input: intervals = [[1,2],[3,5],[6,7],[8,10],[12,16]], newInterval = [4,8]
        intervals = intervals.Append(newInterval).ToArray(); // Added newInterval = [4,8]
        Array.Sort(intervals, (a,b) => a[0].CompareTo(b[0])); // Sorting
        List<int[]> res = new();
        res.Add(intervals[0]); // Added [1,2] based on First element of the Arrays
        for(int i =1; i < intervals.Length;i++) {
            int[] previousIntervals = res[res.Count - 1];
            if(intervals[i][0] <= previousIntervals[1]) {
                previousIntervals[1] = Math.Max(previousIntervals[1],intervals[i][1]);
            } else {
                res.Add(intervals[i]);
            }
        }
        return res.ToArray();
    }
}

/*
57. Insert Interval

You are given an array of non-overlapping intervals intervals where intervals[i] = [starti, endi] represent the start and the end of the ith interval and intervals is sorted in ascending order by starti. You are also given an interval newInterval = [start, end] that represents the start and end of another interval.

Two intervals are considered overlapping if they share at least one point.

Insert newInterval into intervals such that intervals is still sorted in ascending order by starti and intervals still does not have any overlapping intervals (merge overlapping intervals if necessary).

Return intervals after the insertion.
Note that you don't need to modify intervals in-place. You can make a new array and return it.

Example 1:

Input: intervals = [[1,3],[6,9]], newInterval = [2,5]
Output: [[1,5],[6,9]]
Example 2:

Input: intervals = [[1,2],[3,5],[6,7],[8,10],[12,16]], newInterval = [4,8]
Output: [[1,2],[3,10],[12,16]]
Explanation: Because the new interval [4,8] overlaps with [3,5],[6,7],[8,10].
 
Constraints:

0 <= intervals.length <= 104
intervals[i].length == 2
0 <= starti <= endi <= 105
intervals is sorted by starti in ascending order.
newInterval.length == 2
0 <= start <= end <= 105

Interview Explanation ~

Since the intervals are already sorted and non-overlapping, we don't need to sort. We process intervals in three phases. First,
add all intervals that end before newInterval starts because they cannot overlap. Second, merge all intervals that overlap with newInterval
by updating the start with Math.Min() and the end with Math.Max(). Third, add the merged interval to the result and then append all remaining intervals
that start after the merged interval ends. This gives an O(n) time complexity and O(n) space complexity.

*/
