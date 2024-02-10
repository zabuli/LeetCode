public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        var p1 = m - 1;
        var p2 = n - 1;
        var p3 = m+n - 1;

        while (p2 >= 0)
        {
            if (p1 >= 0 && nums1[p1] > nums2[p2])
            {
                nums1[p3] = nums1[p1];
                p1--;
            }
            else
            {
                nums1[p3] = nums2[p2];
                p2--;
            }

            p3--;
        }
    }
}