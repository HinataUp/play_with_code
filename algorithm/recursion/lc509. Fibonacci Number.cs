namespace code.algorithm.recursion;

public class lc509__Fibonacci_Number {
    // 递归
    public int Fib(int n) {
        if (n <= 1) return 1;
        return Fib(n - 1) + Fib(n - 2);
    }

    // 状态转移
    public int Fib2(int n) {
        int a = 0, b = 1, c = 0;
        while (n-- > 0) {
            c = a + b;
            a = b;
            b = c;
        }

        return a;
    }
    // 数组dp
    public int Fib3(int n) {
        if (n <= 1) return n;
        var dp = new int[n + 1];
        dp[0] = 0;
        dp[1] = 1;
        for (int i = 2; i <= n; i++) {
            dp[i] = dp[i - 1] + dp[i - 2];
        }

        return dp[n];
    }
}