/* https://leetcode.com/problems/k-closest-points-to-origin/ | Leetocde #973 - K Closest Points to Origin */

public class Solution {
    public int[][] KClosest(int[][] points, int k) {
        PriorityQueue<int[],int> heap = new();
        foreach(int[] i in points) {
            int x = i[0];
            int y = i[1];
            int distance = x * x + y * y;
            heap.Enqueue(i,-distance);
            if(heap.Count > k)
                heap.Dequeue();
        }
        int[][] res = new int[k][];
        for(int i = 0; i < k;i++)
            res[i] = heap.Dequeue();
        return res;
    }
}

/*
973. K Closest Points to Origin

Given an array of points where points[i] = [xi, yi] represents a point on the X-Y plane and an integer k, return the k closest points to the origin (0, 0).

The distance between two points on the X-Y plane is the Euclidean distance (i.e., √(x1 - x2)2 + (y1 - y2)2).

You may return the answer in any order. The answer is guaranteed to be unique (except for the order that it is in).

Example 1:

Input: points = [[1,3],[-2,2]], k = 1
Output: [[-2,2]]
Explanation:
The distance between (1, 3) and the origin is sqrt(10).
The distance between (-2, 2) and the origin is sqrt(8).
Since sqrt(8) < sqrt(10), (-2, 2) is closer to the origin.
We only want the closest k = 1 points from the origin, so the answer is just [[-2,2]].
Example 2:

Input: points = [[3,3],[5,-1],[-2,4]], k = 2
Output: [[3,3],[-2,4]]
Explanation: The answer [[-2,4],[3,3]] would also be accepted.
 
Constraints:

1 <= k <= points.length <= 104
-104 <= xi, yi <= 104

Interview Explanation

I calculate each point's squared distance from the origin using x*x + y*y. Since square root preserves ordering, it doesn't need to be computed. 
I maintain a max heap of size k containing the closest points seen so far. Whenever the heap grows beyond k, I remove the farthest point.
After processing all points, the heap contains exactly the k closest points. This gives an efficient O(N log k) solution instead of sorting all points in O(N log N).

*/
