public class Solution {
    public long MaxKelements(int[] nums, int k) {
        var pq = new PriorityQueue<int, int>(Comparer<int>.Create((a, b) => b - a));

        for (var i = 0; i < nums.Length; i++)
        {
            pq.Enqueue(nums[i], nums[i]);
        }

        long score = 0;

        while (pq.Count > 0 && k > 0)
        {
            var element = pq.Dequeue();
            score += element;
            
            var newScore = (int)Math.Ceiling(element / 3.0);
            pq.Enqueue(newScore, newScore);

            k--;
        }

        return score;
    }
}