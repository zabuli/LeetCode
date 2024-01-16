public class Solution {
    private static Dictionary<char, int> _symbols = new Dictionary<char, int>
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };
    private static new Dictionary<string, int> _combinations = new Dictionary<string, int>
    {
        {"IV", 4},
        {"IX", 9},
        {"XL", 40},
        {"XC", 90},
        {"CD", 400},
        {"CM", 900}
    };

    public int RomanToInt(string s) {
        var result = 0;
        string combination;
        for (var i = 0; i < s.Length; i++)
        {
            if (i < s.Length - 1)
            {
                combination = "" + s[i] + s[i + 1];
                if (_combinations.ContainsKey(combination))
                {
                    result += _combinations[combination];
                    i++;
                    continue;
                }
            }

            result += _symbols[s[i]];
        }

        return result;
    }
}