namespace code.data_structure.array;

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

// 将有序（升序）数组转换为二叉搜索树
// 什么是BST ，左子树的值都小于根节点，右子树的值都大于根节点， 依次类推 代代相传
// 这里要求高度平衡，即左右子树的高度差不超过1
// 树根选在中点 至于中偏左/右，都可以，只要平衡即可

// 建树的逻辑本质和 深度优先遍历一样 或者 层序遍历一样， 都是依据遍历的方式来建树
public class lc108__Convert_Sorted_Array_to_Binary_Search_Tree {
    public TreeNode SortedArrayToBST(int[] nums) {
        if (nums.Length == 0) return null;
        return BuildTree(nums, 0, nums.Length - 1);
    }

    // 建立辅助遍历函数 ，善用递归
    // 中序遍历思想 ，左中右（本次例子符合这个特征）
    private TreeNode BuildTree(int[] nums, int left, int right) {
        // 递归终止条件
        if (left > right) return null!;
        // 取中点，递归深入左右字数（此时中点已经用作根了，记得排除）
        int mid = (left + right) / 2;
        return new TreeNode(nums[mid], BuildTree(nums, left, mid - 1),
            BuildTree(nums, mid + 1, right));
    }

    // 用队列优化为迭代版本
    // 取出队头元素，记为root 根， 然后根据当前子树范围判断 中点mid  值如果小于根，那么mid就是左子树的根，否则是右子树的根（BST性质）
    // 然后将左右子树的范围入队，继续迭代
    // 栈方法类似： 把队头删除 改为 栈顶pop（弹栈） 即可
    public TreeNode SortedArrayToBST2(int[] nums) {
        if (nums.Length == 0) return null!;
        Queue<(TreeNode, int, int)> queue = new Queue<(TreeNode, int, int)>();
        int mid = (nums.Length - 1) / 2;
        TreeNode node = new TreeNode(nums[mid]);
        queue.Enqueue((node, 0, mid - 1));
        queue.Enqueue((node, mid + 1, nums.Length - 1));
        while (queue.Count != 0) {
            var (root, left, right) = queue.Dequeue(); // 删除返回队头元素
            if (left > right) continue;
            mid = (left + right + 1) / 2;
            if (nums[mid] < root.val) {
                root.left = new TreeNode(nums[mid]);
                queue.Enqueue((root.left, left, mid - 1));
                queue.Enqueue((root.left, mid + 1, right));
            } else {
                root.right = new TreeNode(nums[mid]);
                queue.Enqueue((root.right, left, mid - 1));
                queue.Enqueue((root.right, mid + 1, right));
            }
        }
        return node;
    }
}