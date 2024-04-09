public class Solution {
    public int TimeRequiredToBuy(int[] tickets, int k) {
        var seconds = 0;
        var i = 0;

        while (tickets[k] > 0)
        {
            seconds += tickets[i] <= 0 ? 0 : 1;
            tickets[i]--;
            i++;

            if (i == tickets.Length)
            {
                i = 0;
            }
        }

        return seconds;
    }
}