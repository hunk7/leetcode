/* https://leetcode.com/problems/clone-graph/ | Leetcode #133 - Clone Graph */

public class Solution
{
    private Dictionary<Node, Node> map = new(); // Example key 1 & value 1 {Key:Value}
    public Node CloneGraph(Node node)
    {
        if (node == null) // Check empty node
            return null;
        if (map.ContainsKey(node)) // Breaks Recursion and returns existing node
            return map[node];
        Node clone = new Node(node.val); // adds node value to clone
        map[node] = clone; // adds new clone value to Map
        foreach (Node neighbor in node.neighbors)
            clone.neighbors.Add(CloneGraph(neighbor)); // adds neighbours for clone with Recursive call
        return clone;
    }
}

/*
133. Clone Graph

Given a reference of a node in a connected undirected graph.

Return a deep copy (clone) of the graph.

Each node in the graph contains a value (int) and a list (List[Node]) of its neighbors.

class Node {
    public int val;
    public List<Node> neighbors;
}
 
Test case format:

For simplicity, each node's value is the same as the node's index (1-indexed). For example, the first node with val == 1, the second node with val == 2, and so on. The graph is represented in the test case using an adjacency list.

An adjacency list is a collection of unordered lists used to represent a finite graph. Each list describes the set of neighbors of a node in the graph.

The given node will always be the first node with val = 1. You must return the copy of the given node as a reference to the cloned graph.

Example 1:

Input: adjList = [[2,4],[1,3],[2,4],[1,3]]
Output: [[2,4],[1,3],[2,4],[1,3]]
Explanation: There are 4 nodes in the graph.
1st node (val = 1)'s neighbors are 2nd node (val = 2) and 4th node (val = 4).
2nd node (val = 2)'s neighbors are 1st node (val = 1) and 3rd node (val = 3).
3rd node (val = 3)'s neighbors are 2nd node (val = 2) and 4th node (val = 4).
4th node (val = 4)'s neighbors are 1st node (val = 1) and 3rd node (val = 3).
Example 2:

Input: adjList = [[]]
Output: [[]]
Explanation: Note that the input contains one empty list. The graph consists of only one node with val = 1 and it does not have any neighbors.
Example 3:

Input: adjList = []
Output: []
Explanation: This an empty graph, it does not have any nodes.
 
Constraints:

The number of nodes in the graph is in the range [0, 100].
1 <= Node.val <= 100
Node.val is unique for each node.
There are no repeated edges and no self-loops in the graph.
The Graph is connected and all nodes can be visited starting from the given node.

Interview Answer ~

When CloneGraph(1) is called, the algorithm starts with Node 1. Since Node 1 has not been cloned before, it creates a new clone (1') and stores the mapping 1 → 1' in the dictionary. This mapping is important because it allows the algorithm to quickly find an already-created clone if the same node is encountered again during traversal.
Next, the algorithm processes Node 1's neighbors, which are 2 and 4. It first moves to Node 2. Since Node 2 is not yet in the dictionary, a new clone (2') is created and the mapping 2 → 2' is stored. The algorithm then starts processing Node 2's neighbors, which are 1 and 3.
While processing Node 2's first neighbor, Node 1, the algorithm notices that Node 1 already exists in the dictionary. Instead of creating another clone, it immediately returns the existing clone (1'). This prevents infinite recursion that would otherwise occur because the graph contains cycles. Node 1' is then added to the neighbor list of 2'.
The algorithm then processes Node 2's second neighbor, Node 3. Since Node 3 has not been cloned yet, it creates 3', stores the mapping 3 → 3', and begins processing Node 3's neighbors, which are 2 and 4.
For Node 3's first neighbor, Node 2, the dictionary already contains 2 → 2', so the algorithm simply returns 2' and adds it to 3''s neighbor list. Next, it moves to Node 4. Since Node 4 has not been cloned yet, it creates 4', stores the mapping 4 → 4', and starts processing Node 4's neighbors, which are 1 and 3.
While processing Node 4's neighbors, both Node 1 and Node 3 are already present in the dictionary. Therefore, the algorithm reuses the existing clones 1' and 3' instead of creating new ones. These clones are added to 4''s neighbor list, completing the cloning of Node 4.
Once Node 4 has been fully processed, the recursion starts returning back up the call stack. 4' is added as a neighbor of 3', making 3''s neighbors [2', 4']. The completed clone 3' is then returned to the call that was cloning Node 2.
Back in Node 2's cloning process, 3' is added as a neighbor of 2', making 2''s neighbors [1', 3']. The completed clone 2' is then returned to the original call that was cloning Node 1.
Back in the cloning of Node 1, 2' is added as a neighbor of 1'. The algorithm then processes Node 1's next neighbor, Node 4. Since Node 4 is already in the dictionary, the existing clone 4' is returned immediately and added as another neighbor of 1'.
At this point, all nodes and edges have been processed. The final cloned graph consists of 1', 2', 3', and 4', connected in exactly the same way as the original graph. The dictionary ensured that each original node was cloned exactly once, while also preventing infinite recursion caused by cycles such as 1 → 2 → 1. The algorithm finally returns 1', which is the entry point to the fully cloned graph.

TC: O(V + E)
SC: O(V)

*/
