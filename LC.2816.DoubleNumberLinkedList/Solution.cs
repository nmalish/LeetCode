namespace LC._2816.DoubleNumberLinkedList;

public class Solution
{
    public ListNode DoubleIt(ListNode? head)
    {
        ListNode resultHead = new();
        ListNode result = resultHead;

        var first = head.val * 2;
        if (first >= 10)
        {
            result.val = 1;
            result.next = new();
            result = result.next;
        }

        while (head is not null)
        {
            var current = head.val * 2 % 10;

            if (head.next is not null && head.next.val * 2 >= 10)
            {
                current += 1;
            }

            result.val = current;

            if (head.next is not null)
            {
                result.next = new();
                result = result.next;
            }

            head = head.next;
        }


        return resultHead;
    }
}