public class Solution {
    public double AverageWaitingTime(int[][] customers) {
        double time = -1;
        double waitingTime = 0.0d; 

        for (var i = 0; i < customers.Length; i++)
        {
            time = time > customers[i][0]
                ? time + customers[i][1]
                : customers[i][0] + customers[i][1];
            waitingTime += time - customers[i][0];
        }

        return waitingTime / customers.Length;
    }
}