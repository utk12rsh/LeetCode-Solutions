/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB) {
        int aLength = 0;
        int bLength = 0;

        ListNode temp = headA;
        while (temp != null) 
        {
            aLength++;
            temp = temp.next;
        }

        temp = headB;
        while (temp != null)
        {
            bLength++;
            temp = temp.next;
        }

        int diff = Math.Abs(aLength - bLength);

        for (int i = 0; i < diff; i++)
        {
            if (bLength > aLength)
                headB = headB.next;
            else
                headA = headA.next;
        }

        ListNode a = headA;
        ListNode b = headB;

        while (a != b)
        {
            a = a.next;
            b = b.next;
        }

        return a;
    }
}