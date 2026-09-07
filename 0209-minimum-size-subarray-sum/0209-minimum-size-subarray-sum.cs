public class Solution
{
    public int MinSubArrayLen(int target, int[] nums)
    {
        int sum = 0;
        int minLength = int.MaxValue;
        int index = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];

            while (sum >= target)
            {
                int length = i - index + 1;

                if (length < minLength)
                    minLength = length;

                sum -= nums[index];
                index++;
            }
        }

        return minLength == int.MaxValue ? 0 : minLength;
    }
}