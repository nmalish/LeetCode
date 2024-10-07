namespace LC.C.MaximumAvarageSubarray;


public static class SolutionTests {
    
    [Fact]
    public static void FindMaxAvarage_Example1 (){
        var solution = new Solution();
        var input = new int[] { 1, 12, -5, -6, 50, 3 };

        var actual = solution.FindMaxAvarage(input, 4);
        double expected = 12.75;

        Assert.Equal(expected, actual);
    }

    [Fact]
    public static void FindMaxAvarage_Example2 (){
        var solution = new Solution();
        var input = new int[] { 5 };

        var actual = solution.FindMaxAvarage(input, 1);
        double expected = 5;

        Assert.Equal(expected, actual);
    }

    [Fact]
    public static void FindMaxAvarage_Example3 (){
        var solution = new Solution();
        var input = new int[] { 1,0,1,4,2 };

        var actual = solution.FindMaxAvarage(input, 4);
        double expected = 1.75;

        Assert.Equal(expected, actual);
    }
}
