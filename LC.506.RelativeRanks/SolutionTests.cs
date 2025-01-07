public static class SolutionTests
{
    [Fact]
    public static void CorrectRank()
    {
        var solution = new Solution();

        var result = solution.FindRelativeRanks(new[] { 10, 3, 8, 9, 4 });

        Assert.Equal(new[] { "Gold Medal", "5", "Bronze Medal", "Silver Medal", "4" }, result);
    }
}
