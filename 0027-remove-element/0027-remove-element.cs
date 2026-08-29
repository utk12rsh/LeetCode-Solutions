public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int pointer = 0;
        for(int i = 0; i < nums.Length; i++){
            if(nums[i] != val){
                int temp = nums[i];
                nums[i] = nums[pointer];
                nums[pointer] = temp;
                pointer++;
            }
        }
        return pointer;
    }
}