public class Solution {
    public string[] SortPeople(string[] names, int[] heights) {
        Array.Sort(heights, names);
        Array.Reverse(names);
        return names;
    }
}