namespace LC.C.MaxConsecutiveOnesIII;


public static class SolutionTests {

    [Fact]
    public static void LongestOnesExample1 () {
        Solution solution = new();
        
        var actual = solution.LongestOnes(new int[] { 1,1,1,0,0,0,1,1,1,1,0 }, 2);

        Assert.Equal(6, actual);

    }

    [Fact]
    public static void LongestOnesExample2 () {
        Solution solution = new();
        
        var actual = solution.LongestOnes(new int[] { 0,0,1,1,0,0,1,1,1,0,1,1,0,0,0,1,1,1,1 }, 3);

        Assert.Equal(10, actual);

    }
}
