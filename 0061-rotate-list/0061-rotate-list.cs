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
    public ListNode RotateRight(ListNode head, int k) {
        if(head == null || head.next == null || k == 0)
            return head;
        
        int length = 0;
        ListNode temp = head;

        while(temp != null){
            length++;
            temp = temp.next;
        }

        k = k % length;
        
        if(k == 0)
            return head;

        int lastNodeToBe = length - k;
        int curr = 1;
        temp = head;

        while(curr < lastNodeToBe){
            temp = temp.next;
            curr++;
        }

        ListNode newHead = temp.next;
        ListNode newNode = temp.next;
        temp.next = null;

        while(newNode.next != null){
            newNode = newNode.next;
        }

        newNode.next = head;
        head = newHead;
        return head;
    }

}