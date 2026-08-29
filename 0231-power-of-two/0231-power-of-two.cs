public class Solution {
    public bool IsPowerOfTwo(int n) {
        if(n == 1){
            return true;
        }

        if(n % 2 != 0 || n < 1){
            return false;
        }
       return IsPowerOfTwo(n/2);
    }
}