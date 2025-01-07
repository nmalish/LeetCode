namespace LC._234.PalindromeLinkedList;

public class Solution
{
    public bool IsPalindrome(ListNode? head)
    {
        if (head is null)
        {
            return false;
        }
        if (head.next is null)
        {
            return true;
        }
        var list = new List<int>();
        while (head is not null)
        {
            list.Add(head.val);
            head = head.next;
        }
        var len = list.Count;

        for (int i = 0; i < len / 2; i++)
        {
            if (list[i] != list[len - 1 - i])
            {
                return false;
            }
        }
        return true;
    }
}