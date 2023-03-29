namespace easy; 


// 给定一个字符串，请你判断其中每个字符是否全都不同, 字符串长度 1-100
// 1. 字典 查询查重
// 2. 排序后查重
// 3. 遍历查重，存数组
public class nc229 {
    public bool isUnique (string str) { 
        // 1. 字典 查询查重
        Dictionary<char,int> dic = new Dictionary<char, int>();
        for (int i = 0; i < str.Length; i++) {
            if(dic.ContainsKey(str[i])) return false;
            dic.Add(str[i], 1);
        }
        return true;
        
        // 2. 排序后查重
        // char[] arr = str.ToCharArray();
        // Array.Sort(arr);
        // for (int i = 0; i < arr.Length - 1; i++) {
        //     if (arr[i] == arr[i + 1]) return false;
        // }
        // return true;
        
        // 3. 遍历查重，存数组
        bool[] arr = new bool[256];
        for (int i = 0; i < str.Length; i++) {
            if (arr[str[i]]) return false;
            arr[str[i]] = true;
        }
        return true;
    }
}