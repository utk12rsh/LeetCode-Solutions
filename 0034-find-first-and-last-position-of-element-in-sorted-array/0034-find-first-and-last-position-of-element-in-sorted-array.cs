public class Solution {
    public int[] SearchRange(int[] nums, int target) {
        int[] res = new int[2]{-1, -1};

        int start = 0;
        int end = nums.Length-1;
        while(start <= end){
            int mid = start + (end - start)/2;

            if(nums[mid] == target){
                res[0] = mid;
                end = mid - 1;
            }
            else if(nums[mid] < target){
                start = mid + 1;
            }
            else{
                end = mid -1;
            }
        }

        start = 0;
        end = nums.Length - 1;
        while(start <= end){
            int mid = start + (end - start)/2;

            if(nums[mid] == target){
                res[1] = mid;
                start = mid + 1;
            }
            else if(nums[mid] < target){
                start = mid + 1;
            }
            else{
                end = mid -1;
            }
        }

        return res;

    }
}