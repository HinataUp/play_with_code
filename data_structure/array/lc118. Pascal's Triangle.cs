namespace code.data_structure.array;

// 输出杨辉三角
public class lc118__Pascal_s_Triangle {
    public IList<IList<int>> Generate(int numRows) {
        IList<IList<int>> res = new List<IList<int>>();
        for (int i = 0; i < numRows; i++) {
            IList<int> cur = new List<int>();
            for (int j = 0; j <= i; j++) {
                if (j == 0 || j == i) {
                    cur.Add(1);
                } else {
                    cur.Add(res[i - 1][j - 1] + res[i - 1][j]);
                }
            }

            res.Add(cur);
        }

        return res;
    }
}