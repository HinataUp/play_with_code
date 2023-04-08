namespace code.algorithm.recursion; 

public class lc231__Power_of_Two {
    public bool IsPowerOfTwo(int n) {
        if (n == 0) return false;
        if (n == 1) return true;
        if (n % 2 == 1) return false;
        return IsPowerOfTwo(n / 2);
    }
}