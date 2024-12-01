namespace Tyuiu.GolubevDS.Sprint6.Task0.V22.Test;
using Tyuiu.GolubevDS.Sprint6.Task0.V22.Lib;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void ValidCalc()
    {
        DataService ds = new DataService();
        double res = ds.Calculate(2);
        double wait = 11.68;
        Assert.AreEqual(res, wait);
    }
}