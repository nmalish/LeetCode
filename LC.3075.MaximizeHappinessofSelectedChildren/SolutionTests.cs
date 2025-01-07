public class SolutionTests
{
    [Fact]
    public void Test1()
    {
        var solution = new Solution();

        var result = solution.MaximumHappinessSum(new int[] { 1, 2, 3 }, 2);

        Assert.Equal(4, result);
    }

    [Fact]
    public void Test2()
    {
        var solution = new Solution();

        var result = solution.MaximumHappinessSum(new int[] { 7, 50, 3 }, 3);

        Assert.Equal(57, result);
    }
}