public class Solution {
    public bool IsPowerOfThree(int n) {
        if (n == 0)
        {
            return false;
        }
        if (n == 1 || n == 3)
        {
            return true;
        }
        if (n % 3 != 0)
        {
            return false;
        }

        return IsPowerOfThree(n / 3);
    }
}