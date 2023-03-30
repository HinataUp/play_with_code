namespace code.data_structure.array;

// 给你一个整数数组 nums ，请你找出一个具有最大和的连续子数组（子数组最少包含一个元素），返回其最大和
// 一个tmp 暂存目前 子数组之和
// 考虑到什么时候 剔除首元素，什么时候可以增加新元素呢？ 
// 首元素负数 直接丢弃，pass ---- 找到第一个正数，然后看后面增加数字进来的二重循环，内部不断增加值，如果大于
// 要求元素是连续的
// 暴力的思想，就是存值，从某个index 出发开始，最大值的序列和 是多少
// 题目明确nums 至少有一个数
public class lc53__Maximum_Subarray {
    //暴力算法 ，一般超时
    // public int MaxSubArray(int[] nums) {
    //     int res = 0;
    //     for (int i = 0; i < nums.Length-1; i++) {
    //         int tmp = nums[i];
    //         for (int j = i + 1; j < nums.Length; j++) {
    //             tmp += nums[i];
    //             if (tmp > res) res = tmp;
    //         }
    //     }
    //
    //     return res;
    // }

    // 优化,第一遍遍历是无法避免的，只能在第二遍上下功夫了，因此思考下，从某个数开始应该不需要再进入第二次循环
    public int MaxSubArray(int[] nums) {
        int[] dp = new int[nums.Length];
        dp[0] = nums[0];
        for (int i = 1; i < nums.Length; i++) {
            // dp 数组存储 一个连续的和，0 是第一个数，1 从 0到1 ，2是0 到2的和
            // 但是 i-1索引的值 为正数，才考虑加上之歌值，否则 直接取nums的值
            if (dp[i - 1] > 0) {
                dp[i] = dp[i - 1] + nums[i];
            } else {
                dp[i] = nums[i];
            }
        }

        // 遍历dp数组寻找到最终答案
        int res = dp[0];
        for (int i = 0; i < dp.Length; i++) {
            res = Math.Max(res, dp[i]);
        }

        return res;
    }
}