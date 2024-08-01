public class Solution {
    public int CountSeniors(string[] details) {
        var count = 0;

        foreach (var detail in details)
        {
            if (detail[11] > '6' || (detail[11] == '6' && detail[12] > '0'))
            {
                count++;
            }
        }

        return count;
    }
}