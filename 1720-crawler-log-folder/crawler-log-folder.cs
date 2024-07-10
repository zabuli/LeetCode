public class Solution {
    public int MinOperations(string[] logs) {
        var currentLayer = 0;

        foreach (var log in logs)
        {
            currentLayer += GetOperation(log, currentLayer);
        }

        return currentLayer;
    }

    private static int GetOperation(string log, int currentLayer)
    {
        switch (log)
        {
            case "../":
                return currentLayer == 0 ? 0 : -1;
            case "./":
                return 0;
            default:
                return 1;
        }
    }
}