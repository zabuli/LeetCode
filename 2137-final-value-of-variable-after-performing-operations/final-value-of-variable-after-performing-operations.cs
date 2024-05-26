public class Solution {
    public int FinalValueAfterOperations(string[] operations) {
        var sum = 0;

        foreach (var operation in operations)
        {
            switch (operation)
            {
                case "++X":
                case "X++":
                    sum++;
                    break;
                case "--X":
                case "X--":
                    sum--;
                    break;
                default:
                    break;
            }
        }

        return sum;
    }
}