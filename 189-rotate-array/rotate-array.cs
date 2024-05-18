public class Solution {
    public void Rotate(int[] nums, int k) {
        var originNums = nums.ToArray();
        var i = 0;
        k = k > nums.Length ? k % nums.Length : k;
        
        while (nums.Length - k + i < nums.Length)
        {
            nums[i] = originNums[nums.Length - k + i];
            i++;
        }   

        var j = 0;

        while (i < nums.Length)
        {
            nums[i] = originNums[j];
            j++;
            i++;
        }
    }

    //k = 2
    //2 % 7 = 2
    //[0] = [5] = nums.Length - k + index = 7 - 2 + 0 = 5
    //[1] = [6] = nums.Length - k + index = 7 - 2 + 1 = 6
    //[2] = [7] = nums.Length - k + index = 7 - 2 + 2 = 7
    //[3] = [0]
    //[4] = [1]
    //[5] = [2]
    //[6] = [3]
    //[7] = [4]

    //k = 6
    //[0] = [2]
    //[1] = [3]
    //[2] = [0]
    //[3] = [1]

    //k = 2
    //[0] = [2]
    //[1] = [3]
    //[2] = [0]
    //[3] = [1]
}