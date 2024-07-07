public class Solution {
    public int NumWaterBottles(int numBottles, int numExchange) {
        var result = numBottles;
        var exchange = numBottles / numExchange; 
        var rest = numBottles % numExchange; 

        while (exchange > 0)
        {
            var originExchange = exchange;

            result += originExchange; 
            exchange = (originExchange + rest) / numExchange; 
            rest = (originExchange + rest) % numExchange; 
        }

        return result;
    }
}