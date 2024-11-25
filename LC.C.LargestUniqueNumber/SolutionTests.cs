public static class SolutionTests
{

    [Fact]
    public static void LargestUniqueNumber_Example1()
    {
        Solution solution = new();

        var actual = solution.LargestUniqueNumber(new int[] { 5, 7, 3, 9, 4, 9, 8, 3, 1 });

        Assert.Equal(8, actual);
    }

    [Fact]
    public static void LargestUniqueNumber_Example2()
    {
        Solution solution = new();

        var actual = solution.LargestUniqueNumber(new int[] { 9, 9, 8, 8 });

        Assert.Equal(-1, actual);
    }
}
