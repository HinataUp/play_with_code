namespace code.data_structure.array;

// 元素重复，且下标差小于等于（绝对值） k
public class lc219_Contains_Duplicate_II {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        Dictionary<int, int> dic = new Dictionary<int, int>();
        for (int i = nums.Length - 1; i >= 0; i--) {
            if (dic.ContainsKey(nums[i])) {
                // 获取到对应的 key 的value 然后和i 相减判断
                if (dic[nums[i]] - i <= k) return true;
                // 更新下标 ，因为可能有多个重复
                dic[nums[i]] = i;
            } else {
                //值不存在就插入
                dic.Add(nums[i], i);
            }
        }

        return false;
    }
}