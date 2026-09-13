public class Solution {
    public int MaxArea(int[] height) {
        int start = 0;
        int end = height.Length - 1;
        int maxWater = 0;

        while(start < end)
        {
            int minHeight = 0;

            if (height[start] < height[end])
                minHeight = height[start];
            else
                minHeight = height[end];

            int area = (end - start) * minHeight;

            if (area > maxWater)
                maxWater = area;
            
            if (height[start] < height[end])
                start++;
            else
                end--;
        }

        return maxWater;
    }
}