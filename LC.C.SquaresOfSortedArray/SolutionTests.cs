public class SolutionTests
{
    [Fact]
    public void SortedSquaresExample1()
    {
        var solution = new Solution();

        var input = new int[] { -4, -1, 0, 3, 10 };
        var output = new int[] { 0, 1, 9, 16, 100 };

        var actual = solution.SortedSquares(input);

        Assert.Equal(output, actual);
    }

    [Fact]
    public void SortedSquaresExample2()
    {
        var solution = new Solution();

        var input = new[] { -7, -3, 2, 3, 11 };
        var output = new[] { 4, 9, 9, 49, 121 };

        var actual = solution.SortedSquares(input);

        Assert.Equal(output, actual);
    }

    [Fact]
    public void SortedSquares_EmptyArray()
    {
        var solution = new Solution();

        var actual = solution.SortedSquares([]);

        Assert.Equal([], actual);
    }
}