public class Solution {
    public IList<IList<int>> MergeSimilarItems(int[][] items1, int[][] items2)
    {
        var unsortedSet = GetUnsortedSet(items1, items2);
        return GetResult(unsortedSet);
    }

    private static Dictionary<int, int> GetUnsortedSet(int[][] items1, int[][] items2)
    {
        var unsortedSet = new Dictionary<int, int>();
        for (var i = 0; i < items1.Length; i++)
        {
            if (!unsortedSet.ContainsKey(items1[i][0]))
            {
                unsortedSet.Add(items1[i][0], 0);
            }
            unsortedSet[items1[i][0]] += items1[i][1];
        }
        for (var i = 0; i < items2.Length; i++)
        {
            if (!unsortedSet.ContainsKey(items2[i][0]))
            {
                unsortedSet.Add(items2[i][0], 0);
            }
            unsortedSet[items2[i][0]] += items2[i][1];
        }
        return unsortedSet;
    }

    private static IList<IList<int>> GetResult(Dictionary<int, int> unsortedSet)
    {
        var result = new List<IList<int>>();
        foreach (var set in unsortedSet)
        {
            result.Add(new List<int> { set.Key, set.Value });
        }
        return result.OrderBy(x => x.First()).ToList();
    }
}