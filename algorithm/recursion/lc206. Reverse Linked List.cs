namespace code.algorithm.recursion;

// 1234 null  ->  4321null
// dummy head p --- dummy -p -head
public class lc206__Reverse_Linked_List {
    // 递归实现
    public ListNode ReverseList(ListNode head) {
        if (head == null || head.next == null) return head;
        ListNode dummy = new ListNode(-1, head);
        dummy = ReverseList(head.next); // 递归压栈，直到最后返回null 
        head.next.next = head; // 对局部 指针进行翻转
        head.next = null; // 将原来的头节点的next指针置空
        return dummy;
    }
    // 优化为迭代
    // public ListNode ReverseList(ListNode head) {
    //     ListNode dummy = new ListNode(-1, head);
    //     ListNode p = head;
    //     while (p != null && p.next != null) {
    //         ListNode next = p.next;
    //         p.next = next.next;
    //         next.next = dummy.next;
    //         dummy.next = next;
    //     }
    //     return dummy.next;
    // }
}