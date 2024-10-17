public class Solution {
    public int MaximumSwap(int num) {
        var arr = num.ToString().ToCharArray();
        var max = GetMax(arr);

        for (var i = 0; i < arr.Length; i++)
        {
            if (i < max.Item1 && arr[i] < max.Item2)
            {
                var pom = arr[i];
                arr[i] = arr[max.Item1];
                arr[max.Item1] = pom;
                break;
            }
        }

        return int.Parse(new string(arr));
    }

    private static Tuple<int, char> GetMax(char[] arr)
    {
        var max = '0';
        var index = -1;
        var i = 0;

        while (i + 1 < arr.Length && arr[i] >= arr[i + 1])
        {
            i++;
        }

        for (var j = arr.Length - 1; j >= i; j--)
        {
            if (arr[j] > max)
            {
                max = arr[j];
                index = j;
            }
        }

        return new Tuple<int, char>(index, max);
    }
}