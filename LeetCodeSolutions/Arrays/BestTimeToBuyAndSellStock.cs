namespace LeetCodeSolutions.Arrays;

/// <summary>
/// Runtime complexity: 0(n)
/// Space complexity: 0(1)
/// Runtime: 300ms
/// Memory: 57.48 MB
/// Solution pattern: Two Pointers
/// Level: Easy
/// </summary>
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