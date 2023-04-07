namespace code.data_structure.tree; 

public class lc112__Path_Sum {
    public bool HasPathSum(TreeNode root, int targetSum) {
        if (root == null) return false;
        if (root.left == null && root.right == null) return targetSum == root.val;
        return HasPathSum(root.left, targetSum - root.val) ||
               HasPathSum(root.right, targetSum - root.val);
    }
}