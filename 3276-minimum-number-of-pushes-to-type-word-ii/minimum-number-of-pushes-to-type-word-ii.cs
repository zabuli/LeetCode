public class Solution {
    public int MinimumPushes(string word) {
        var hashMap = GetHashMap(word);
        hashMap = hashMap.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
        var count = 0;
        var i = 0;

        foreach (var element in hashMap)
        {
            count += element.Value * ((i / 8) + 1);
            i++;
        }

        return count;
    }

    private static Dictionary<char, int> GetHashMap(string word)
    {
        var hashMap = new Dictionary<char, int>();

        foreach (var c in word)
        {
            if (!hashMap.ContainsKey(c))
            {
                hashMap.Add(c,0);
            }

            hashMap[c]++;
        }

        return hashMap;
    }
}