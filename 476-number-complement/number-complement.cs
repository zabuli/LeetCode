public class Solution {
    public int FindComplement(int num) {
        var binary = GetFlippedBinary(num);
        return GetFlippedNum(binary);
    }

    private static int GetFlippedNum(string s)
    {
        var result = 0;

        for (var i = 0; i < s.Length; i++)
        {
            if (s[i] == '0')
            {
                continue;
            }

            result += (int)Math.Pow(2, i);
        }

        return result;
    }

    private static string GetFlippedBinary(int num)
    {
        var sb = new StringBuilder();

        while (num > 0)
        {
            if (num % 2 == 0)
            {
                sb.Append("1");
            }
            else
            {
                sb.Append("0");
            }
            
            num /= 2;
        }

        return sb.ToString();
    }
}