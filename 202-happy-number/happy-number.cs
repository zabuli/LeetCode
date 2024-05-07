public class Solution {
    public bool IsHappy(int n) {
        while (n > 9)
        {
            n = GetDigitsSum(n);
        }

        return n == 1 || n == 7;
    }

    private static int GetDigitsSum(int n)
    {
        if (n < 10)
        {
            return n;
        }

        var result = 0;

        while (n > 0)
        {
            var number = n % 10;
            result += number * number;
            n /= 10;
        }

        return result;
    }
}