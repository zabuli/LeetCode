public class Solution {
    public int MySqrt(int x) {
        var min = 0;
        var max = x;
        var mid = 0;
        var sqrt = 0;

        while(min <= max)
        {
            mid = (min + max) / 2;
            if (mid == 0)
            {
                return max;
            }
            
            sqrt = x / mid;
            if (sqrt == mid)
            {
                return mid;
            }
            else if (sqrt < mid)
            {
                max = mid - 1;
            }
            else 
            {
                min = mid + 1;
            }
        }

        return max;
    }
}