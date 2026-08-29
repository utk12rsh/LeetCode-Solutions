public class Solution {
    public bool IsSmallestDivisor(int[] nums, int threshold, int mid){
        int totalSum = 0;

        for(int i = 0 ; i < nums.Length; i++){
            int dividedValue  = (int) Math.Ceiling((double) nums[i] / mid);
            totalSum += dividedValue;
        }

        return totalSum <= threshold;
    }

    public int FindMaximum(int[] nums){
        int maxValue = nums[0];

        for(int i = 1; i < nums.Length; i++){
            if(nums[i] > maxValue)
                maxValue = nums[i];
        }

        return maxValue;
    }

    public int SmallestDivisor(int[] nums, int threshold) {
        int start = 1;
        int end = FindMaximum(nums);

        while(start < end){
            int mid = start + (end - start) / 2;

            if(IsSmallestDivisor(nums, threshold, mid)){
                end = mid;
            }
            else{
                start = mid + 1;
            }
        }

        return end;
    }
}