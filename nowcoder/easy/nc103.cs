namespace easy;

using System;
using System.Collections.Generic;

// 写出一个程序，接受一个字符串，然后输出该字符串反转后的字符串。（字符串长度不超过1000）
class nc103 {
   
    public string solve(string str) {
        string res = "";
        if (str.Length == 0) {
            return "";
        }

        for (int i = str.Length - 1; i >= 0; i--) {
            res += str[i];
        }

        return res;
        // write code here
    }
}