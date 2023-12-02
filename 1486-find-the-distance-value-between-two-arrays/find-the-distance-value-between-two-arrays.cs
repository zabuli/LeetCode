public class Solution {
    public int FindTheDistanceValue(int[] arr1, int[] arr2, int d) {
        Array.Sort(arr2);

        var result = 0;
        int min; int max; int mid;
        bool isDistance;
        for(var i = 0; i < arr1.Length; i++)
        {
            min = 0; 
            max = arr2.Length - 1;
            isDistance = true;
            //4 5 8
            //1 8 9 10
            //2
            while(min <= max)
            {
                mid = (min + max) / 2;
                if (Math.Abs(arr1[i] - arr2[mid]) <= d)
                {
                    isDistance = false;
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

            if (isDistance)
            {
                result++;
            }
        }

        return result;
    }
}