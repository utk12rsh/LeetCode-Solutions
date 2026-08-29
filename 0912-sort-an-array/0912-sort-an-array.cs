public class Solution {
    public int[] SortArray(int[] nums) {
        if(nums.Length <= 1){
            return nums;
        }

        int mid = nums.Length/2;

        int[] left = new int[mid];
        int[] right = new int[nums.Length-mid];

        for(int i = 0; i < mid; i++){
            left[i] = nums[i];
        }

        for(int j = mid; j < nums.Length; j++){
            right[j - mid] = nums[j];
        }

        SortArray(left);
        SortArray(right);
        return MergeTwoSorted(nums, left, right);
    }

    public static int[] MergeTwoSorted(int[] nums, int[] left, int[] right){
        int e1 = 0, e2 = 0, k = 0;
        while(e1 < left.Length && e2 < right.Length){
          if(left[e1] < right[e2]){
            nums[k] = left[e1];
            k++;
            e1++;
          }
          else{
            nums[k] = right[e2];
            k++;
            e2++;
          }
        }

        while(e1 < left.Length){
            nums[k] = left[e1];
            k++;
            e1++;
        }

        while(e2 < right.Length){
            nums[k] = right[e2];
            k++;
            e2++;
        }

        return nums;
    }
}