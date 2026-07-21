/* https://leetcode.com/problems/remove-nth-node-from-end-of-list/  |  Leetcode #19 - Remove Nth Node From End of List */

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        ListNode dummy = new ListNode(0);
        dummy.next = head;
        ListNode fast = dummy;
        ListNode slow = dummy;
        for(int i =0;i<=n;i++)
            fast = fast.next;
        while(fast != null){
            fast = fast.next;
            slow = slow.next;
        }
        slow.next = slow.next.next;
        return dummy.next;
    }
}

/*
19. Remove Nth Node From End of List

Given the head of a linked list, remove the nth node from the end of the list and return its head.

Example 1:

Input: head = [1,2,3,4,5], n = 2
Output: [1,2,3,5]

Example 2:

Input: head = [1], n = 1
Output: []

Example 3:

Input: head = [1,2], n = 1
Output: [1]

Constraints:

The number of nodes in the list is sz.
1 <= sz <= 30
0 <= Node.val <= 100
1 <= n <= sz

Follow up: Could you do this in one pass?

Interview Answer

Since we need the Nth node from the end, I'll use the Two Pointer technique.
I create a dummy node to simplify deletion of the head node. 
Then I move the fast pointer n+1 steps ahead of slow.
After that, I move both pointers together until fast reaches the end.
At that point, slow is positioned just before the node that needs to be removed.
I update slow.next to skip the target node and return dummy.next.
This achieves the follow-up requirement in one pass with O(N) time and O(1) space.

*/
