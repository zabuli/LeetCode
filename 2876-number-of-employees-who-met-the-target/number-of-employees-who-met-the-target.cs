public class Solution {
    public int NumberOfEmployeesWhoMetTarget(int[] hours, int target) {
        return hours.Count(x => x >= target);
    }
}