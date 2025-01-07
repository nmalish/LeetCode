namespace LC._2816.DoubleNumberLinkedList;

public static class SolutionTests
{
    [Fact]
    public static void DoubleLinkedListWithNoOverflow()
    {
        var head = new ListNode(1, new ListNode(2, new ListNode(4)));

        var solution = new Solution();
        var result = solution.DoubleIt(head);

        var equals = result.Equals(new ListNode(2, new ListNode(4, new ListNode(8))));

        Assert.True(equals);
    }

    [Fact]
    public static void DoubleLinkedListWithOverflow()
    {
        var head = new ListNode(9, new ListNode(9, new ListNode(9)));

        var solution = new Solution();
        var result = solution.DoubleIt(head);

        var equals = result.Equals(new ListNode(1, new ListNode(9, new ListNode(9, new ListNode(8)))));

        Assert.True(equals);
    }


    [Fact]
    public static void EqualShouldBeEqualTest()
    {
        var head = new ListNode(1, new ListNode(3));
        var equalHead = new ListNode(1, new ListNode(3));

        var result = head.Equals(equalHead);

        Assert.True(result);
    }



    [Fact]
    public static void EqualShouldNotBeEqualTest()
    {
        var head = new ListNode(1, new ListNode(4));
        var equalHead = new ListNode(1, new ListNode(3));

        var result = head.Equals(equalHead);

        Assert.False(result);
    }

}