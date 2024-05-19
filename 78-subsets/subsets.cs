public class Solution {
    public IList<IList<int>> Subsets(int[] nums) {
        IList<IList<int>> list = new List<IList<int>>(){ new List<int>() };

        for (var i = 0; i < nums.Length; i++)
        {
            list = list.Concat(Subsets(nums, i, new List<IList<int>>())).ToList();
        }

        return list;
    }

    private IList<IList<int>> Subsets(int[] nums, int index, IList<IList<int>> list)
    {
        if (index == nums.Length)
        {
            return list;
        }

        if (list.Count == 0)
        {
            list.Add(new List<int> { nums[index] });
        }
        else
        {
            IList<IList<int>> newList = new List<IList<int>>();

            for (var i = 0; i < list.Count; i++)
            {
                IList<int> last = new List<int>(list[list.Count - i - 1]);
                last.Add(nums[index]);
                newList.Add(last);
            }

            list = list.Concat(newList).ToList();
        }
        
        return Subsets(nums, index + 1, list);
    }
}