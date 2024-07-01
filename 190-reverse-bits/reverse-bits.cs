public class Solution {
    public uint reverseBits(uint n) {
        uint result = 0;

        for (var i = 0; i < 32; i++)
        {
            uint pom = n & 1;
            uint pomReverse = pom << (31 - i);
            result = result | pomReverse;
            n = n >> 1;
        }

        return result;
    }
}