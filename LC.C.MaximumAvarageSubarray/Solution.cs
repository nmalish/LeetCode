namespace LC.C.MaximumAvarageSubarray;


public class Solution {
    public double FindMaxAvarage(int[] nums, int k) {
        var sum = 0;

        for(int i = 0; i < k; i++) {
            sum += nums[i];
        }

        double ans = (double)sum / k;

        for (int i = k; i < nums.Length; i++) {
            sum = sum - nums[i - k] + nums[i];

            if ((double)sum / k > ans) {
                ans = (double)sum / k;
            }
        }

        return ans;
    }
}
