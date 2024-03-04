public class Solution {
    public int BagOfTokensScore(int[] tokens, int power) {
        Array.Sort(tokens);

        var score = 0;
        var maxScore = 0;
        var left = 0; 
        var right = tokens.Length - 1;

        while (left <= right) 
        {
            if (power >= tokens[left])
            {
                power -= tokens[left];
                score++;
                left++;
                maxScore = Math.Max(score, maxScore);
            }
            else if (score >= 1)
            {
                power += tokens[right];
                score--;
                right--; 
            }
            else
            {
                break;
            }
        }

        return maxScore;
    }
}