public class KthLargest {
    PriorityQueue<int, int> pQueue = new PriorityQueue<int, int>();
    int kLargest;

    public KthLargest(int k, int[] nums) {
        kLargest = k;

        Array.Sort(nums);

        for (var i = Math.Max(nums.Length - k, 0); i < nums.Length; i++)
        {
            pQueue.Enqueue(nums[i], nums[i]);
        }
    }
    
    public int Add(int val) {
        if (pQueue.Count < kLargest)
        {
            pQueue.Enqueue(val, val);
        }
        else if (pQueue.Peek() < val)
        {
            pQueue.Dequeue();
            pQueue.Enqueue(val, val);
        }

        return pQueue.Peek();
    }
}

/**
 * Your KthLargest object will be instantiated and called as such:
 * KthLargest obj = new KthLargest(k, nums);
 * int param_1 = obj.Add(val);
 */