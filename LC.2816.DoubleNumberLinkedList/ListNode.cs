namespace LC._2816.DoubleNumberLinkedList;

// Definition for singly-linked list.
public class ListNode : IEquatable<ListNode>
{
    public int val;
    public ListNode? next;

    public ListNode(int val = 0, ListNode? next = null)
    {
        this.val = val;
        this.next = next;
    }


    public bool Equals(ListNode? other)
    {
        return other is not null &&
               val == other.val &&
               (next is null && other.next is null || next is not null && next.Equals(other.next));
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(val);
    }
}