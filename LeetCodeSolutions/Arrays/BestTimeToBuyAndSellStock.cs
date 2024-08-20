namespace LeetCodeSolutions.Arrays;

public class BestTimeToBuyAndSellStock
{
    public int MaxProfit(int[] prices)
    {
        if (prices.Length < 2)
        {
            return 0;
        }

        int maxProfit = 0;
        int minPrice = prices[0];

        for (int i = 0; i < prices.Length; i++)
        {
            var currentProfit = prices[i] - minPrice;

            if (currentProfit > maxProfit)
            {
                maxProfit = currentProfit;
            }

            if (prices[i] < minPrice)
            {
                minPrice = prices[i];
            }
        }

        return maxProfit;
    }
}