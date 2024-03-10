public class Solution {
    public int[] Intersection(int[] nums1, int[] nums2) {
    	Array.Sort(nums1);
			Array.Sort(nums2);

			var longerArray = nums1.Length >= nums2.Length ? nums1 : nums2;
			var shorterArray = nums1.Length >= nums2.Length ? nums2 : nums1;
			int min, max, mid;
			var result = new List<int>();
      
      foreach (var number in shorterArray)
			{
				min = 0; max = longerArray.Length;
				while(min <= max)
				{
            mid = (min + max) / 2;
						if (mid > longerArray.Length - 1)
						{
							break;
						}
            if (longerArray[mid] == number)
					  {
						  if (!result.Contains(number))
						  {
                  result.Add(number);
              }					
							break;
						}
						if (number > longerArray[mid])
						{
							min = mid + 1;
            }
						else
						{
							max = mid - 1;
						}
          }
			}

			return result.ToArray();
    }
}