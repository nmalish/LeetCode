public static class SolutionTests
{

    [Fact]
    public static void MaxNumberOfBalloons_Example1()
    {
        Solution solution = new();

        var actual = solution.MaxNumberOfBalloons("nlaebolko");

        Assert.Equal(1, actual);
    }

    [Fact]
    public static void MaxNumberOfBalloons_Example2()
    {
        Solution solution = new();

        var actual = solution.MaxNumberOfBalloons("loonbalxballpoon");

        Assert.Equal(2, actual);
    }

    [Fact]
    public static void MaxNumberOfBalloons_Example3()
    {
        Solution solution = new();

        var actual = solution.MaxNumberOfBalloons("leetcode");

        Assert.Equal(0, actual);
    }

    [Fact]
    public static void MaxNumberOfBalloons_Example4()
    {
        Solution solution = new();

        var actual = solution.MaxNumberOfBalloons("balon");

        Assert.Equal(0, actual);
    }
}
