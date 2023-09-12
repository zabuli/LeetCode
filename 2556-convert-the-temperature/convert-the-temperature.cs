public class Solution {
    public double[] ConvertTemperature(double celsius) {
        return new double[2]{ Math.Round(celsius + 273.15d, 4), Math.Round(celsius * 1.80d  + 32.00d, 4) };
    }
}