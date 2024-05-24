public class Solution {
    public IList<string> TopKFrequent(string[] words, int k) {
        var frequencyMap = GetFrequencyMap(words);
        var priorityQueue = GetPriorityQueue(frequencyMap);

        return GetTopKFrequent(priorityQueue, k);
    }

    private static IList<string> GetTopKFrequent(PriorityQueue<string, KeyValuePair<string, int>> priorityQueue, int k)
    {
        IList<string> result = new List<string>();

        while (k > 0 && priorityQueue.Count > 0)
        {
            result.Add(priorityQueue.Dequeue());
            k--;
        }

        return result;
    }

    private static PriorityQueue<string, KeyValuePair<string, int>> GetPriorityQueue(Dictionary<string, int> frequencyMap)
    {
        var pq = new PriorityQueue<string, KeyValuePair<string, int>>(new TopKFrequentComparer());

        foreach (var fm in frequencyMap)
        {
            pq.Enqueue(fm.Key, fm);
        }

        return pq;
    }

    private static Dictionary<string, int> GetFrequencyMap(string[] words)
    {
        var frequencyMap = new Dictionary<string, int>();

        foreach (var word in words)
        {
            if (!frequencyMap.ContainsKey(word))
            {
                frequencyMap.Add(word, 0);
            }

            frequencyMap[word]++;
        }

        return frequencyMap;
    }

    public class TopKFrequentComparer : IComparer<KeyValuePair<string, int>>
    {
        public int Compare(KeyValuePair<string, int> x, KeyValuePair<string,int> y)
        {
            return (x.Value == y.Value) ? (x.Key.CompareTo(y.Key)) : (y.Value-x.Value);
        }
    }
}