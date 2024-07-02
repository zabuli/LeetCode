public class MyStack {
    private Queue<int> _queue1 = new Queue<int>();
    private Queue<int> _queue2 = new Queue<int>();

    public MyStack() {
        _queue1 = new Queue<int>();
        _queue2 = new Queue<int>();
    }
    
    public void Push(int x) {
        _queue2.Enqueue(x);

        while (_queue1.Count > 0)
        {
            _queue2.Enqueue(_queue1.Dequeue());
        }

        _queue1 = _queue2;
        _queue2 = new Queue<int>();
    }
    
    public int Pop() {
        return _queue1.Dequeue();
    }
    
    public int Top() {
        return _queue1.Peek();
    }
    
    public bool Empty() {
        return _queue1.Count == 0 && _queue2.Count == 0;
    }
}

/**
 * Your MyStack object will be instantiated and called as such:
 * MyStack obj = new MyStack();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Top();
 * bool param_4 = obj.Empty();
 */