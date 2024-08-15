public class Solution {
    public bool LemonadeChange(int[] bills) {
        var changes = new int[2];

        for (var i = 0; i < bills.Length; i++)
        {
            if (bills[i] == 5)
            {
                changes[0]++;
            }
            else if (bills[i] == 10)
            {
                if (changes[0] < 1)
                {
                    return false;
                }

                changes[0]--;
                changes[1]++;
            }
            else
            {
                if (changes[1] > 0 && changes[0] > 0)
                {
                    changes[1]--;
                    changes[0]--;
                }
                else if (changes[0] > 2)
                {
                    changes[0] -= 3;
                }
                else
                {
                    return false;
                }
            }
        }

        return true;
    }
}