/* https://leetcode.com/problems/binary-tree-maximum-path-sum/ | Leetcode #124 - Binary Tree Maximum Path Sum */

public class Solution
{
    private int maximumPathSum = int.MinValue;
    public int MaxPathSum(TreeNode root) {
        GetMaximumGain(root);
        return maximumPathSum;
    }
    private int GetMaximumGain(TreeNode node)
    {
        if (node == null) return 0;

        // Calculate the maximum contribution from the left subtree.
        // Ignore it if its contribution is negative.
        int leftContribution = Math.Max(0, GetMaximumGain(node.left));

        // Calculate the maximum contribution from the right subtree.
        // Ignore it if its contribution is negative.
        int rightContribution = Math.Max(0, GetMaximumGain(node.right));

        // This is the complete path whose highest point is the current node.
        // It can contain both the left and right branches.
        int currentPathSum = leftContribution + node.val + rightContribution;

        // Update the maximum path found anywhere in the tree.
        maximumPathSum = Math.Max(maximumPathSum, currentPathSum);

        // Return the maximum single-branch path that can be extended through the parent.
        return node.val + Math.Max(leftContribution, rightContribution);
    }
}

/*
124. Binary Tree Maximum Path Sum

A path in a binary tree is a sequence of nodes where each pair of adjacent nodes in the sequence has an edge connecting them. A node can only appear in the sequence at most once.
Note that the path does not need to pass through the root.
The path sum of a path is the sum of the node's values in the path.

Given the root of a binary tree, return the maximum path sum of any non-empty path.

Example 1:

Input: root = [1,2,3]
Output: 6
Explanation: The optimal path is 2 -> 1 -> 3 with a path sum of 2 + 1 + 3 = 6.
Example 2:

Input: root = [-10,9,20,null,null,15,7]
Output: 42
Explanation: The optimal path is 15 -> 20 -> 7 with a path sum of 15 + 20 + 7 = 42.

          -10
          /  \
         9    20
             /  \
            15   7
 
Constraints:

The number of nodes in the tree is in the range [1, 3 * 104].
-1000 <= Node.val <= 1000

Interview explanation ~

I use postorder DFS because every node needs the maximum contribution from its left and right subtrees. A complete path passing through a node can include both branches,
so I calculate left + node value + right and use it to update a global maximum. However, when returning a value to the parent, I can return only one branch because returning
both would create a branching structure instead of a path. Therefore, I return node value + max(left, right). I also ignore negative subtree contributions by comparing them with zero.
maximumPathSum stores the best completed path found anywhere.
The return value gives the parent a path it can continue extending.

Why return anything if the global maximum is already updated?
Because recursion is processed from the bottom upward.
When processing a child, we do not yet know whether the best path might later include:

The child
Its parent
Its grandparent
Another branch higher in the tree

The return value allows ancestors to build larger paths.

We update maximumPathSum with a complete path that can use both children, but we return only the best single-branch path so the parent can extend it without creating an invalid branching path.

*/
