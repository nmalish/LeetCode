
public class Solution {
	public int[] TwoSum(int[] nums, int target) {
		Dictionary<int, int> dic = new();
		
		int[] res = new int[2];
		for (int i = 0; i < nums.Length; i++) {
			if (dic.TryGetValue(target - nums[i], out int value)){
				return new int[] { i, value };
			} else {
				dic.TryAdd(nums[i], i);
			}
		}

		return default;
	}
}
