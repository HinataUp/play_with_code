namespace code.data_structure.array;

// 数组长度n ，找出数组内所有消失的数字 1-n 内不含有的数字
// 数字都是非负数 整数
public class lc448__Find_All_Numbers_Disappeared_in_an_Array {
    public IList<int> FindDisappearedNumbers(int[] nums) {
        int len = nums.Length;
        IList<int> res = new List<int>();
        // 用hash去重
        HashSet<int> set = new HashSet<int>();
        for (int i = 0; i < len; i++) {
            set.Add(nums[i]);
        }

        for (int i = 0; i < len; i++) {
            if (set.Contains(i)) set.Remove(i);
            else {
                res.Add(i);
            }
        }

        return res;
    }

    // 优化空间
    // 根据存在的元素 设置对应的下边为负数， 然后看二次遍历，正数值的 下标就是消失的数字 （很巧妙哦）
    public IList<int> FindDisappearedNumbers2(int[] nums) {
        int len = nums.Length;
        IList<int> res = new List<int>();
        for (int i = 0; i < len; i++) {
            int index = Math.Abs(nums[i]) - 1;
            if (nums[index] > 0) {
                nums[index] *= -1;
            }
        }

        for (int i = 0; i < len; i++) {
            if (nums[i] > 0) {
                res.Add(i + 1);
            }
        }

        return res;
    }
    
    
}