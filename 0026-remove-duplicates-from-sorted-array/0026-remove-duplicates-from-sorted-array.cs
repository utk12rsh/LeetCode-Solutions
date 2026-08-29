public class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
       int pointer = 1;
       for(int j = 1; j < nums.Length; j++){
        if(nums[j] != nums[pointer-1]){
            nums[pointer] = nums[j];
            pointer++;
        }
       }
       return pointer;
    }
}