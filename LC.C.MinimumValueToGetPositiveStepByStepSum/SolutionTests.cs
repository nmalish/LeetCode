

public static class SolutionTests {

    [Fact]
    public static void MinStartValue_Example1() {
        Solution solution = new ();

        var actual = solution.MinStartValue(new int[] { -3,2,-3,4,2 });

        Assert.Equal(5, actual);
    }

    [Fact]
    public static void MinStartValue_Example2() {
        Solution solution = new ();

        var actual = solution.MinStartValue(new int[] { 1, 2 });

        Assert.Equal(1, actual);
    }


    [Fact]
    public static void MinStartValue_Example3() {
        Solution solution = new ();

        var actual = solution.MinStartValue(new int[] { 1, -2, -3 });

        Assert.Equal(5, actual);
    }
}
