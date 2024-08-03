public class Solution {
    public bool CanBeEqual(int[] target, int[] arr) {
        var hashMap = GetElements(target);

        foreach (var num in arr)
        {
            if (!hashMap.ContainsKey(num) || hashMap[num] == 0)
            {
                return false;
            }

            hashMap[num]--;
        }

        return !hashMap.Any(x => x.Value != 0);
    }

    private static Dictionary<int, int> GetElements(int[] target)
    {
        var hashMap = new Dictionary<int, int>();

        foreach (var num in target)
        {
            if (!hashMap.ContainsKey(num))
            {
                hashMap.Add(num, 0);
            }

            hashMap[num]++;
        }

        return hashMap;
    }
}