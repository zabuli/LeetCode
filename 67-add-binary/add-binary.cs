public class Solution {
    public string AddBinary(string a, string b) {
        var i = a.Length - 1; 
        var j = b.Length - 1;
        var carry = 0;
        var result = new List<int>();

        while (i >= 0 || j >= 0)
        {
            var first = i >= 0 ? (a[i] - '0') : 0;
            var second = j >= 0 ? (b[j] - '0') : 0;
            var sum = first + second + carry;

            switch (sum)
            {
                case 3:
                    result.Add(1);
                    carry = 1;
                    break;
                case 2:
                    result.Add(0);
                    carry = 1;
                    break;
                default:
                    result.Add(sum);
                    carry = 0;
                    break;
            }

            i--;
            j--;
        }

        if (carry > 0)
        {
            result.Add(1);
        }

        result.Reverse();
        return string.Concat(result);
    }
}