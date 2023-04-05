namespace code.data_structure.tree;

public class lc104__Maximum_Depth_of_Binary_Tree {
    public int MaxDepth(TreeNode root) {
        int height = 0;
        if (root == null) return height;
        // 用栈实现深度优先遍历，然后通过深度优先遍历每层的深入计数 得到高度
        Stack<(TreeNode, int)> stack = new Stack<(TreeNode, int)>();
        stack.Push((root, 1));
        while (stack.Count != 0) {
            var (node, depth) = stack.Pop();
            height = Math.Max(height, depth);
            if (node.left != null) stack.Push((node.left, depth + 1));
            if (node.right != null) stack.Push((node.right, depth + 1));
        }

        return height;
    }

    // 队列操作方式 层序遍历
    public int MaxDepth2(TreeNode root) {
        int height = 0;
        if (root == null) return height;
        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        while (queue.Count != 0) {
            int size = queue.Count;
            while (size > 0) {
                var node = queue.Dequeue();
                if (node.left != null) queue.Enqueue(node.left);
                if (node.right != null) queue.Enqueue(node.right);
                size--;
            }

            height++;
        }

        return height;
    }
}