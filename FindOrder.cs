/* https://leetcode.com/problems/course-schedule-ii/ | Letcode #210 - Course Schedule II */

public class Solution {
    public int[] FindOrder(int numCourses, int[][] prerequisites) {
        var graph = new List<int>[numCourses];       
        for(int i = 0; i < numCourses; i++)
            graph[i] = new List<int>();

        int[] indegree = new int[numCourses];

        foreach(int[] edge in prerequisites) {
            int course = edge[0];
            int prerequisite = edge[1];
            graph[prerequisite].Add(course);
            indegree[course]++; // calculate indegree
        }

        var queue = new Queue<int>();
        for (int i = 0; i < numCourses; i++) {
            if (indegree[i] == 0)  
                queue.Enqueue(i);  // Add to Queue if indegree value is 0
        }

        var res = new List<int>();

        while (queue.Count > 0) {
            int current = queue.Dequeue();  // if queue has anything process it
            res.Add(current);
            foreach (int neighbor in graph[current]) {
                indegree[neighbor]--;  // decrease indegree value 
                if (indegree[neighbor] == 0)
                    queue.Enqueue(neighbor); // process indgree again if the value is 0
            }
        }
        // Check if we were able to include all courses (i.e., no cycle)
        if (res.Count == numCourses) {
            return res.ToArray();
        }

        // Return an empty array if there is a cycle
        return new int[0];
    }
}

/*
210. Course Schedule II

There are a total of numCourses courses you have to take, labeled from 0 to numCourses - 1.
You are given an array prerequisites where prerequisites[i] = [ai, bi] indicates that you must take course bi first if you want to take course ai.
For example, the pair [0, 1], indicates that to take course 0 you have to first take course 1.
Return the ordering of courses you should take to finish all courses. If there are many valid answers, return any of them. If it is impossible to finish all courses, return an empty array.

Example 1:

Input: numCourses = 2, prerequisites = [[1,0]]
Output: [0,1]
Explanation: There are a total of 2 courses to take. To take course 1 you should have finished course 0. So the correct course order is [0,1].

Example 2:

Input: numCourses = 4, prerequisites = [[1,0],[2,0],[3,1],[3,2]]
Output: [0,2,1,3]
Explanation: There are a total of 4 courses to take. To take course 3 you should have finished both courses 1 and 2. Both courses 1 and 2 should be taken after you finished course 0.
So one correct course order is [0,1,2,3]. Another correct ordering is [0,2,1,3].
Example 3:

Input: numCourses = 1, prerequisites = []
Output: [0]

Constraints:

1 <= numCourses <= 2000
0 <= prerequisites.length <= numCourses * (numCourses - 1)
prerequisites[i].length == 2
0 <= ai, bi < numCourses
ai != bi
All the pairs [ai, bi] are distinct.

Interview Explanation ~

we can model it as a directed graph where each course is a node and each prerequisite forms a directed edge pointing from the prerequisite to the target course,
allowing us to find a valid ordering using Kahn’s Algorithm for topological sorting. First, I initialize an adjacency list to represent the graph and an in-degree array
to track how many prerequisites each course depends on. As I iterate through the prerequisites array, I populate the graph and increment the in-degree count for each dependent course.
Next, I enqueue all courses with an in-degree of zero, since they have no prerequisites and can be taken immediately. I then process the queue by dequeuing a course, adding it to
my result list, and decrementing the in-degree of all its neighboring dependent courses; whenever a neighbor's in-degree drops to zero, I push it onto the queue. Finally, 
because the problem states that we must return an empty array if finishing all courses is impossible due to a cycle, I compare the count of courses in my result list with the total number
of courses. If they match, a valid topological sort exists and I return the result as an array; otherwise, a cycle is present, and I return an empty array.

*/
