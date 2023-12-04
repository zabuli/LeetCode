public class Solution {
    public int CalPoints(string[] operations) {
        var stack = new Stack<int>();
        foreach(var operation in operations)
        {
            if(int.TryParse(operation, out int number))
            {
                stack.Push(number);
            }
            switch(operation)
            {
                case "+":
                    stack.Push(GetPlus(stack));
                    break;
                case "D":
                    stack.Push(GetD(stack));
                    break;
                case "C":
                    stack = GetC(stack);
                    break;
                default:
                    break;
            }
        }
    
        return GetCalPointsResult(stack);
    }

    private static int GetPlus(Stack<int> stack)
    {
        var first = stack.Pop();
        var second = stack.Pop();
        var result = first + second;
        stack.Push(second);
        stack.Push(first);

        return result;
    }

    private static int GetD(Stack<int> stack)
    {
        return 2 * stack.Peek();
    }

    private Stack<int> GetC(Stack<int> stack)
    {
        stack.Pop();
        return stack;
    }

    private static int GetCalPointsResult(Stack<int> stack)
    {
        var result = 0;
        foreach(var number in stack)
        {
            result += number;
        }
        return result;
    }
}