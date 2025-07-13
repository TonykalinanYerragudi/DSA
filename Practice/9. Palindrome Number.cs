public class Solution {
    public bool IsPalindrome(int x) {
        if(x < 0){
            return false;
        }
        int copyX = x;
        int reversedNum = 0;
        while(x > 0){
            int temp = x % 10;
            reversedNum = (reversedNum * 10) + temp;
            x = x/10;
        }
        bool value = (reversedNum == copyX) ? true : false;
        return value;
    }
}