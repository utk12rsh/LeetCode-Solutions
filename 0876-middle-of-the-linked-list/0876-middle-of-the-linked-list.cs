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
    public ListNode MiddleNode(ListNode head) {
        int size = 1;
        ListNode temp = head;
        while(temp.next != null)
        {
            temp = temp.next;
            size++;
        }

        int middle = size / 2;
        int position = 0;
        ListNode current = head;

        while(current != null)
        {
            if (position == middle)
            return current;

            current = current.next;
            position++;
        }

        return head;
    }
}