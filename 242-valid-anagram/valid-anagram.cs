public class Solution {
    public bool IsAnagram(string s, string t) {
        var hashMap = FillHashMap(s);
        hashMap = RemoveCharacters(t, hashMap);

        return !hashMap.Any(x => x.Value != 0);
    }

    private static Dictionary<char, int> FillHashMap(string s)
    {
        var hashMap = new Dictionary<char, int>();

        foreach (var c in s)
        {
            if (!hashMap.ContainsKey(c))
            {
                hashMap.Add(c, 0);
            }

            hashMap[c]++;
        }

        return hashMap;
    }

    private Dictionary<char, int> RemoveCharacters(string t, Dictionary<char, int> hashMap)
    {
        foreach (var c in t)
        {
            if (!hashMap.ContainsKey(c))
            {
                hashMap.Add(c, 1);
            }
            else
            {
                hashMap[c]--;
            }
        }

        return hashMap;
    }
}