/*
Example 1:

Input: nums = [2,7,11,15], target = 9
Output: [0,1]
Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].

Example 2:

Input: nums = [3,2,4], target = 6
Output: [1,2]
*/

public int[] TwoSum(int[] nums, int target) {
       var map = new Dictionary<int, int>();
       for(int i=0; i<nums.Length; i++){
        int sub = target - nums[i];

        if(map.ContainsKey(sub)){
            return [map[sub], i];
        }
        map[nums[i]] = i;
       }
       return [0, 0];
    }
    // 1 ms
    // using hashmap or dictionary
    // time complexity O(n)
    // space complexity O(n)


// public class Solution {
//     public int[] TwoSum(int[] nums, int target) {
       
//        int firstIndex = 0;
//        int secondIndex = 0;

//        while(firstIndex <= nums.Length){
//         if(firstIndex == secondIndex){
//             secondIndex++;
//             if(secondIndex >= nums.Length){
//             firstIndex++;
//             secondIndex = firstIndex+1;
//             }
//             continue;
//         }
//         if((nums[firstIndex] + nums[secondIndex]) == target){
//             return [firstIndex, secondIndex];
//         }
//         secondIndex++;
//         if(secondIndex >= nums.Length){
//             firstIndex++;
//             secondIndex = firstIndex+1;
//         }
//        }
//        return [0,0];
//     }
// }
// 44ms
// //Two pointer o(n ** 2)