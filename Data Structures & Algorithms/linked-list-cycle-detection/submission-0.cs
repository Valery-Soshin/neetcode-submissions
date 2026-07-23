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
    public bool HasCycle(ListNode head) {
        var visited = new HashSet<ListNode>();

        var currentNode = head;

        while (currentNode != null)
        {
            if (visited.Contains(currentNode))
            {
                return true;
            }
            else
            {
                visited.Add(currentNode);
            }

            currentNode = currentNode.next;
        }

        return false;
    }
}
