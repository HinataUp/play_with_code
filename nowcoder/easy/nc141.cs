namespace easy;

// 给定一个长度为 n 的字符串，请编写一个函数判断该字符串是否回文。如果是回文请返回true，否则返回false。
// 字符串回文指该字符串正序与其逆序逐字符一致
// 例如：字符串"level"是回文，"algorithm"不是回文
public class nc141 {
    public bool judge(string str) {
        bool res = true;
        for (int i = 0, j = str.Length - 1; i < j; i++, j--) {
            if (str[i] != str[j]) {
                res = false;
                return res;
            }
        }

        return res;
    }
}