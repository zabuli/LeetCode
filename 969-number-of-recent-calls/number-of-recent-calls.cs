public class RecentCounter {
    private List<int> _counters = new List<int>();

    public RecentCounter() {
        _counters = new List<int>();
    }
    
    public int Ping(int t) {
        _counters.Add(t);
        return _counters.Count(x => x >= t - 3000 && x <= t);
    }
}

/**
 * Your RecentCounter object will be instantiated and called as such:
 * RecentCounter obj = new RecentCounter();
 * int param_1 = obj.Ping(t);
 */