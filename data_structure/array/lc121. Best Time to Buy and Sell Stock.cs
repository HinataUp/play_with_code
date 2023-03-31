namespace code.data_structure.array;

// 买股票利润最大化
// 存dp 数组，dp[i] 表示第i天卖出的最大利润，第一天只能买入，所以dp[0] = 0，随后
// 当买入后 未来任何一天都可能卖出
public class lc121__Best_Time_to_Buy_and_Sell_Stock {
    public int MaxProfit(int[] prices) {
        int[] dp = new int[prices.Length];
        int min = prices[0];

        for (int i = 1; i < prices.Length; i++) {
            // 当前值比之前的最小值还小，更新最小值， 否则计算当前值与最小值的差值得出当天利润
            if (min > prices[i]) {
                min = prices[i];
            } else {
                dp[i] = prices[i] - min;
            }
        }

        int res = dp[0];
        for (int i = 0; i < dp.Length; i++) {
            res = Math.Max(res, dp[i]);
        }

        return res;
    }
}