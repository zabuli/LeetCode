public class Solution {
    public class TrieNode
    {
        public char NodeValue { get; set; }
        public Dictionary<char, TrieNode> Children { get; set; } = new Dictionary<char, TrieNode>();

        public TrieNode(char nodeValue)
        {
            NodeValue = nodeValue;
        }

        public TrieNode(int[] arri)
        {
            var arrs = arri.Select(x => x.ToString());
            var children = Children;
            
            foreach (var arr in arrs)
            {
                for (var i = 0; i < arr.Length; i++)
                {
                    if (!children.ContainsKey(arr[i]))
                    {
                        children.Add(arr[i], new TrieNode(arr[i]));
                    }

                    children = children[arr[i]].Children;
                }

                children = Children;
            }
        }

        public int FindLongestPrefix(int[] arri)
        {
            var arrs = arri.Select(x => x.ToString());
            var max = 0;

            foreach (var arr in arrs)
            {
                max = Math.Max(max, GetPrefixLength(arr));
            }

            return max;
        }

        private int GetPrefixLength(string arr)
        {
            var children = Children;
            var max = 0;

            while (max < arr.Length && children.ContainsKey(arr[max]))
            {
                children = children[arr[max]].Children;
                max++;
            }

            return max;
        }
    }

    public int LongestCommonPrefix(int[] arr1, int[] arr2) {
        var max = 0;
        var trie1 = new TrieNode(arr1);
        var trie2 = new TrieNode(arr2);

        max = trie1.FindLongestPrefix(arr2);
        max = Math.Max(max, trie2.FindLongestPrefix(arr1));

        return max;
    }
}