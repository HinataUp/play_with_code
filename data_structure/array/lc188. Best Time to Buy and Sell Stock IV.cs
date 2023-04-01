namespace code.data_structure.array;

// 借用123题 的思想
public class lc188__Best_Time_to_Buy_and_Sell_Stock_IV {
    public int MaxProfit(int k, int[] prices) {
        int len = prices.Length;
        int[] buy = new int[k + 1];
        int[] sell = new int[k + 1];
        // 赋值为最小值
        for (int i = 0; i <= k; i++) {
            buy[i] = -prices[0];
            sell[i] = 0;
        }

        // 二维数组存储状态，第一维是买入，第二维是卖出
        for (int i = 0; i < len; i++) {
            for (int j = 1; j <= k; j++) {
                // 状态转移， 买入 = 已有利润 - 当前价格
                // 状态转移， 卖出 = 购入花费的剩余 + 当前价格
                buy[j] = Math.Max(buy[j], sell[j - 1] - prices[i]);
                sell[j] = Math.Max(sell[j], buy[j] + prices[i]);
            }
        }

        return sell[k];
    }
}