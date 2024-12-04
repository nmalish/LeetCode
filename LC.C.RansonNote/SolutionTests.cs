public static class SolutionTests {
	[Fact]
	public static void CanConstruct_Example1 () {
		Solution solution = new();

		var actual = solution.CanConstruct("a", "b");

		Assert.False(actual);
	}

	[Fact]
	public static void CanConstruct_Example2 () {
		Solution solution = new();

		var actual = solution.CanConstruct("aa", "ab");

		Assert.False(actual);
	}	

	[Fact]
	public static void CanConstruct_Example3 () {
		Solution solution = new();

		var actual = solution.CanConstruct("aa", "aab");

		Assert.True(actual);
	}
}
