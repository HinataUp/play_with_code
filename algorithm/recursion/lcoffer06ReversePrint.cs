using System.Numerics;

namespace code.algorithm.recursion;

// 从尾部到头部打印链表
public class lcoffer06ReversePrint {
    public int[] ReversePrint(ListNode head) {
        if (head == null) return new int[0];
        var count = 0;
        var node = head;
        while (node != null) {
            count++;
            node = node.next;
        }

        var result = new int[count];
        int i = count - 1;
        while (0 <= i) {
            result[i--] = head.val;
            head = head.next;
        }

        return result;
    }

    // 改为递归
    public int[] ReversePrint2(ListNode head) {
        List<int> res = new List<int>();
        ListNode dummy = new ListNode(-1, head);
        reversprint(dummy.next, res);

        void reversprint(ListNode node, List<int> res) {
            if (node == null) return;
            reversprint(node.next, res);
            res.Add(node.val);
        }
        return res.ToArray();
    }

}