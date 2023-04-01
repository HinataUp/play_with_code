namespace code.data_structure.array;

// 多数元素，出现次数大于n/2的元素（向下取整）
public class lc169__Majority_Element {
    public int MajorityElement(int[] nums) {
        // 摩尔投票法
        //  1. 两个不同的数，投票后会抵消
        //  2. 相同的数，投票后会增加
        int count = 0;
        int res = 0;
        foreach (var num in nums) {
            if (count == 0) {
                res = num;
            }

            if (res == num) {
                count++;
            } else {
                count--;
            }
        }

        return res;
    }
}