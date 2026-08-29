public class Solution {
    public int FindMin(int[] nums) {
        int start = 0;
        int end = nums.Length - 1;
        int min = int.MaxValue;

        while(start <= end){
            int mid = start + (end - start) / 2;

            if(nums[start] <= nums[mid]){
                if(nums[start] < min){
                    min = nums[start];
                }
               start = mid + 1;
            }
            else{
                if(nums[mid] < min){
                    min = nums[mid];
                }
                end = mid - 1;
            }
        }
        return min;
    }
}