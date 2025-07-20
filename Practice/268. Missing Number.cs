/*
Example 1:
Input: nums = [3,0,1]
Output: 2
Explanation:
n = 3 since there are 3 numbers, so all numbers are in the range [0,3]. 2 is the missing number in the range since it does not appear in nums.

Example 2:
Input: nums = [0,1]
Output: 2
Explanation:
n = 2 since there are 2 numbers, so all numbers are in the range [0,2]. 2 is the missing number in the range since it does not appear in nums.
*/

public class Solution {
    public int MissingNumber(int[] nums) {
        int requiredValue = 0;
        int actualValue = 0;
        for(int i=0; i<=nums.Length; i++){
            requiredValue += i;
        }

        for(int i=0; i<nums.Length; i++){
            actualValue += nums[i];
        }

        return requiredValue - actualValue;
    }
}