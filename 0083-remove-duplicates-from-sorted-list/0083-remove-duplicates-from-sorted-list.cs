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
    public ListNode DeleteDuplicates(ListNode head) {
        ListNode temp = head;

        while(temp!= null && temp.next != null){
            if(temp.val == temp.next.val){
                ListNode nodeToBeRemoved = temp.next;
                temp.next = nodeToBeRemoved.next;
                nodeToBeRemoved.next = null;
            }
            else{
                temp = temp.next;
            }
        }
        
        return head;
    }
}