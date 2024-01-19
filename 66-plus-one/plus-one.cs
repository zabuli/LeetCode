public class Solution {
    public int[] PlusOne(int[] digits) {
        var result = new List<int>();
        var k = 1; 
        var sum = 0;
        var j = 0;

        for (var i = digits.Length - 1; i >= 0; i--)
        {
            sum = digits[i] + k;
            result.Add(sum);

            if (result[j] >= 10)
            {
                result[j] = result[j] % 10;
                k = sum / 10; 
            }
            else
            {
                k = 0;
            }

            j++;
        }

        if (result[result.Count - 1] == 0)
        {
            result.Add(k);
        }

        result.Reverse();
        return result.ToArray();
    }
}