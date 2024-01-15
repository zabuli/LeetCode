public class Solution {
    public int Maximum69Number (int num) {
        var number = num.ToString();
        var firstIndex = number.IndexOf('6');

        if (firstIndex == 0)
        {
            number = "9" + number.Substring(1);
        }
        else if (firstIndex > 0)
        {
            number = number.Substring(0, firstIndex) + "9" + number.Substring(firstIndex + 1);
        }
        

        return int.Parse(number);
    }
}