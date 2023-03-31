namespace code.data_structure.array;

// 在每一天，你可以决定是否购买和/或出售股票。你在任何时候 最多 只能持有 一股 股票。你也可以先购买，然后在 同一天 出售
// 这次可以多次购买 ，但是必须卖出后才能再次购买，最多持有一股
public class lc122__Best_Time_to_Buy_and_Sell_Stock_II {
    public int MaxProfit(int[] prices) {
        int[] dp = new int[prices.Length];
        int min = prices[0]; // 任然需要暂存最小的那个值
        // 逆向思考，到某天 可以获得最大利润
        // 举例思考 12345 ，显然是 买了第二天立即卖 和 开始最后买卖一次收入一样
        // 134967 如果是9-1 + 7-6 = 9 but 买了之后直接卖  2+ 5+1 = 8
        // 14 25 37  结果是 3+ 3+4 = 10 ，或者 7-1 =6
        // 发现 最大利润在于 买了之后能卖就赶紧卖即可
        for (int i = 1; i < prices.Length ; i++) {
            if (min > prices[i]) {
                min = prices[i];
            } else {
                // 更新利润， 此时i- 1 和 i 都计算过必须pass ，min = i+1， 跳到 i+2(由于i每次都会加1)
                dp[i - 1] = prices[i] - min;
                // 当下一个值仍然遵循升序，则不需要跳跃两个index
                if (i+1 < prices.Length && prices[i] > prices[i + 1]) {
                    min = prices[i + 1];
                    i++;
                }else{
                    min = prices[i];
                }
            }
        }

        int res = 0;
        foreach (var i in dp) {
            res += i;
        }

        return res;
    }
}