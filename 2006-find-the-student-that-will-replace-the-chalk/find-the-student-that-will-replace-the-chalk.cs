public class Solution {
    public int ChalkReplacer(int[] chalk, int k) {
        var prefixSum = GetPrefixSum(chalk);

        k = (int)(k % prefixSum[^1]);

        var min = 0;
        var max = chalk.Length - 1;

        while (min <= max)
        {
            var mid = min + ((max - min) / 2);
            if (prefixSum[mid] > k)
            {
                max = mid - 1;
            }
            else
            {
                min = mid + 1;
            }
        }

        return min;
    }

    private static long[] GetPrefixSum(int[] chalk)
    {
        var prefixSum = new long[chalk.Length];
        prefixSum[0] = chalk[0];

        for (var i = 1; i < chalk.Length; i++)
        {
            prefixSum[i] = chalk[i] + prefixSum[i - 1];
        }

        return prefixSum;
    }
}