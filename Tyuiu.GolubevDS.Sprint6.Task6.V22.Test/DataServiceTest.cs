namespace Tyuiu.GolubevDS.Sprint6.Task6.V22.Test;
using Tyuiu.GolubevDS.Sprint6.Task6.V22.Lib;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void TestMethod1()
    {
        DataService ds = new DataService();
        string[] paths = { @"C:\DataSprint5\InPutFileTask6V22.txt" };
        string fullPath = Path.Combine(paths);

        FileInfo fileInfo = new FileInfo(fullPath);
        bool fileExists = fileInfo.Exists;
        bool wait = true;
        Assert.AreEqual(wait, fileExists);
    }
}