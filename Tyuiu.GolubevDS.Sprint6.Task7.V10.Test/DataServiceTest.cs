namespace Tyuiu.GolubevDS.Sprint6.Task7.V10.Test;
using Tyuiu.GolubevDS.Sprint6.Task7.V10.Lib;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void TestMethod1()
    {
        DataService ds = new DataService();
        string path = @"C:\DataSprint6\InPutDataFileTask7V10.csv";
        FileInfo file = new FileInfo(path);
        Assert.AreEqual(true, file.Exists);
    }
}