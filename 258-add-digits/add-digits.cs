public class Solution {
    public int AddDigits(int num) {
        if (num == 0)
        {
            return num;
        }

        num %= 9;
        
        return num == 0 ? 9 : num;
    }
}