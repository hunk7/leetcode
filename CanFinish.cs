/* https://leetcode.com/problems/course-schedule/ | Leetcode #207 - Course Schedule */

public class Solution
{
    public bool CanFinish(int numCourses, int[][] prerequisites) {
        var graph = new List<int>[numCourses]; // Adding vertices
        for (int i = 0; i < numCourses; i++)
            graph[i] = new List<int>(); // Set up empty neighbour for graph
        var indegree = new int[numCourses];
        foreach (int[] edge in prerequisites) {
            int course = edge[0];
            int prerequisite = edge[1];  // used 0 & 1 due to Constraints prerequisites[i].length == 2
            graph[prerequisite].Add(course);
            indegree[course]++;  // Incrementing value by 1 for course Position
        }
        var queue = new Queue<int>();
        for (int i = 0; i < numCourses; i++) {
            if (indegree[i] == 0)  
                queue.Enqueue(i);  // Add to Queue if indegree value is 0
        }
        int completedCourses = 0;
        while (queue.Count > 0) {
            int current = queue.Dequeue();  // if queue has anything process it
            completedCourses++;
            foreach (int neighbor in graph[current]) {
                indegree[neighbor]--;  // decrease indegree value 
                if (indegree[neighbor] == 0)
                    queue.Enqueue(neighbor); // process indgree again if the value is 0
            }
        }
        return completedCourses == numCourses; // if completed all graphs course then ans is true orelse false
    }
}

/*
207. Course Schedule

There are a total of numCourses courses you have to take, labeled from 0 to numCourses - 1. You are given an array prerequisites where prerequisites[i] = [ai, bi]
indicates that you must take course bi first if you want to take course ai.
For example, the pair [0, 1], indicates that to take course 0 you have to first take course 1.
Return true if you can finish all courses. Otherwise, return false.

Example 1:
Input: numCourses = 2, prerequisites = [[1,0]]
Output: true
Explanation: There are a total of 2 courses to take. 
To take course 1 you should have finished course 0. So it is possible.

Example 2:
Input: numCourses = 2, prerequisites = [[1,0],[0,1]]
Output: false
Explanation: There are a total of 2 courses to take. 
To take course 1 you should have finished course 0, and to take course 0 you should also have finished course 1. So it is impossible.

Constraints:

1 <= numCourses <= 2000
0 <= prerequisites.length <= 5000
prerequisites[i].length == 2
0 <= ai, bi < numCourses
All the pairs prerequisites[i] are unique.

Interview Explanation ~

We model courses as a directed graph where b → a means course b must be completed before course a. Using Kahn's Topological Sort, we track indegrees, process all nodes with indegree 0,
and remove their outgoing edges. If we can process all numCourses nodes, there is no cycle and all courses can be finished. Otherwise, a cycle exists and the answer is false.

Time Complexity: O(V + E)
Space Complexity: O(V + E) where V = numCourses and E = prerequisites.Length.

Example: Dry Run

0 ──► 1 ──► 3
│
└──► 2 ──► 3


Step 1: Calculate indegrees

0 = 0
1 = 1
2 = 1
3 = 2

Queue = [0]
          ▲
          │
     indegree = 0


Step 2: Process 0

Remove 0 from graph

X     ► 1 ──► 3
│
└────► 2 ──► 3

indegree:

0 = 0
1 = 0
2 = 0
3 = 2

Queue = [1,2]


Step 3: Process 1

X     X     ► 3
│
└────► 2 ──► 3

indegree:

3 = 1

Queue = [2]


Step 4: Process 2

X     X
│
└──── X ──► 3

indegree:

3 = 0

Queue = [3]


Step 5: Process 3

X     X
│
└──── X     X

Queue = []

Processed Courses:
[0,1,2,3]

processed == numCourses

4 == 4

NO CYCLE ✅

*/
