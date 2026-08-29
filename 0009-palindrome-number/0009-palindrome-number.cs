public class Solution {
    public bool IsPalindrome(int x) {
        int original = x;
        int reversed = 0;

        if(x < 0){
            return false;
        }

        if(x == 0){
            return true;
        }

        while(x > 0){
            int remainder = x % 10;
            reversed = (reversed * 10) + remainder;
            x = x / 10;
        }

        if(original == reversed){
            return true;
        }
        
        return false;
    }
}