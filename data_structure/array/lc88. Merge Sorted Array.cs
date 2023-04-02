namespace code.data_structure.array;

// 合并两个有序数组
// nums1 大 ，存nums 1 中
// 1. 一般合并，两个正向遍历，比较大小，放入新数组
// 2. 怎么不新建数组（原地合并到nums1）？，逆向遍历， 比较大小，打的放到nums1的最后面即可
// 时间哦：O(m+n) 空间：O(1)
public class lc88__Merge_Sorted_Array {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        int index = m + n - 1;
        if (m == 0 && n != 0) {
            for (int k = 0; k < n; k++) {
                nums1[k] = nums2[k];
            }

            return;
        } else if (n == 0) return;

        int i = m - 1, j = n - 1;
        for (; i >= 0 && j >= 0; index--) {
            if (nums1[i] < nums2[j]) {
                nums1[index] = nums2[j];
                j--;
            } else {
                nums1[index] = nums1[i];
                i--;
            }
        }

        if (j == 0) return;
        while (j >= 0) {
            nums1[j] = nums2[j];
            j--;
        }
    }
}