public class Solution {
    public int[] NextGreaterElements(int[] nums) {
        int n = nums.Length;
        int[] result = new int[n];
        Stack<int> s = new Stack<int>();

        for(int i = 2 * n - 1; i >= 0; i--){
            result[i % n] = -1;
            while(s.Count > 0 && nums[i % n] >= s.Peek()){
                s.Pop();
            }

            while(s.Count > 0 && nums[i % n] < s.Peek()){
                result[i % n] = s.Peek();
                break;
            }

            s.Push(nums[i % n]);
        } 

        return result;
    }
}