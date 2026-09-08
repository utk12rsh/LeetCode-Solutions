public class Solution {
    public long MaximumSubarraySum(int[] nums, int k) {
        var freq = new Dictionary<int, int>();
        long sum = 0; long maxSum = 0;

        for(int i = 0; i < k; i++){
            sum += nums[i];

            if(!freq.ContainsKey(nums[i]))
                freq[nums[i]] = 0;
            
            freq[nums[i]]++;
        }

        if(freq.Count == k)
            maxSum = Math.Max(maxSum, sum);

        for(int j = k; j < nums.Length; j++){
            sum += nums[j];

            if(!freq.ContainsKey(nums[j]))
                freq[nums[j]] = 0;
            
            freq[nums[j]]++;

            sum -= nums[j - k];
            freq[nums[j - k]]--;

            if(freq[nums[j - k]] == 0)
                freq.Remove(nums[j - k]);
            
            if(freq.Count == k)
                maxSum = Math.Max(maxSum, sum);
        }
        return maxSum;
    }
}