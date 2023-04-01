namespace code.data_structure.array;

// 只出现一次的数字，数是有正有负, 至少有一个数只出现一次，其他数都出现偶数次
public class lc136__Single_Number {
    // 第一种sort一下，然后遍历，如果相邻的两个数不相等，那么就是这个数 （暂不举例）
    public int SingleNumber(int[] nums) {
        Array.Sort(nums);
        for (int i = 0; i < nums.Length - 1; i += 2) {
            if (nums[i] != nums[i + 1]) {
                return nums[i];
            }
        }

        return nums[nums.Length - 1];
    }


    // 第二种hashmap，如果存在就删除，最后剩下的就是这个数
    public int SingleNumber2(int[] nums) {
        HashSet<int> set = new HashSet<int>();
        foreach (var num in nums) {
            if (set.Contains(num)) {
                set.Remove(num);
            } else {
                set.Add(num);
            }
        }

        return set.First();
    }

    // 第三种异或，相同的数异或为0，0和任何数异或为任何数，所以最后剩下的就是这个数
    public int SingleNumber3(int[] nums) {
        int res = 0;
        foreach (var num in nums) {
            res ^= num;
        }

        return res;
    }
}