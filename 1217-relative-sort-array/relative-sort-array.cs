public class Solution {
    public int[] RelativeSortArray(int[] arr1, int[] arr2) {
        Array.Sort(arr1);

        var map = FillMap(arr1, arr2);
        var arr1Index = 0;

        for (var i = 0; i < arr2.Length; i++)
        {
            for (var j = 0; j < map[arr2[i]].Item2; j++)
            {
                arr1[arr1Index] = arr2[i];
                arr1Index++;
            }
        }

        for (var i = arr1Index; i < arr1.Length; i++)
        {
            foreach(var element in map.Where(x => x.Value.Item1 == false))
            {
                for (var j = 0; j < element.Value.Item2; j++)
                {
                    arr1[i] = element.Key;
                    i++;
                }
            }
        }

        return arr1;
    }

    private static Dictionary<int, (bool, int)> FillMap(int[] arr1, int[] arr2)
    {
        var map = new Dictionary<int, (bool, int)>();

        foreach (var num in arr1)
        {
            if (!map.ContainsKey(num))
            {
                map.Add(num, (false, 0));
            }

            map[num] = (false, map[num].Item2 + 1);
        }

        foreach (var num in arr2)
        {
            if (map.ContainsKey(num))
            {
                map[num] = (true, map[num].Item2);
            }
        }

        return map;
    }
}