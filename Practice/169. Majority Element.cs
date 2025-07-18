/*
Example 1:

Input: nums = [3,2,3]
Output: 3
Example 2:

Input: nums = [2,2,1,1,1,2,2]
Output: 2

*/


//O(n)
public class Solution {
    public int MajorityElement(int[] nums) {
        int n = nums.Length;
        var map = new Dictionary<int, int>();

        for(int i=0; i<nums.Length; i++){
            if(map.ContainsKey(nums[i])){
                map[nums[i]]++;
                continue;
            }
            map[nums[i]] = 1;
        }
        int max = (n/2) + 1;
        int value = 0;
        int key = 0;
        foreach(var dt in map){
            if(dt.Value >= max && dt.Value > value){
                value = dt.Value;
                key = dt.Key;
            }
        }
        return key;
    }
}