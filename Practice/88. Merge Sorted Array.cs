/*
Example 1:

Input: nums1 = [1,2,3,0,0,0], m = 3, nums2 = [2,5,6], n = 3
Output: [1,2,2,3,5,6]
Explanation: The arrays we are merging are [1,2,3] and [2,5,6].
The result of the merge is [1,2,2,3,5,6] with the underlined elements coming from nums1.
Example 2:

Input: nums1 = [1], m = 1, nums2 = [], n = 0
Output: [1]
Explanation: The arrays we are merging are [1] and [].
The result of the merge is [1].
Example 3:

Input: nums1 = [0], m = 0, nums2 = [1], n = 1
Output: [1]
Explanation: The arrays we are merging are [] and [1].
The result of the merge is [1].
Note that because m = 0, there are no elements in nums1. The 0 is only there to ensure the merge result can fit in nums1.
*/
//O(m+n)
public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
       int i = m-1;
       int j = n-1;
       int k = (m+n)-1;

       while(i>=0 && j>=0){
        if(nums1[i] > nums2[j]){
            nums1[k] = nums1[i];
            k--;
            i--;
        }
        else{
            nums1[k] = nums2[j];
            j--;
            k--;
        }
       }

        while(j>=0){
            nums1[k] = nums2[j];
            k--;
            j--;
        }
    }
}



//O(n**2)
/*
public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        var n3 = new List<int>();
        for(int i =0; i<nums1.Length; i++){
            if((nums1[i] == 0) && ((i+n) == nums1.Length)){
                break;
            }
            n3.Add(nums1[i]);
        }
        foreach(var b in nums2){
            n3.Add(b);
        }
        for(int i=0; i<n3.Count-1; i++){
            int count = i;
            for(int j=i+1; j<n3.Count; j++){
                if(n3[i] > n3[j]){
                    var temp = n3[i];
                    n3[i] = n3[j];
                    n3[j] = temp;
                    count++;
                }
            }
        }
        for(int i = 0; i<nums1.Length; i++){
            nums1[i] = n3[i];
        }
    }
}
*/