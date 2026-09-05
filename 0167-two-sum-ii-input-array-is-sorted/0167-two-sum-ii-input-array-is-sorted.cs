public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int start = 0;
        int end = numbers.Length-1;

        while(start < end){
            int targetSum = numbers[start] + numbers[end];

            if(targetSum == target)
                return new int[] {start+1, end+1};
            else if(targetSum > target)
                end--;
            else
                start++;
        }
        return new int[] {-1, -1};
    }
}