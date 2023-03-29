namespace easy;

// 依据位置， 已知两颗二叉树，将它们合并成一颗二叉树。合并规则是：都存在的结点，就将结点值加起来，否则空的位置就由另一个树的结点来代替
// 知识点， 二叉树的遍历， 节点判断空 ， 非空节点合并
public class nc117 {
    // 先序遍历
    public TreeNode mergeTrees(TreeNode t1, TreeNode t2) {
        // 谁空就pass 返回另外一个
        if(t1 == null) return t2;
        if(t2 == null) return t1;
        // 都不空，合并, new 一个新的节点 并设置值 为两个节点的值相加
        TreeNode root = new TreeNode(t1.val + t2.val);
        root.left = mergeTrees(t1.left, t2.left);
        root.right = mergeTrees(t1.right, t2.right);
        return root;
    }
}

public class TreeNode {
    public int val;
    public TreeNode left;
    public TreeNode right;

    public TreeNode(int x) {
        val = x;
    }
}
// 举一反三