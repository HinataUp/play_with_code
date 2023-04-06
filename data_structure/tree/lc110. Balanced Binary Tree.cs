namespace code.data_structure.tree;

public class lc110__Balanced_Binary_Tree {
    public bool IsBalanced(TreeNode root) {
        if (root == null) return true;
        return Depth(root) != -1;
    }

    private int Depth(TreeNode root) {
        if (root == null) return 0;
        int left = Depth(root.left);
        if (left == -1) return -1;
        int right = Depth(root.right);
        if (right == -1) return -1;
        return Math.Abs(left - right) < 2 ? Math.Max(left, right) + 1 : -1;
    }
}