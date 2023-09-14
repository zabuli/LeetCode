public class Solution {
    public int MinimumSum(int num) {
        var number = num.ToString().ToCharArray();
        var numbers = Array.ConvertAll(number, c => (int)Char.GetNumericValue(c));
        Array.Sort(numbers);
        var first = int.Parse(numbers[0].ToString() + numbers[2].ToString());
        var second = int.Parse(numbers[1].ToString() + numbers[3].ToString());

        return first + second;
    }
}