public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var elementToIndex = new Dictionary<int, int>();

        for(int i = 0; i < nums.Length; i++){
            int diff = target - nums[i];

            if(elementToIndex.ContainsKey(diff))
                return new int[] {elementToIndex[diff], i};
            
            elementToIndex[nums[i]] = i;
        }
        return new int[]{0, 0};
    }
}