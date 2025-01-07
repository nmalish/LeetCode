namespace LC._125.ValidPalindrome;

public class SolutionTests
{
    [Theory]
    [InlineData("A man, a plan, a canal: Panama")]
    [InlineData("radar")]
    [InlineData(" ")]
    public static void ValidPalindrome(string value)
    {
        Solution solution = new();
        var actual = solution.IsPalindrome(value);

        Assert.True(actual);
    }



    [Theory]
    [InlineData("something")]
    [InlineData("palindrome")]
    [InlineData("race a car")]
    public static void NotValidPalindrome(string value)
    {
        Solution solution = new();
        var actual = solution.IsPalindrome(value);

        Assert.False(actual);
    }
}