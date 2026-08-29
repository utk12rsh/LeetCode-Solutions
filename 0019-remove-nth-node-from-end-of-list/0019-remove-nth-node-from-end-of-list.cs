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
        ListNode sentinel = new ListNode(0);
        sentinel.next = head;

        ListNode first = sentinel;
        ListNode second = sentinel;

        for(int i = 0; i < n; i++){
            second = second.next;
        }

        while(second != null && second.next != null){
            second = second.next;
            first = first.next;
        }

        ListNode nodeToBeDeleted = first.next;
        first.next = first.next.next;
        nodeToBeDeleted.next = null;
        return sentinel.next;
    }
}