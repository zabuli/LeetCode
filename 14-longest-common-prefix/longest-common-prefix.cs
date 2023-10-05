public class Solution {
    public class TrieNode
    {
        public char Character {get; set;}
        public TrieNode Child { get; set; }
    }

    public string LongestCommonPrefix(string[] strs) {
        if (strs == null || strs.Length == 0 || strs.Any(x => string.IsNullOrEmpty(x)))
        {
            return "";
        }
        if (strs.Length == 1)
        {
            return strs[0];
        }

        var tries = new TrieNode[strs.Length];
        for(var i = 0; i < strs.Length; i++)
        {
            tries[i] = CreateTrieNode(strs[i], 0);
        }
        return GetPrefix(tries);
    }

    private static TrieNode CreateTrieNode(string str, int i)
    {
        return new TrieNode
        {
            Character = str[i],
            Child = i < str.Length - 1 ? CreateTrieNode(str, i + 1) : null
        };
    }

    private static string GetPrefix(TrieNode[] tries)
    {
        var prefix = "";
        if (tries[0] == null)
        {
            return prefix;
        }

        var character = tries[0].Character;
        for(var i = 0; i < tries.Length; i++)
        {
            if (tries[i] == null || character != tries[i].Character)
            {
                return prefix;
            }
            
            tries[i] = tries[i].Child;
        }

        prefix += character + GetPrefix(tries);
        return prefix;
    }
}