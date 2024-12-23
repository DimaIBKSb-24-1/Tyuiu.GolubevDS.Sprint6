﻿namespace Tyuiu.GolubevDS.Sprint6.Task1.V1.Lib;
using tyuiu.cources.programming.interfaces.Sprint6;

public class DataService : ISprint6Task1V1
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
            y = Math.Round(Math.Cos(2 * x) + (Math.Sin(x) / (x + 2.5)) + 2 * x, 2);
            valueArray[count] = y;
            count++;
        }
        return valueArray;
    }
}
