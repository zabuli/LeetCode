public class Solution {
    public int ArraySign(int[] nums) {
        if (nums.Contains(0))
        {
            return SignFunc(0);
        }

        var minusCount = nums.Count(x => x < 0);
        
        return minusCount % 2 == 0
            ? SignFunc(1)
            : SignFunc(-1);
    }

    private static int SignFunc(int x)
    {
        if (x == 0)
        {
            return 0;
        }

        return x > 0 ? 1 : -1;
    }
}