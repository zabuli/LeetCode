public class Solution {
    public string KthDistinct(string[] arr, int k) {
        var distinctStrings = GetDistinctStrings(arr);

        if (distinctStrings.Length < k)
        {
            return string.Empty;
        }

        return distinctStrings[k - 1];
    }

    private static string[] GetDistinctStrings(string[] arr)
    {
        var hashTable = new Dictionary<string, int>();

        foreach (var element in arr)
        {
            if (!hashTable.ContainsKey(element))
            {
                hashTable.Add(element, 0);
            }

            hashTable[element]++;
        }

        return hashTable.Where(x => x.Value == 1).Select(x => x.Key).ToArray();
    }
}