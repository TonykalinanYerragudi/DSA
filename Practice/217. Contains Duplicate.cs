/*
Example 1:

Input: nums = [1,2,3,1]

Output: true

Explanation:

The element 1 occurs at the indices 0 and 3.

Example 2:

Input: nums = [1,2,3,4]

Output: false

Explanation:

All elements are distinct.
*/

public bool ContainsDuplicate(int[] nums) {
        var map = new Dictionary<int, int>();

        for(int i=0; i<nums.Length; i++){
            if(map.ContainsKey(nums[i])){
                return true;
            }
            map[nums[i]] = 1;
        }
        return false;
    }