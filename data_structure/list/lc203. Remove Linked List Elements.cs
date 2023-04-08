namespace code.algorithm.recursion;

public class lc203__Remove_Linked_List_Elements {
    // 重复的自操作，递归只看最后一步，然后考虑好操作即可
    public ListNode RemoveElements(ListNode head, int val) {
        if (head == null) return null;
        head.next = RemoveElements(head.next, val);
        return head.val == val ? head.next : head; //当前值 == val， 则对当跳过当前节点，返回下一个节点
    }
    // 优化为迭代
    // 跳跃采用 next位置更新 的操作。否则就把当前节点指向下一个节点
    // public ListNode RemoveElements(ListNode head, int val) {
    //     ListNode dummy = new ListNode(-1, head);
    //     ListNode cur = dummy;
    //     while (cur.next != null) {
    //         if (cur.next.val == val) {
    //             cur.next = cur.next.next;
    //         } else {
    //             cur = cur.next;
    //         }
    //     }
    //     return dummy.next;
    // }
}