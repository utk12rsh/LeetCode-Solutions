public class Solution {
    public int[] MaxSlidingWindow(int[] nums, int k) {
        int[] result = new int[nums.Length - k + 1];
        LinkedList<int> maxElement = new LinkedList<int>();

        for (int i = 0; i < k; i++)
        {
            while (maxElement.Count > 0 && nums[i] > maxElement.Last.Value)
            {
                maxElement.RemoveLast();
            }

            maxElement.AddLast(nums[i]);
        }

        result[0] = maxElement.First.Value;

        for (int j = k; j < nums.Length; j++)
        {
            if (nums[j - k] == maxElement.First.Value)
                maxElement.RemoveFirst();
            
            while (maxElement.Count > 0 && nums[j] > maxElement.Last.Value)
            {
                maxElement.RemoveLast();
            }

            maxElement.AddLast(nums[j]);
            result[j - k + 1] = maxElement.First.Value;
        }

        return result;
    }
}