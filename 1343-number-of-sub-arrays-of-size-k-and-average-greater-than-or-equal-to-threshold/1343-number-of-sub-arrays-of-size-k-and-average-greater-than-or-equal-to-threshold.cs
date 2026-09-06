public class Solution {
    public int NumOfSubarrays(int[] arr, int k, int threshold) {
        int sum = 0;
        int count = 0;

        for(int i = 0; i < k; i++){
            sum += arr[i];
        }

        double average = (double) sum / k;

        if(average >= threshold)
            count++;

        for(int j = 1; j <= arr.Length - k; j++){
            sum -= arr[j - 1];
            sum += arr[(j + k) - 1];

            average = (double) sum / k;

            if(average >= threshold)
                count++;
        }

        return count;
    }
}