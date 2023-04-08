using System.Numerics;

namespace code.algorithm.recursion;

// 从尾部到头部打印链表
public class lcoffer06ReversePrint {
    public int[] ReversePrint(ListNode head) {
        if (head == null) return new int[0];
        List<int> res = new List<int>();

        ListNode Rev(ListNode node) {
            if (node == null) return null;
            res.Add(node.val);
            return Rev(node.next);
        }

        Rev(head);
        return res.ToArray();
    }
}