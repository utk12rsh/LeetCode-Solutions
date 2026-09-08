public class Solution {
    public int LongestOnes(int[] nums, int k) {
        int left = 0;
        int zeroCount = 0;
        int maxConsecutiveOnes = 0;
        int length = 0;
        for(int right = 0; right < nums.Length; right++){
            // Observe if element is zero
            if(nums[right] == 0)
                zeroCount++;
            
            // Our Window is valid, we should calculate the length now
            if(zeroCount == k){
                length = (right - left) + 1;

                if(length > maxConsecutiveOnes)
                    maxConsecutiveOnes = length;
            }

            // If Window, Became Invalid, Then first we will make it valid and then calculate again as was done in case of valid

            while(zeroCount > k){
                if(nums[left] == 0)
                    zeroCount--;
                
                left++;
            }

            length = (right - left) + 1;

            if(length > maxConsecutiveOnes)
                maxConsecutiveOnes = length;
        }

        return maxConsecutiveOnes;
    }
}