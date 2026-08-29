public class Solution {
    public int MySqrt(int x) {
        if (x == 0 || x == 1)
            return x;

        int left = 2;
        int right = x / 2;

        while (left <= right) {
            int mid = left + (right - left) / 2;
            long square = (long)mid * mid;

            if (square == x) 
                return mid;
            else if (square > x)
                right = mid - 1;
            else 
                left = mid + 1;
        }

        return right;
    }
}