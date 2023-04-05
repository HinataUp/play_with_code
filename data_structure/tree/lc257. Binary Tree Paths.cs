namespace code.data_structure.tree;

public class lc257__Binary_Tree_Paths {
    public IList<string> BinaryTreePaths(TreeNode root) {
        IList<string> res = new List<string>();
        Paths(root, "", res);
        return res;
    }

    private void Paths(TreeNode root, string empty, IList<string> res) {
        if (root == null) return;
        empty += root.val;
        if (root.left == null && root.right == null) {
            res.Add(empty);
            return;
        }
        empty += "->";
        Paths(root.left, empty, res);
        Paths(root.right, empty, res);
    }
    // 优化为迭代
    public IList<string> BinaryTreePaths2(TreeNode root) {
        IList<string> res = new List<string>();
        if (root == null) return res;
        Stack<TreeNode> stack = new Stack<TreeNode>();
        Stack<string> path = new Stack<string>();
        stack.Push(root);
        path.Push(root.val.ToString());
        while (stack.Count != 0) {
            var node = stack.Pop();
            var pathStr = path.Pop();
            if (node.left == null && node.right == null) {
                res.Add(pathStr);
            }
            if (node.left != null) {
                stack.Push(node.left);
                path.Push(pathStr + "->" + node.left.val);
            }
            if (node.right != null) {
                stack.Push(node.right);
                path.Push(pathStr + "->" + node.right.val);
            }
        }
        return res;
    }
}