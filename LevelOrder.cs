/* https://leetcode.com/problems/binary-tree-level-order-traversal/ | Leetcode #102 - Binary Tree Level Order Traversal */

public class Solution
{
    public IList<IList<int>> LevelOrder(TreeNode root)
    {
        IList<IList<int>> result = new List<IList<int>>();
        if (root == null)
            return result;
        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        while (queue.Count > 0)
        {
            int size = queue.Count;
            List<int> level = new List<int>();
            for (int i = 0; i < size; i++)
            {
                TreeNode current = queue.Dequeue();
                level.Add(current.val);
                if (current.left != null)
                    queue.Enqueue(current.left);
                if (current.right != null)
                    queue.Enqueue(current.right);
            }
            result.Add(level);
        }
        return result;
    }
}

/*
102. Binary Tree Level Order Traversal

Given the root of a binary tree, return the level order traversal of its nodes' values. (i.e., from left to right, level by level).

        3
       / \
      9   20
         /  \
        15   7

Example 1:

Input: root = [3,9,20,null,null,15,7]
Output: [[3],[9,20],[15,7]]
Example 2:

Input: root = [1]
Output: [[1]]
Example 3:

Input: root = []
Output: []
 
Constraints:

The number of nodes in the tree is in the range [0, 2000].
-1000 <= Node.val <= 1000

Interview Explanation ~

"We need values grouped level by level, which naturally suggests BFS. I use a queue and process one level at a time. Before processing a level, I store the current queue count.
That count represents the number of nodes in the current level. I then dequeue exactly those nodes, add their values to a temporary list, and enqueue their children.
After finishing the level, I add the list to the result. Each node is visited exactly once, giving O(n) time complexity and O(n) space complexity."

*/
