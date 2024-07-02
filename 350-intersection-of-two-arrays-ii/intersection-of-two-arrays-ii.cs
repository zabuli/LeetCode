public class Solution {
    public int[] Intersect(int[] nums1, int[] nums2) {
        Array.Sort(nums1);
        Array.Sort(nums2);

        return nums1.Length < nums2.Length
            ? GetIntersect(nums1, nums2)
            : GetIntersect(nums2, nums1);
    }

    private int[] GetIntersect(int[] nums1, int[] nums2) 
    {
        var result = new List<int>();
        var j = 0; 
        var shouldReset = true;

        for (var i = 0; i < nums1.Length; i++)
        {
            if (j == nums2.Length && shouldReset)
            {
                j = 0;
            }

            while (j < nums2.Length && nums2[j] <= nums1[i])
            {
                if (nums2[j] == nums1[i])
                {
                    result.Add(nums2[j]);

                    if (j == nums2.Length - 1)
                    {
                        shouldReset = false;
                    }

                    j++;
                  
                    break;
                }

                j++;
            }
        }

        return result.ToArray();
        //nema byt druhykrat 98
    }
}