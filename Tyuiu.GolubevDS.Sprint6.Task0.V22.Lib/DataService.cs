namespace Tyuiu.GolubevDS.Sprint6.Task0.V22.Lib;
using tyuiu.cources.programming.interfaces.Sprint6;
using System.IO;
using System.Text;

public class DataService : ISprint6Task0V22
{
    public double Calculate(int x)
    {
        double res = (0.7 * Math.Pow(x, 3) + 1.52 * Math.Pow(x, 2));
        return Math.Round(res,3);
    }
}
