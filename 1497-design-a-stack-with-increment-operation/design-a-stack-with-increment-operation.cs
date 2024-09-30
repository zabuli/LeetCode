public class CustomStack {
    private int[] _stack;
    private int _i;

    public CustomStack(int maxSize) {
        _stack = new int[maxSize];
        _i = 0;

        for (var i = 0; i < _stack.Length; i++)
        {
            _stack[i] = -1;
        }
    }
    
    public void Push(int x) {
        if (_i < _stack.Length - 1)
        {
            if (_i < 0 || _stack[0] > -1)
            {
                _i++;
            }
            
            _stack[_i] = x; 
        }
    }
    
    public int Pop() {
        if (_i < 0)
        {
            return -1;
        }

        var val = _stack[_i];
        _stack[_i] = -1;
        _i--;

        return val;
    }
    
    public void Increment(int k, int val) {
        k = Math.Min(k, _stack.Length);

        for (var i = 0; i < k; i++)
        {
            if (_stack[i] == -1)
            {
                break;
            }

            _stack[i] += val;
        }
    }
}

/**
 * Your CustomStack object will be instantiated and called as such:
 * CustomStack obj = new CustomStack(maxSize);
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * obj.Increment(k,val);
 */