namespace easy;

// 如果有一个自然数 a 能被自然数 b 整除，则称 a 为 b 的倍数， b 为 a 的约数。
// 几个自然数公有的约数，叫做这几个自然数的公约数。
// 公约数中最大的一个公约数，称为这几个自然数的最大公约数
public class nc151 {
    // 辗转相减方法求 最大公约数
    // public int gcd(int a, int b) {
    //     while (true) {
    //         if (a < b) {
    //             b -= a;
    //         } else if (a > b) {
    //             a -= b;
    //         } else if (a == b) {
    //             return a;
    //         }
    //     }
    // }
    
    
    // 辗转相除法求 最大公约数
    //  a % b = 0 ,最大公约数 b， 否则, b作为被除数， a % b(此处是求到的余数) 作为除数，继续求余
    public int gcd(int a, int b) {
        if (a % b == 0) return b;
        return gcd(b, a % b);
    }
}