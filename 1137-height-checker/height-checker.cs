public class Solution {
    public int HeightChecker(int[] heights) {
        var sortedArray = heights.ToArray();
        var count = 0;

        Array.Sort(sortedArray);

        for (var i = 0; i < heights.Length; i++)
        {
            if (heights[i] != sortedArray[i])
            {
                count++;
            }
        }

        return count;
    }
}