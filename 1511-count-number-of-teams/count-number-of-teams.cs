public class Solution {
    public int NumTeams(int[] rating) {
        var result = 0;

        for (var i = 0; i < rating.Length - 2; i++)
        {
            for (var j = i + 1; j < rating.Length - 1; j++)
            {
                for (var k = j + 1; k < rating.Length; k++)
                {
                    if (IsTeamValid(rating, i, j, k))
                    {
                        result++;
                    }
                }
            }
        }

        return result;
    }

    private static bool IsTeamValid(int[] rating, int i, int j, int k)
    {
        return ((rating[i] < rating[j]) && (rating[j] < rating[k]))
            || ((rating[i] > rating[j]) && (rating[j] > rating[k]));
    }
}