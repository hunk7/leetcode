/* https://leetcode.com/problems/network-delay-time/ | Leetcode #743 - Network Delay Time */

public class Solution {
    public int NetworkDelayTime(int[][] times, int n, int k) {
        // 1. Build the adjacency list
        var graph = new Dictionary<int, List<(int node, int weight)>>();
        for (int i = 1; i <= n; i++)
            graph[i] = new List<(int, int)>(); // added empty array on graph indexs

        foreach (var time in times)
            graph[time[0]].Add((time[1], time[2])); // setting svalues of times as per question

        // 2. Initialize distances array
        int[] dist = new int[n + 1];
        Array.Fill(dist, int.MaxValue); // adding maximum value so array is valid in all cases
        dist[k] = 0;

        // 3. Priority Queue stores (node), prioritized by shortest distance
        var pq = new PriorityQueue<int, int>();
        pq.Enqueue(k, 0);

        // 4. Dijkstra's Traversal
        while (pq.Count > 0) {
            pq.TryDequeue(out int currNode, out int currDist);

            // Optimization: ignore outdated longer paths in the queue
            if (currDist > dist[currNode]) continue;

            foreach (var edge in graph[currNode]) {
                int nextNode = edge.node;
                int weight = edge.weight;
                int newDist = currDist + weight;

                // Relaxation step
                if (newDist < dist[nextNode]) {
                    dist[nextNode] = newDist;
                    pq.Enqueue(nextNode, newDist);
                }
            }
        }

        // 5. Find the maximum of all shortest paths
        int maxTime = 0;
        for (int i = 1; i <= n; i++) {
            if (dist[i] == int.MaxValue) {
                return -1; // Unreachable node found
            }
            maxTime = Math.Max(maxTime, dist[i]);
        }

        return maxTime;
    }
}

/*
743. Network Delay Time

You are given a network of n nodes, labeled from 1 to n. You are also given times, a list of travel times as directed edges times[i] = (ui, vi, wi), where ui is the source node,
vi is the target node, and wi is the time it takes for a signal to travel from source to target.
We will send a signal from a given node k. Return the minimum time it takes for all the n nodes to receive the signal.
If it is impossible for all the n nodes to receive the signal, return -1.

Example 1:
Input: times = [[2,1,1],[2,3,1],[3,4,1]], n = 4, k = 2
Output: 2
Example 2:
Input: times = [[1,2,1]], n = 2, k = 1
Output: 1
Example 3:

Input: times = [[1,2,1]], n = 2, k = 2
Output: -1
 
Constraints:

1 <= k <= n <= 100
1 <= times.length <= 6000
times[i].length == 3
1 <= ui, vi <= n
ui != vi
0 <= wi <= 100
All the pairs (ui, vi) are unique. (i.e., no multiple edges.)

Explanation ~ 

This Dijkstra traversal loop repeatedly picks the node that can currently be reached in the shortest time from the source node k. The priority queue (pq) always returns the node
with the smallest known distance, stored in currNode and currDist. Before processing it, the algorithm checks if (currDist > dist[currNode]) to skip outdated entries, 
because the same node may have been added to the queue multiple times with different distances and only the shortest one matters. It then visits all neighbors of the current node
and calculates the time needed to reach each neighbor through the current path using newDist = currDist + weight. If this newly calculated distance is smaller than the previously recorded
distance (dist[nextNode]), a shorter path has been found. The algorithm updates dist[nextNode] with the better value and pushes that neighbor back into the priority queue so its neighbors
can later be explored using this improved distance. This process continues until the queue becomes empty, at which point dist[] contains the shortest time from the source node to
every reachable node in the graph.

*/
