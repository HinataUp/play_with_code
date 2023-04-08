namespace code.algorithm.recursion;

public class lc92__Reverse_Linked_List_II {
    public ListNode ReverseBetween(ListNode head, int left, int right) {
        // 递归实现区间翻转链表  pre -next接 cur next 用于翻转
        ListNode dummy = new ListNode(-1, head);
        ListNode pre = dummy;
        for (int i = 0; i < left - 1; i++) {
            pre = pre.next;
        }

        ListNode cur = pre.next;
        ListNode next;
        // pre->cur->node    next 
        // 把cur.next 赋值给next ,此时 node节点值给了next （暂存cur 下个节点防止丢失）
        // 然后将 next.next 赋值给cur.next，相当于断开cur与node，让cur指向node的下一个节点 （更新cur指向的指针）
        // 最后将next赋值给pre.next，相当于将next节点插入到pre与cur之间 （更新指向cur的指针）
        // 这个过程结束后 cur pre本身一直持有不会丢失
        for (int i = 0; i < right - left; i++) {
            next = cur.next;
            cur.next = next.next;
            next.next = pre.next;
            pre.next = next;
        }

        return dummy.next;
    }

    // 递归
    // public ListNode ReverseBetween(ListNode head, int left, int right) {
    //     ListNode successor = null;
    //     if (left == 1) {
    //         return ReverseN(head, right);
    //     }
    //
    //     ListNode ReverseN(ListNode head, int n) {
    //         if (n == 1) {
    //             successor = head.next;
    //             return head;
    //         }
    //
    //         ListNode last = ReverseN(head.next, n - 1);
    //         head.next.next = head;
    //         head.next = successor;
    //         return last;
    //     }
    //
    //     head.next = ReverseBetween(head.next, left - 1, right - 1);
    //     return head;
    // }
}