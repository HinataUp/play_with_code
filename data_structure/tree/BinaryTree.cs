namespace code.data_structure.tree;

// 此处为二叉树知识点
public class TreeNode {
    public int val;
    public TreeNode left;
    public TreeNode right;

    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null) {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

public class BinaryTree {
    // 遍历
    public IList<int> Traversal(TreeNode root) {
        IList<int> res = new List<int>();
        // 先序
        PreOrder(root, res);

        // 中序
        Inorder(root, res);

        // 后序
        PostOrder(root, res);

        return res;
    }


    // 先序遍历 根左右
    public void PreOrder(TreeNode root, IList<int> list) {
        if (root == null) return;
        // 根节点非空（root） **先** 添加进res ，随后分别递归左右子树，
        // 记住这里是左子树深入到底 直到空（root左子）才会 return，然后会立即看看当前root的右子，（右子非空，）加入res
        list.Add(root.val);
        PreOrder(root.left, list);
        PreOrder(root.right, list);
    }

    // 中序遍历 左根右
    public void Inorder(TreeNode root, IList<int> list) {
        if (root == null) return;
        // 先进左子树， 然后添加根节点， 最后进右子树
        Inorder(root.left, list);
        list.Add(root.val);
        Inorder(root.right, list);
    }

    // 后序遍历 左右根
    public void PostOrder(TreeNode root, IList<int> res) {
        if (root == null) return;
        // 先进左子树， 然后进右子树， 最后添加根节点
        PostOrder(root.left, res);
        PostOrder(root.right, res);
        res.Add(root.val);
    }


    // 优化为迭代后序遍历
    public IList<int> PostOrderIter(TreeNode root, IList<int> res) {
        if (root == null) return res;
        Stack<TreeNode> stack = new Stack<TreeNode>();
        TreeNode cur = root;
        TreeNode pre = null;
        while (cur != null || stack.Count != 0) {
            while (cur != null) {
                stack.Push(cur);
                cur = cur.left;
            }

            cur = stack.Peek();
            if (cur.right == null || cur.right == pre) {
                res.Add(cur.val);
                stack.Pop();
                pre = cur;
                cur = null;
            } else {
                cur = cur.right;
            }
        }

        return res;
    }
}