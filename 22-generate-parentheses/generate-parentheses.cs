public class Solution {
    private IList<string> result = new List<string>();
    public IList<string> GenerateParenthesis(int n) {
        GenerateParenthesis(n, 0, 0, new StringBuilder());
        return result;
    }

    private void GenerateParenthesis(int n, int op, int cp, StringBuilder sb)
    {
        if (sb.Length == n * 2)
        {
            result.Add(sb.ToString());
            return;
        }

        if (op == 0 || op == cp)
        {
            sb.Append('(');
            op++;
            GenerateParenthesis(n, op, cp, sb);
        }
        else if (op == n)
        {
            sb.Append(')');
            cp++;
            GenerateParenthesis(n, op, cp, sb);
        }
        else
        {
            var sbb = new StringBuilder(sb.ToString());
            
            sb.Append('(');
            op++;
            GenerateParenthesis(n, op, cp, sb);

            sbb.Append(')');
            cp++;
            GenerateParenthesis(n, op - 1, cp, sbb);
        }
    }
}