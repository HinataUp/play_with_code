namespace easy; 


// 二叉树镜像
// 操作给定的二叉树，将其变换为源二叉树的镜像
// root 不变， 左右子交换， 每个子树也是同理，子树内部先交换 然后父节点作为爷爷节点的左右子交换 ，以此类推
public class nc72 {
    public TreeNode Mirror (TreeNode pRoot) {
        if (pRoot == null) return null;
        // 暂存最终递归节点,然后赋值
        // TreeNode left = Mirror(pRoot.left); //此处递归最后得到最左子，然后（再往下是null了，所以最左子是递归最深得到的值）
        // TreeNode right = Mirror(pRoot.right); // 然后这里接着上面，得到最左子的右兄弟，暂存给right
        // // 交换， 此时获得的pRoot 是两者的父节点， 交换孩子即可
        // pRoot.left = right;
        // pRoot.right = left;
        
        // 传引用，以次才可以完成值的改变，否则swap无效
        // Swap(ref pRoot.left,ref  pRoot.right);
        // 这段代码在本地和leetcode 可以通过，但是牛客不行，不知道为什么（bug已经反馈）
        (pRoot.left, pRoot.right) = (pRoot.right, pRoot.left);
        
        // 但是常规的交换却不受影响
        // TreeNode temp = pRoot.left;
        // pRoot.left = pRoot.right;
        // pRoot.right = temp;
        
        Mirror(pRoot.left);
        Mirror(pRoot.right);
        return pRoot;
    }

    public void Swap(ref TreeNode left, ref TreeNode right) {
        (left, right) = (right, left);
    }
}