public class Solution {
    public int SearchInsert(int[] nums, int target) {
       var min = 0; 
       var max = nums.Length; 
       var mid = -1;
       var k = -1;

       while(min < max)
       {
           mid = (min + max) / 2;
           if (mid == k)
           {
               break;
           }
           if (target == nums[mid])
           {
               return mid;
           }
           if (target > nums[mid])
           {
               min = mid;
           }
           else
           {
               max = mid;
           }

           k = mid;
        }

        if (target < nums[mid])
        {
            if (mid == 0)
            {
                return 0;
            }

            return mid - 1;
        }
        
        return mid + 1;
    }
}