public class Solution {
    public int StrStr(string haystack, string needle) {
        int k = -1; int j = 0; int l = -1;

        for (var i = 0; i < haystack.Length; i++)
        {
            if (haystack[i] == needle[0])
            {
                if (k == -1)
                {
                     k = i;
                }
                else if (l == -1)
                {
                    l = i;
                }
            }

            if (k != -1 && j < needle.Length)
            {
                if (haystack[i] != needle[j])
                {
                    k = -1;
                    j = 0;
                    if (l != -1)
                    {
                        i = l - 1;
                        l = -1;
                    }
                }
                else
                {
                    j++;
                }
            }

            if (j == needle.Length)
            {
                return k;
            }
        }

        return -1;
    }
}