public class Solution {
    public double FindMaxAverage(int[] nums, int k) {
        int sum = 0;
        
        for(int i = 0; i < k; i++){
            sum += nums[i];
        }

        double maxAverage = (double) sum/k;

        int j = 1;

        while(j <= nums.Length - k){
            sum = sum - nums[j - 1];
            sum = sum + nums[j + (k-1)];

            double average = (double) sum/k;

            if(average > maxAverage)
                maxAverage = average;
            
            j++;
        }

        return maxAverage;
    }
}