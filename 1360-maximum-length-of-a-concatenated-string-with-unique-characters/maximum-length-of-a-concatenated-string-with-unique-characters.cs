public class Solution {
    public int MaxLength(IList<string> arr) {
        return GetMaxLength(arr, 0, 0, new HashSet<char>());
    }

    private int GetMaxLength(IList<string> arr, int start, int max, HashSet<char> set)
    {
        if (start == arr.Count)
        {
            return Math.Max(max, set.Count);
        }

        for (var i = start; i < arr.Count; i++)
        {
            if (IsPossibleToStore(arr[i], set))
            {
                set = StoreToSet(arr[i], set);
                max = GetMaxLength(arr, i + 1, max, set);
                set = RemoveFromSet(arr[i], set);
            }
        }

        return Math.Max(max, set.Count);
    }

    private static HashSet<char> StoreToSet(string s, HashSet<char> set)
    {
        foreach (var c in s)
        {
            set.Add(c);
        }

        return set;
    }

    private static HashSet<char> RemoveFromSet(string s, HashSet<char> set)
    {
        foreach (var c in s)
        {
            set.Remove(c);
        }

        return set;
    }

    private static bool IsPossibleToStore(string s, HashSet<char> set)
    {
        var tmpSet = new HashSet<char>();

        foreach (var c in s)
        {
            if (tmpSet.Contains(c) || set.Contains(c))
            {
                return false;
            }

            tmpSet.Add(c);
        }

        return true;
    }
}