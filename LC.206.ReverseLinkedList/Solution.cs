using System.Diagnostics;

namespace LC._206.ReverseLinkedList;

// Definition for singly-linked list.
public class ListNode
{
    public int val;
    public ListNode? next;

    public ListNode(int val = 0, ListNode? next = null)
    {
        this.val = val;
        this.next = next;
    }
}

public class Solution
{
    public ListNode? CreateNodes(int[] nodes)
    {
        if (nodes.Length == 1)
        {
            return new ListNode(nodes[0]);
        }

        var head = new ListNode(nodes[^1]);
        for (int i = 1; i < nodes.Length; i++)
        {
            head = new ListNode(nodes[^(i + 1)], head);
        }

        return head;
    }

    public ListNode? ReverseList(ListNode? head)
    {
        if (head?.next == null)
        {
            return head;
        }
        ListNode next = null;
        while (head != null)
        {
            ListNode? n2 = head.next;
            // next 
            // head.next = next;
            // next = head; 
            // head = prev;
        }

        // 2 
        // head.next.next = head;
        // head = head.next;
        // head.next!.next = null;


        // 2
        //
        // var prev = head.next;
        // prev.next = head;




        return head;
    }
}