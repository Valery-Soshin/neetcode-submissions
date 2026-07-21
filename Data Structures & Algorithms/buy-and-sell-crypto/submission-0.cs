public class Solution {
    public int MaxProfit(int[] prices) {
        if (prices.Length is 0 or 1) {
            return 0;
        }

        var maxProfit = 0;

        var left = 0;
        var right = 1;

        while (right < prices.Length) {
            if (prices[left] > prices[right]) {
                left = right;
            } else {
                maxProfit = Math.Max(prices[right] - prices[left], maxProfit);
            }

            right++;
        }

        return maxProfit;
    }
}
