public class Solution {
    public bool IsPerfectSquare(int num) {
        if (num < 2) return true;
        
        long min = 0;
        long max = num / 2;
        long mid = 0;
        long sqr = 0;

        while (min <= max)
        {
            mid = min + ((max - min) / 2);
            sqr = mid * mid;

            if (sqr == num)
            {
                return true;
            }
            if (sqr > num)
            {
                max = mid - 1;
            }
            else
            {
                min = mid + 1;
            }
        }

        return false;
    }
}