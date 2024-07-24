/* The isBadVersion API is defined in the parent class VersionControl.
      bool IsBadVersion(int version); */

public class Solution : VersionControl {
    public int FirstBadVersion(int n) {
        var min = 1;
        var max = n;

        while (min <= max)
        {
            var mid = min + ((max - min) / 2);

            if (IsBadVersion(mid))
            {
                max = mid - 1;
            }
            else
            {
                min = mid + 1;
            }
        }

        return min;
    }
}