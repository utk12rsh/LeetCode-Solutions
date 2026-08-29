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
    public ListNode SwapPairs(ListNode head) {
        if(head == null || head.next == null)
            return head;

        ListNode curr= head;
        ListNode prev = null;

        while(curr != null && curr.next != null){
            ListNode nodeToBeShifted = curr.next;
            curr.next = curr.next.next;
            nodeToBeShifted.next = curr;

            if(curr == head){
                head = nodeToBeShifted;
            }
            else{
                prev.next = nodeToBeShifted;
            }
            prev = curr;
            curr = curr.next;
        }
        return head;
    }
}