public class Solution {
    public bool CanDistanceBeCovered(int[] dist, double hour, int mid){
        double totalSpeed = 0;

        for(int i = 0; i <  dist.Length- 1; i++){
            int speedPerTrain = (int) Math.Ceiling((double) dist[i] / mid);
            totalSpeed += speedPerTrain;
        }

        double lastTrainSpeed = (double) dist[dist.Length - 1] / mid;
        totalSpeed += lastTrainSpeed;

        return totalSpeed <= hour;
    }

    public int MinSpeedOnTime(int[] dist, double hour) {
        int start = 1;
        int end = 10000000;
        int finalSpeed = -1;

        while(start <= end){
            int mid = start + (end - start) / 2;

            if(CanDistanceBeCovered(dist, hour, mid)){
                finalSpeed = mid;
                end = mid - 1;
            }
            else{
                start = mid + 1;
            }
        }

        return finalSpeed;
    }
}