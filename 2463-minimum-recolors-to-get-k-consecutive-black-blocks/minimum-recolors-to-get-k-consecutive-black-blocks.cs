public class Solution {
    public int MinimumRecolors(string blocks, int k) {
        string block; int kk;
        var result = 101;

        for(var i = 0; i < blocks.Length - k + 1; i++)
        {
            block = ""; kk = 0;
            for (var j = i; j < i + k; j++)
            {
                if(blocks[j] == 'W')
                {
                    if(kk < k)
                    {
                        kk++;
                    }
                    else
                    {
                        break;
                    }
                }

                block += 'B';
            }

            if (block.Length == k && kk < result)
            {
                result = kk;
            }
        }

        return result;
    }
}