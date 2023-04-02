namespace code.data_structure.array;

// 一个由整数各个数组成的非负 数组，给这个数+1
// 除了0 任何数都不会以0开头
// 1. 反向遍历， 末位+1，如果不是10，直接返回。否则进位，继续遍历，可以用stack 存中间状态，然后遍历存数组
// 2. 同样加法处理，不过不使用中间栈，而是依据进位存在创建数组 res ，最后阶段判断进位如果有先添加进位，否则直接范围数组

// 3. 特殊处理，思考到只有全 9 才有 1,0,0... 这种可能性，也就是说这种只需要new一个返回数组，设置第一位为1 即可
// 忽略前面的 遍历赋值了
public class lc66__Plus_One {
    public int[] PlusOne(int[] digits) {
        int carry = 1;
        for (int i = digits.Length - 1; i >= 0; i--) {
            int sum = digits[i] + carry;
            digits[i] = sum % 10;
            carry = sum / 10;
        }

        if (carry == 0) return digits;
        int[] res = new int[digits.Length + 1];
        res[0] = carry;
        return res;
    }
}