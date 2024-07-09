public class LRUCache {
    private int _capacity;
    private Dictionary<int, LinkedListNode<CacheItem>> _values;
    private LinkedList<CacheItem> _cachedItems;

    public LRUCache(int capacity) {
        _capacity = capacity;
        _values = new Dictionary<int, LinkedListNode<CacheItem>>();
        _cachedItems = new LinkedList<CacheItem>();
    }
    
    public int Get(int key) {
        if (!_values.TryGetValue(key, out var value))
        {
            return -1;
        }

        _cachedItems.Remove(value);
        _cachedItems.AddFirst(value);
        return value.Value.Value;
    }
    
    public void Put(int key, int value) {
        if (!_values.ContainsKey(key))
        {
            if (_cachedItems.Count == _capacity)
            {
                var node = _cachedItems.Last;
                _cachedItems.RemoveLast();
                _values.Remove(node.Value.Key);
            }

            _cachedItems.AddFirst(new LinkedListNode<CacheItem>(new CacheItem(key, value)));
            _values.Add(key, _cachedItems.First);
        }
        else
        {
            _values[key].Value.Value = value;
            _cachedItems.Remove(_values[key]);
            _cachedItems.AddFirst(_values[key]);
        }
    }

    private class CacheItem
    {
        public int Key { get; set; }
        public int Value { get; set; }

        public CacheItem(int key, int value)
        {
            Key = key;
            Value = value;
        }
    }
}

/**
 * Your LRUCache object will be instantiated and called as such:
 * LRUCache obj = new LRUCache(capacity);
 * int param_1 = obj.Get(key);
 * obj.Put(key,value);
 */