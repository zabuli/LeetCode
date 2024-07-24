public class Solution {
    public bool IsUgly(int n) {
        if (n == 0)
        {
            return false;
        }

        var primeNumbers = new List<int> { 2, 3, 5 };

        foreach (var primeNumber in primeNumbers)
        {
            while (n % primeNumber == 0)
            {
                n /= primeNumber;
            }
        }

        return n == 1;
    }
}