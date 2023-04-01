namespace code.data_structure.array;

// dp 要重点考虑 怎么把状态转移，过去计算的状态，转移到当前状态
public class lc123__Best_Time_to_Buy_and_Sell_Stock_III {
    public int MaxProfit(int[] prices) {
        int len = prices.Length;
        int buy1 = -prices[0], sell1 = 0;
        int buy2 = -prices[0], sell2 = 0;
        // 这个思路在于将 第一次的利润空间 最大化，然后转接给第二次，
        // 并且是遍历中的每次 都将sell1 状态给到了sell2 ，因此达到一次遍历，全局最优
        for (int i = 0; i < len; i++) {
            // 购入为负数，取最大的负数（接近0更大，利润高）
            buy1 = Math.Max(buy1, -prices[i]);
            // 第一次售卖 取已经 卖的利润 和 当前售出价 - 买入价格 之间的 最大值 
            sell1 = Math.Max(sell1, buy1 + prices[i]);
            
            // 第二次售卖，在第一次的基础上获取更高的利润，因此第二次认为是第一次的利润 - 当前买入价格
            buy2 = Math.Max(buy2, sell1 - prices[i]);
            // 第二次售卖，取已经 卖的利润 和 当前售出价 - 买入价格 之间的 最大值
            sell2 = Math.Max(sell2, buy2 + prices[i]);
        }
        return sell2;
    }


    // 这个思路不对因为 当 1,2,4,2,5,7,2,4,9,0  7-1+9-2 = 13 
    // 因此考虑欠佳
    // public int MaxProfit(int[] prices) {
    //     int low = 0;
    //     int high = 0;
    //     int min = prices[0];
    //     int res = 0;
    //     for (int i = 1; i < prices.Length; i++) {
    //         // 最小值 大于当前index的值，更新最小值
    //         if (min > prices[i]) {
    //             min = prices[i];
    //         } else if (i + 1 < prices.Length) {
    //             if (prices[i] >= prices[i + 1]) {
    //                 low = Math.Max(low, prices[i] - min);
    //                 min = prices[i + 1];
    //                 i++;
    //             }
    //         } else {
    //             // i+1越界时候考虑 i 的值是否可以更新low
    //             low = Math.Max(low, prices[i] - min);
    //         }
    //
    //         if (low > high) {
    //             (low, high) = (high, low);
    //         }
    //     }
    //
    //     res = low + high;
    //     return res;
    // }
}