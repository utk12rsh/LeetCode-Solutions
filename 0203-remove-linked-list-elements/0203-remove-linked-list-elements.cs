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
    public ListNode RemoveElements(ListNode head, int val) {
        ListNode sentinel = new ListNode(0);
        sentinel.next = head;
        ListNode prev = sentinel;

        while(prev != null && prev.next != null){
            if(prev.next.val == val){
                ListNode nodeToBeRemoved = prev.next;
                prev.next = prev.next.next;
                nodeToBeRemoved.next = null;
            }else{
                prev = prev.next;
            }
        }
        return sentinel.next;
    }
}