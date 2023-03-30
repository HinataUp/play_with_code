namespace code.data_structure.array; 

public class lc2_Contains_Duplicate {
    public bool ContainsDuplicate(int[] nums) {
        Dictionary<int,int> dic = new Dictionary<int, int>();
        for(int i =0 ; i < nums.Length; i++) {
            if (dic.ContainsKey(nums[i])) return true;
            dic.Add(nums[i], 1);
        }
        return false;
    }
}