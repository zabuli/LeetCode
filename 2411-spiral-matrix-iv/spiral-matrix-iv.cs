/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    bool _isRight = false;
    bool _isLeft = false;
    bool _isDown = false;
    bool _isUp = false;

    public int[][] SpiralMatrix(int m, int n, ListNode head) {
        var result = FillArray(m, n);
        var i = 0;
        var j = 0;

        SetupDirection(isRight: true);
       
        while (head != null)
        {            
            result[i][j] = head.val;
            head = head.next;

            if (_isRight && j < n - 1 && result[i][j + 1] == -1)
            {
                j++;

                if (j == n - 1 || (j < n - 1 && result[i][j + 1] != -1))
                {
                    SetupDirection(isDown: true);
                }
            }
            else if (_isDown && i < m - 1 && result[i + 1][j] == -1)
            {
                i++;

                if (i == m - 1 || (i < m - 1 && result[i + 1][j] != -1))
                {
                    SetupDirection(isLeft: true);
                }
            }
            else if (_isLeft && j > 0 && result[i][j - 1] == -1)
            {
                j--;

                if (j == 0 || (j > 0 && result[i][j - 1] != -1))
                {
                    SetupDirection(isUp: true);
                }
            }
            else if (_isUp && i > 0 && result[i - 1][j] == -1)
            {
                i--;

                if (i == 0 || (i > 0 && result[i - 1][j] != -1))
                {
                    SetupDirection(isRight: true);
                }
            }
            else
            {
                i++;
            }
        }

        return result;
    }

    private void SetupDirection(bool isRight = false, bool isLeft = false, bool isDown = false, bool isUp = false)
    {
        _isRight = isRight;
        _isLeft = isLeft;
        _isDown = isDown;
        _isUp = isUp;
    }

    private static int[][] FillArray(int m, int n)
    {
        var result = new int[m][];

        for (var i = 0; i < m; i++)
        {
            result[i] = new int[n];

            for (var j = 0; j < n; j++)
            {
                result[i][j] = -1;
            }
        }

        return result;
    }
}