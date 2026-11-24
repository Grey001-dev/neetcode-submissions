public class Solution {
    public int MaxProfit(int[] prices) {
        int i=0;
        int j=1;
        int maxProfit=0;
        while(i<prices.Length-1){
            if(prices[j]-prices[i]>maxProfit){
                maxProfit=prices[j]-prices[i];
            }
            if(j==prices.Length-1){
                i++;
                j=i+1;
                continue;
            }
            j++;
        }
        return maxProfit;
    }
}
