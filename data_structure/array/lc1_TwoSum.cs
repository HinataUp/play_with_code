namespace code.data_structure.array; 

public class lc1_TwoSum {
    public int[] TwoSum(int[] nums, int target) {
        int [] res = new int[2];
        for( int i = 0; i < nums.Length - 1; i++){
            for (int j = i +1 ;j < nums.Length; j++){
                if(nums[i] + nums[j] == target){
                    res[0] = i;
                    res[1] = j;
                }
            }
        }
        return res;
    }
}