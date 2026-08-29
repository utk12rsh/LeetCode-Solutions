public class Solution {
    public bool CanBouquetBePrepared(int[] bloomDay, int m, int k, int mid){
        int bouquetCount = 0;
        int flowerCount = 0;

        for(int i = 0; i < bloomDay.Length; i++){
            int daysNeeded = (int) Math.Ceiling((double) bloomDay[i] / mid);

            if(daysNeeded == 1 && flowerCount < k){
                flowerCount++;
            }
            else if(daysNeeded > 1){
                flowerCount = 0;
            }

            if(flowerCount == k && bouquetCount < m){
                bouquetCount++;
                flowerCount = 0;
            }
        }

        return bouquetCount >= m;
    }

    public int MinDays(int[] bloomDay, int m, int k) {
        if(m*k > bloomDay.Length){
            return -1;
        }
        
        int start = 1;
        int end = bloomDay.Max();
        int result = -1;

        while(start <= end){
            int mid = start + (end - start) / 2;

            if(CanBouquetBePrepared(bloomDay, m, k, mid)){
                result = mid;
                end = mid - 1;
            }
            else{
                start = mid + 1;
            }
        }
        return result;
    }
}