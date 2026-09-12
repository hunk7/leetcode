/* https://leetcode.com/problems/diameter-of-binary-tree/ | Leetcode #543 - Diameter of Binary Tree */

/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution
{
    private int diameter = 0;
    public int DiameterOfBinaryTree(TreeNode root)
    {
        GetHeight(root);
        return diameter;
    }
    private int GetHeight(TreeNode node)
    {
        if (node == null) return 0;
        int leftHeight = GetHeight(node.left);
        int rightHeight = GetHeight(node.right);
        diameter = Math.Max(diameter, leftHeight + rightHeight);
        return 1 + Math.Max(leftHeight, rightHeight);
    }
}

/*
543. Diameter of Binary Tree

Given the root of a binary tree, return the length of the diameter of the tree.
The diameter of a binary tree is the length of the longest path between any two nodes in a tree. This path may or may not pass through the root.
The length of a path between two nodes is represented by the number of edges between them.

Example 1:

Input: root = [1,2,3,4,5]
       1
      / \
     2   3
    / \
   4   5

Output: 3
Explanation: 3 is the length of the path [4,2,1,3] or [5,2,1,3].

Example 2:

Input: root = [1,2]
Output: 1
 
Constraints:

The number of nodes in the tree is in the range [1, 104].
-100 <= Node.val <= 100

Interview Expalnation ~

The diameter passing through any node equals left subtree height + right subtree height. During a post-order DFS, we compute heights and update a global maximum diameter at every node,
giving an O(N) solution.

*/
