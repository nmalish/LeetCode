namespace LC._206.ReverseLinkedList;

public class SolutionTests
{
    [Fact]
    public void Reverse3Nodes()
    {
        var solution = new Solution();
        var expected = new ListNode(3, new ListNode(2, new ListNode(1)));
        var head = new ListNode(1, new ListNode(2, new ListNode(3)));

        var result = solution.ReverseList(head);

        Assert.True(ListNodeEqual(expected, result));
    }


    [Fact]
    public void Reverse2Nodes()
    {
        var solution = new Solution();
        var expected = new ListNode(2, new ListNode(1));
        var head = new ListNode(1, new ListNode(2));

        var result = solution.ReverseList(head);

        Assert.True(ListNodeEqual(expected, result));
    }

    [Fact]
    public void CreationNodes()
    {
        var expected = new ListNode(1, new ListNode(2, new ListNode(3)));

        Solution solution = new();
        var result = solution.CreateNodes(new[] { 1, 2, 3 });

        Assert.True(ListNodeEqual(expected, result));
    }


    private static bool ListNodeEqual(ListNode? expected, ListNode? actual)
    {
        while (expected != null && actual != null)
        {
            if (expected.val != actual.val) return false;
            expected = expected.next;
            actual = actual.next;
        }

        return expected == null && actual == null;
    }
}