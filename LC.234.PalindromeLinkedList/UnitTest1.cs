namespace LC._234.PalindromeLinkedList;

public class UnitTest1
{
    [Fact]
    public void Case1()
    {
        var head = new ListNode(1, new ListNode(2, new ListNode(2, new ListNode(1))));
        Solution solution = new();
        Assert.True(solution.IsPalindrome(head));
    }
}