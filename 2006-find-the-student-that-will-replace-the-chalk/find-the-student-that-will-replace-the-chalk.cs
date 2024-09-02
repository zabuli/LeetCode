public class Solution {
    public int ChalkReplacer(int[] chalk, int k) {
        var i = 0;

        while (k > 0)
        {
            if (chalk[i] <= k)
            {
                k = k - chalk[i];
            }
            else
            {
                return i;
            }

            i++;

            if (i > chalk.Length - 1)
            {
                i = 0;
            }
        }

        return i;
    }
}