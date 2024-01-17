public class Solution {
    public bool UniqueOccurrences(int[] arr) {
        var map = new Dictionary<int, int>();
        var unique = new HashSet<int>();

        foreach(var number in arr)
        {
            if (!map.ContainsKey(number))
            {
                map.Add(number, 1);
            }
            else
            {
                map[number]++;
            }
        }
        
        foreach (var value in map.Values)
        {
            if (!unique.Contains(value))
            {
                unique.Add(value);
            }
            else
            {
                return false;
            }
        }

        return true;
    }
}