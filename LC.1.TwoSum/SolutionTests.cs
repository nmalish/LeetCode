
public static class SolutionTests {
	[Fact]
	public static void TwoSum_Example1() {
		Solution solution = new();

		var actual = solution.TwoSum(new int[] { 2, 7, 11, 15 }, 9);
 		Array.Sort(actual);

		Assert.Equal(new int[] { 0, 1 }, actual);
	}

	[Fact]
	public static void TwoSum_Example2() {
		Solution solution = new();

		var actual = solution.TwoSum(new int[] { 3, 2, 4 }, 6);
 		Array.Sort(actual);

		Assert.Equal(new int[] { 1, 2 }, actual);
	}

	[Fact]
	public static void TwoSum_Example3() {
		Solution solution = new();

		var actual = solution.TwoSum(new int[] { 3, 3 }, 6);
 		Array.Sort(actual);

		Assert.Equal(new int[] { 0, 1 }, actual);
	}

	[Fact]
	public static void TwoSum_Example4() {
		Solution solution = new();

		var actual = solution.TwoSum(new int[] { 1,1,1,1,1,4,1,1,1,1,1,7,1,1,1,1,1 }, 11);
 		Array.Sort(actual);
		
		Assert.Equal(new int[] { 5, 11 }, actual);
	}


}
