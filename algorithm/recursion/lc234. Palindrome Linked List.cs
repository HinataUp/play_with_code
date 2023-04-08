namespace code.algorithm.recursion;

// 不破坏递归法 递归的思想是，先递归到最后，然后再回溯
// 1. 递归到最后一个节点，然后返回
// 2. 从最后一个节点开始，向前比较，如果不相等，返回false
// 3. 如果相等，返回true
// 创建内部方法 便于递归使用
public class lc234__Palindrome_Linked_List {
    public bool IsPalindrome(ListNode head) {
        // 递归

        ListNode p = head;

        bool check(ListNode node) {
            if (node == null) return true;
            if (!check(node.next)) return false;
            if (p.val != node.val) return false;
            p = p.next;
            return true;
        }

        return check(head);
    }
}