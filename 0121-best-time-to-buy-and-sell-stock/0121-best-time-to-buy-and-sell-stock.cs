public class Solution {
  public int MaxProfit(int[] prices) {
    int maxProfit = 0;
    int minSoFar = prices[0];
    for(int i = 0; i < prices.Length; i++){
        if(prices[i] < minSoFar){
            minSoFar = prices[i];
        }
        else if(prices[i] - minSoFar > maxProfit){
            maxProfit = prices[i] - minSoFar;
        }
    }
    return maxProfit;
  }
}