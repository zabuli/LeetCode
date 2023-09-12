public class Solution {
    public int NumJewelsInStones(string jewels, string stones) {
        var jewelsInStones = new Dictionary<char, int>();
        var result = 0;
        foreach(var character in jewels)
        {
            jewelsInStones.Add(character, 0);
        }
        foreach(var stone in stones)
        {
            if (jewelsInStones.ContainsKey(stone))
            {
                result++;
            }
        }

        return result;
    }
}