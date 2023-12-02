public class Solution {
    public int FindTheDistanceValue(int[] arr1, int[] arr2, int d) {
        Array.Sort(arr2);

        var result = 0;
        for(var i = 0; i < arr1.Length; i++)
        {
            result += GetDistanceValue(arr1, arr2, d, i);
        }

        return result;
    }

    private int GetDistanceValue(int[] arr1, int[] arr2, int d, int i)
    {
        var min = 0; var mid = 0;
        var max = arr2.Length - 1;
        var isDistance = false;

        while(min <= max)
        {
            mid = (min + max) / 2;
            if (Math.Abs(arr1[i] - arr2[mid]) <= d)
            {
                isDistance = true;
                break;
            }
            else if (arr1[i] > arr2[mid])
            {
                min = mid + 1;
            }
            else
            {
                max = mid - 1;
            }
        }
        
        return isDistance ? 0 : 1;
    }
}