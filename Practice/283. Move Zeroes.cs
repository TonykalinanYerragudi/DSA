/*
Example 1:

Input: nums = [0,1,0,3,12]
Output: [1,3,12,0,0]
Example 2:

Input: nums = [0]
Output: [0]

*/
  //brute force O(n**2)
  public void MoveZeroes(int[] nums) {
        for(int i=0; i<nums.Length-1; i++){
            for(int j=i+1; j<nums.Length; j++){
                if(nums[i]==0){
                    int temp = nums[i];
                    nums[i] = nums[j];
                    nums[j] = temp;
                }
            }
        }
    }

