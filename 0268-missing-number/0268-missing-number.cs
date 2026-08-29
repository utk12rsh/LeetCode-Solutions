public class Solution {
    public int MissingNumber(int[] nums) {
        int n = nums.Length;
        int totalSum = (n*(n+1))/2;
        int missedSum = 0;
        for(int i = 0; i < nums.Length; i++){
            missedSum += nums[i];
        }

        return totalSum - missedSum;
    }
}