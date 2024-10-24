
public static class SolutionTests
{
    [Fact]
    public static void CountElements_Example1()
    {
        Solution solution = new();

        var actual = solution.CountElements(new int[] { 1, 2, 3 });

        Assert.Equal(2, actual);
    }

    [Fact]
    public static void CountElements_Example2()
    {
        Solution solution = new();

        var actual = solution.CountElements(new int[] { 1, 1, 3, 3, 5, 5, 7, 7 });

        Assert.Equal(0, actual);
    }
}
