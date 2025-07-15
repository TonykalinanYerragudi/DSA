/*
Example 1:

Input: nums = [0,1,0,3,12]
Output: [1,3,12,0,0]
Example 2:

Input: nums = [0]
Output: [0]

*/
// optimal solution: O(n)
  public void MoveZeroes(int[] nums) {
        int l = 0;
        for(int i=0; i<nums.Length; i++){
            if(nums[i] != 0){
                int temp = nums[l];
                nums[l] = nums[i];
                nums[i] = temp;
                l++;
            }
        }
    }

  // //brute force O(n**2)
  // public void MoveZeroes(int[] nums) {
  //       for(int i=0; i<nums.Length-1; i++){
  //           for(int j=i+1; j<nums.Length; j++){
  //               if(nums[i]==0){
  //                   int temp = nums[i];
  //                   nums[i] = nums[j];
  //                   nums[j] = temp;
  //               }
  //           }
  //       }
  //   }

