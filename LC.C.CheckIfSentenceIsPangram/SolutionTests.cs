
public static class SolutionTests {
	[Fact]
	public static void CheckIfPangram_Example1 () {
		Solution solution = new ();
		string sentence = "thequickbrownfoxjumpsoverthelazydog";

		var actual = solution.CheckIfPangram(sentence);

		Assert.True(actual);
	}

	[Fact]
	public static void CheckIfPangram_Example2 () {
		Solution solution = new ();
		string sentence = "leetcode";

		var actual = solution.CheckIfPangram(sentence);

		Assert.False(actual);
	}
}
