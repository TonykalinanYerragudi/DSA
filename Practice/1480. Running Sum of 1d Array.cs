public class Solution {
    public int[] RunningSum(int[] nums) {
        int count = nums[0];
        for(int i=1; i<nums.Length; i++){
            count += nums[i];
            nums[i] = count;
        }
        return nums;
    }
}