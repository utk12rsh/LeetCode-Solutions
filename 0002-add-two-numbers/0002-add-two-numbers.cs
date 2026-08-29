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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        ListNode head = null;
        ListNode tail = null;
        ListNode temp1 = l1;
        ListNode temp2 = l2;
        int carry = 0;

        while(temp1 != null || temp2 != null || carry ==1){
            int firstVal = temp1 != null ? temp1.val : 0;
            int secondVal = temp2 != null ? temp2.val : 0;

            int sum = firstVal + secondVal + carry;

            if(sum >= 10){
                sum = sum % 10;
                carry = 1;
            }
            else{
                carry = 0;
            }

            ListNode newNode = new ListNode(sum);
            if(head == null){
                head = newNode;
                tail = head;
            }
            else{
                tail.next = newNode;
                tail = tail.next;
            }
            if(temp1 != null)
                temp1 = temp1.next;
            if(temp2 != null)
                temp2 = temp2.next;
        }
        return head;
    }
}