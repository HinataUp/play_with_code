namespace code.data_structure.array;

// 给你一个整数数组 nums 和两个整数 k 和 t 。
// 请你判断是否存在 两个不同下标 i 和 j，使得 abs(nums[i] - nums[j]) <= t ，同时又满足 abs(i - j) <= k
public class lc220_Contains_Duplicate_III {
    public bool ContainsNearbyAlmostDuplicate(int[] nums, int indexDiff, int valueDiff) {
        // 要求是找到两个数差值小于t  同时满足下标差值小于k
        // 常规思路不好做，换个思路  根据下标设置一个区间 只考虑符合 indexDiff区间的 内数的  差值是否符合即可
        for (int i = 0; i < nums.Length; i++) {
            // j从i前面一个位置出发比对
            int j = i + 1;
            while (j <= i + indexDiff && j < nums.Length) {
                if (Math.Abs(nums[i] - nums[j]) <= valueDiff) return true;
                j++;
            }
        }

        return false;
    }
}