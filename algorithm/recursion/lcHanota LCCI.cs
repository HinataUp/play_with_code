namespace code.algorithm.recursion;

public class lcHanota_LCCI {
    public void Hanota(IList<int> A, IList<int> B, IList<int> C) {
        int len = A.Count;
        Move(len, A, B, C);

        void Move(int len, IList<int> A, IList<int> B, IList<int> C) {
            if (len == 1) {
                C.Add(A[^1]); //  A[A.Count - 1] 等价
                A.RemoveAt(A.Count - 1);
                return;
            }

            Move(len - 1, A, C, B);
            Move(1, A, B, C);
            Move(len - 1, B, A, C);
        }
    }
}