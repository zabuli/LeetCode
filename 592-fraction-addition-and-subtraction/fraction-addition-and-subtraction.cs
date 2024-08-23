public class Solution {
    public string FractionAddition(string expression) {
        var down = GetDownPart(expression);
        var up = GetUpPart(expression, down);

        if (up == 0)
        {
            return "0/1";
        }

        if (down == 0)
        {
            down = 1;
        }

        var gcf = GCF(up, down);
        Console.WriteLine(gcf);

        if (gcf > 1 || gcf < -1)
        {
            up = up / gcf;
            down = down / gcf;
        }

        if (down < 0)
        {
            up = -1 * up;
            down = -1 * down;
        }

        return up.ToString() + "/" + down.ToString();
    }

    private static int GetUpPart(string expression, int down)
    {
        var up = 0;
        var i = 0;

        while (i < expression.Length)
        {
            var upPart = "";
            var downPart = "";
            var isMinus = expression[i] == '-';

            if (isMinus)
            {
                i++;
            }

            while (i < expression.Length && expression[i] != '/')
            {
                upPart += expression[i];
                i++;
            }

            i++;

            while (i < expression.Length && expression[i] != '+' && expression[i] != '-')
            {
                downPart += expression[i];
                i++;
            }

            up += GetUp(int.Parse(upPart), int.Parse(downPart), down, isMinus);
        }

        return up;
    }

    private static int GetUp(int currentUp, int currentDown, int down, bool isMinus)
    {
        var result = down / currentDown;

        result = isMinus 
            ? result * (currentUp * (-1))
            : result * currentUp; 

        return result;
    }

    private static int GetDownPart(string expression)
    {
        var down = 1;
        var i = 0;

        while (i < expression.Length)
        {
            if (expression[i] == '/')
            {
                i++;

                var downPart = "";

                while (i < expression.Length && expression[i] != '+' && expression[i] != '-')
                {
                    downPart += expression[i];
                    i++;
                }

                if (down == 1)
                {
                    down = int.Parse(downPart);
                }
                else
                {
                    down = LCM(down, int.Parse(downPart));
                }
            }

            i++;
        }

        return down;
    }

    private static int LCM(int a, int b)
    {
        return (a / GCF(a, b)) * b;
    }

    private static int GCF(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }

        return a;
    }
}