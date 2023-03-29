namespace easy;

// 斐波那契数列
public class nc65 {
    public int Fibonacci(int n) {
        int a = 0, b = 1, c = 0;
        for (int i = 0; i < n; i++) {
            c = b + a;
            b = a;
            a = c;
        }

        return c;
        // write code here
    }
}