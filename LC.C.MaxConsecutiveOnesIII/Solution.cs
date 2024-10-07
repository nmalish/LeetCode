namespace LC.C.MaxConsecutiveOnesIII;


public class Solution {
    public int LongestOnes(int[] nums, int k) {
       int res = 0; 
       int current = 0;
       int left = 0;

       for(int right = 0; right < nums.Length; right++) {
         if (nums[right] == 0) {
            current += 1;
         }

         while (current > k) {
            if(nums[left] == 0) {
               current -= 1;
            }
            left++;
         }

         res = res > right - left + 1 ? res : right - left + 1;
       }

        return res;
    }
}
