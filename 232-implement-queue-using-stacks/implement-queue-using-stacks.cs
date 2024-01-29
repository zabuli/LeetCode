public class MyQueue {
    private Stack<int> _stack {get; set;}
    private Stack<int> _opositeStack {get; set;}

    public MyQueue() {
        _stack = new Stack<int>();
        _opositeStack = new Stack<int>();
    }
    
    public void Push(int x) {
        ReverseStack(_opositeStack, _stack);
        _stack.Push(x);
        ReverseStack(_stack, _opositeStack);
    }
    
    public int Pop() {
        return _opositeStack.Pop();
    }
    
    public int Peek() {
        return _opositeStack.Peek();
    }
    
    public bool Empty() {
        return _opositeStack.Count == 0;
    }

    private void ReverseStack(Stack<int> stack, Stack<int> reversedStack)
    {
        while(stack.Count > 0)
        {
            reversedStack.Push(stack.Pop());
        }
    }
}

/**
 * Your MyQueue object will be instantiated and called as such:
 * MyQueue obj = new MyQueue();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Peek();
 * bool param_4 = obj.Empty();
 */