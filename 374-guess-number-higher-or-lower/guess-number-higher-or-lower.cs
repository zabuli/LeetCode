/** 
 * Forward declaration of guess API.
 * @param  num   your guess
 * @return 	     -1 if num is higher than the picked number
 *			      1 if num is lower than the picked number
 *               otherwise return 0
 * int guess(int num);
 */

public class Solution : GuessGame {
    public int GuessNumber(int n) {
        var min = 0;
        var max = n;
        var mid = 0;
        var result = 0;

        while (min <= max)
        {
            mid = min + ((max - min) / 2);
            result = guess(mid);

            if (result == 0)
            {
                return mid;
            }
            if (result == 1)
            {
                min = mid + 1;
            }
            else
            {
                max = mid - 1;
            }
        }

        return n;
    }
}