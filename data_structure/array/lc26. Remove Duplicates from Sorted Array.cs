namespace code.data_structure.array;

// 26. 删除有序数组中的重复项
// 原地删除重复数字， 数组本身升序，要求返回删除后的数组长度，且数组是不重复的数字
// 双指针，同时出发，同起点， 一个指针遍历数组，前后不同时 ，慢指针+1，快指针交换（交换之后慢指针不动 只动快指针）
// 1 1122233
// 1 2 112233

public class lc26__Remove_Duplicates_from_Sorted_Array {
    public int RemoveDuplicates(int[] nums) {
        int index = 0;
        for (int j = 0; j < nums.Length; j++) {
            if (nums[j] != nums[index]) {
                index++;
                (nums[index], nums[j]) = (nums[j], nums[index]);
            }
        }

        return index + 1;
    }
}