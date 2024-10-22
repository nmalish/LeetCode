
public static class SolutionTests
{

    [Fact]
    public static void RepeatedCharacter_Example1()
    {
        Solution solution = new();

        var actual = solution.RepeatedCharacter("abccbaacz");

        Assert.Equal('c', actual);
    }
}
