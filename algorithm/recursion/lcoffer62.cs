namespace code.algorithm.recursion;

public class lcoffer62 {
    public int LastRemaining(int n, int m) {
        // 1. 有环存在，2每次删除之后环大小会变化，3.直到环大小为1return  每次删除后从下一个位置开始计数
        // 数字限制 1 <= n <= 10^5
        // 递归
        if (n == 1) return 0;
        int x = LastRemaining(n - 1, m); // 递归最深层返回0，后面就不会再执行最上面的递归的而是渔鸥下下方的return返回值作为替代
        // 并且下方返回值的x 或使用每次 递归的 回归时带出来的参数
        return (m + x) % n; // 从下一个数字开始计数
    }
}