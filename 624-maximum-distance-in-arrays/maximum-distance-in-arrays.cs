public class Solution {
    public int MaxDistance(IList<IList<int>> arrays) {
        var maximums = FindMaximums(arrays);
        var minimums = FindMinimums(arrays);

        if (maximums[1] != minimums[1])
        {
            return Math.Abs(maximums[0] - minimums[0]);
        }

        return Math.Max(
            Math.Abs(maximums[0] - minimums[2]),
            Math.Abs(maximums[2] - minimums[0])
        );
    }

    private static int[] FindMaximums(IList<IList<int>> arrays)
    {
        var max1 = int.MinValue;
        var max1Index = 0;
        var max2 = int.MinValue;
        var max2Index = 0;

        for (var i = 0; i < arrays.Count; i++)
        {
            var max = arrays[i].Max(); 
            
            if (max1 <= max) 
            {
                max2 = max1; 
                max2Index = max1Index; 
                max1 = max; 
                max1Index = i; 
            }
            else if (max2 == int.MinValue || max2 <= max)
            {
                max2 = max; 
                max2Index = i; 
            }
        }

        return new int[4] { max1, max1Index, max2, max2Index };
    }

    private static int[] FindMinimums(IList<IList<int>> arrays)
    {
        var min1 = int.MaxValue;
        var min1Index = 0;
        var min2 = int.MaxValue;
        var min2Index = 0;

        for (var i = 0; i < arrays.Count; i++)
        {
            var min = arrays[i].Min(); 
            
            if (min1 >= min)
            {
                min2 = min1; 
                min2Index = min1Index; 
                min1 = min; 
                min1Index = i; 
            }
            else if (min2 == int.MaxValue || min2 >= min)
            {
                min2 = min; 
                min2Index = i; 
            }
        }

        return new int[4] { min1, min1Index, min2, min2Index };
    }
}