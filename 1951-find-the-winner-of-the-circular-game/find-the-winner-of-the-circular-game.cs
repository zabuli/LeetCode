public class Solution {
    public int FindTheWinner(int n, int k) {
        var queue = GetFilledQueue(n);

        while (queue.Count > 1)
        {
            for (var i = 1; i < k; i++)
            {
                queue.Enqueue(queue.Dequeue()); 
            }

            queue.Dequeue(); 
        }

        return queue.Dequeue();
    }

    private static Queue<int> GetFilledQueue(int n)
    {
        var queue = new Queue<int>();

        for (var i = 1; i <= n; i++)
        {
            queue.Enqueue(i);
        }

        return queue;
    }
}