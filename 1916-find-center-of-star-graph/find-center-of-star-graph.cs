public class Solution {
    public int FindCenter(int[][] edges) {
        var firstNodeCount = 0;
        var secondNodeCount = 0;
        for(var i = 1; i < 2; i++)
        {
            if(edges[i][0] == edges[0][0] || edges[i][1] == edges[0][0])
            {
                firstNodeCount++;
            }
            if(edges[i][0] == edges[0][1] || edges[i][1] == edges[0][1])
            {
                secondNodeCount++;
            }
        }

        return firstNodeCount > secondNodeCount 
            ? edges[0][0] 
            : edges[0][1];
    }
}