namespace code.algorithm.recursion;

public class lc326__Power_of_Three {
    public bool IsPowerOfThree(int n) {
        // 幂运算 判断是不是3的k次方 有值 1 3 9 27...

        if (n == 0) return false;
        if (n == 1) return true;
        if (n % 3 == 0) return IsPowerOfThree(n / 3);
        return false;
    }
}