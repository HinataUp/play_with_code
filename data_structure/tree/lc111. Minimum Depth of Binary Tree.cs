namespace code.data_structure.tree;

public class lc111__Minimum_Depth_of_Binary_Tree {
    public int MinDepth(TreeNode root) { 
        if (root == null) return 0;
        int depth = 0;
        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        while (queue.Count != 0) {
            int size = queue.Count;
            while (size > 0) {
                var node = queue.Dequeue();
                // 只要某个节点的 双子同时不存在就直接返回
                if (node.left == null && node.right == null) return depth + 1;
                if (node.left != null) queue.Enqueue(node.left);
                if (node.right != null) queue.Enqueue(node.right);
                size--;
            }

            depth++;
        }

        return depth;
    }
}
