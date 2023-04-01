namespace code.data_structure.array;

// 保持原有顺序， 移动所有0到末尾 ，双指针算法

// 不用管谁在做在右边
// 直接ij指针 j 值为 0 则交换
public class lc283__Move_Zeroes {
    public void MoveZeroes(int[] nums) {
        for (int i = 0, j = 0; j < nums.Length; j++) {
            if (nums[j] == 0) continue;
            while(i < j && nums[i] != 0) i++;
            (nums[i], nums[j]) = (nums[j], nums[i]);
        }
        
        // 包含多余交换的 写法吗，但是逻辑正确， 因为只有在j指针遇到0时才两者拉开距离
        // 而一开始都是非0的话，两者都是在同一个位置，所以交换不会有影响（改变原先顺序）
        // for (int i = 0, j = 0; j < nums.Length; j++) {
        //     if (nums[j] != 0) {
        //         (nums[i], nums[j]) = (nums[j], nums[i]);
        //         i++;
        //     }
        // }
    }
}