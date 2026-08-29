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
    public bool IsPalindrome(ListNode head) {
        
            ListNode slow = head, fast = head;

            while(fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }

            ListNode prev = null, curr = slow;

            while (curr != null) {
                ListNode nodeToBeReversed = curr;
                curr = curr.next;
                nodeToBeReversed.next = prev;
                prev = nodeToBeReversed;
            }

            ListNode start = head, end = prev;

            while(end != null)
            {
                if (start.val != end.val)
                    return false;

                start = start.next;
                end = end.next;
            }
            return true;
    }
}