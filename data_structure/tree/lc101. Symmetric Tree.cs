namespace code.data_structure.tree;

public class lc101__Symmetric_Tree {
    public bool IsSymmetric(TreeNode root) {
        if (root == null) return true;
        return Symmetric(root.left, root.right);
    }

    private bool Symmetric(TreeNode rootLeft, TreeNode rootRight) {
        if (rootLeft == null && rootRight == null) return true;
        if (rootLeft == null || rootRight == null) return false;
        if (rootLeft.val != rootRight.val) return false;
        return Symmetric(rootLeft.left, rootRight.right) &&
               Symmetric(rootLeft.right, rootRight.left);
    }
}