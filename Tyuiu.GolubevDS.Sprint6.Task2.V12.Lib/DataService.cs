namespace Tyuiu.GolubevDS.Sprint6.Task2.V12.Lib;
using tyuiu.cources.programming.interfaces.Sprint6;

public class DataService : ISprint6Task2V12
{
    public double[] GetMassFunction(int startValue, int stopValue)
    {
        double[] valueArray;
        int len = stopValue - startValue + 1;
        valueArray = new double[len];
        double y;
        int count = 0;
        for (int x = startValue; x <= stopValue; x++)
        {
            y = Math.Round((2 * x + 6) / ((Math.Cos(x)) + x) - 3 , 2);
            valueArray[count] = y;
            count++;
        }
        return valueArray;
    }
}
