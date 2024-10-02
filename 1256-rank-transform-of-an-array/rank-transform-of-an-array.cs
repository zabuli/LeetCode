public class Solution {
    public int[] ArrayRankTransform(int[] arr) {
        var hashMap = new Dictionary<int, int>();
        var hashMap2 = new Dictionary<int, int>();

        for (var i = 0; i < arr.Length; i++)
        {
            if (!hashMap.ContainsKey(i))
            {
                hashMap.Add(i, arr[i]);
            }
            if (!hashMap2.ContainsKey(arr[i]))
            {
                hashMap2.Add(arr[i], 0);
            }
        }

        Array.Sort(arr);

        var rank = 1;

        for (var i = 0; i < arr.Length; i++)
        {
            if (hashMap2[arr[i]] == 0)
            {
                hashMap2[arr[i]] = rank;
                rank++;
            }
        }

        var result = new int[arr.Length];

        for (var i = 0; i < arr.Length; i++)
        {
            result[i] = hashMap2[hashMap[i]];
        }

        return result;
    }
}