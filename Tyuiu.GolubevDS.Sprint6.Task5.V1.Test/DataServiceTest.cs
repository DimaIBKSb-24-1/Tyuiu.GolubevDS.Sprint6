namespace Tyuiu.GolubevDS.Sprint6.Task5.V1.Test;
using Tyuiu.GolubevDS.Sprint6.Task5.V1.Lib;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void TestMethod1()
    {
        string path = @"C:\DataSprint5\InPutFileTask5V1.txt";

        FileInfo fileInfo = new FileInfo(path);
        bool fileExists = fileInfo.Exists;
        bool wait = true;
        Assert.AreEqual(wait, fileExists);
    }
}