namespace Tyuiu.GolubevDS.Sprint6.Task4.V23.Lib;
using tyuiu.cources.programming.interfaces.Sprint6;

public class DataService : ISprint6Task4V23
{
    public double[] GetMassFunction(int startValue, int stopValue)
    {
        double[] valueArray;
        int len = (stopValue - startValue) + 1;
        valueArray = new double[len];
        double y;
        int cnt = 0;

        for (int x = startValue; x <= stopValue; x++)
        {
            if (x != 1)
            {
                y = Math.Round((4 - 2 * x + ((2 + Math.Cos(x)) / (2 * x - 2))), 2);
            }
            else
            {
                y = 0;
            }


            valueArray[cnt] = y;
            cnt++;
        }

        return valueArray;
    }
}
