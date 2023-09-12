public class Solution {
    public string DefangIPaddr(string address) {
        var result = "";
        foreach(var character in address)
        {
            if (character == '.')
            {
                result += "[" + character + "]";
            }
            else
            {
                result += character;
            }
        }

        return result;
    }
}