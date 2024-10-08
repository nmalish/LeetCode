
public class Solution {

    public int MinStartValue(int[] nums) {
        int n = nums.Length;
        int min = nums[0];
        int sum = nums[0];
        for(int i = 1; i < n; i++) {
            sum += nums[i];
            if (sum < min) {
                min = sum; 
            }
        }

        return min >= 1 ? 1 : 1 - min;
    }


    public int MinStartValue1(int[] nums) {
        int n = nums.Length;
        int min = nums[0];
        int[] prefix = new int[n];

        prefix[0] = nums[0];
        for(int i = 1; i < n; i++) {
            prefix[i] = prefix[i - 1] + nums[i];

            if (prefix[i] < min) {
                min = prefix[i];
            }
        }

        if (min < 1) {
            return 1 - min;
        }


        return 1;
    }
}
