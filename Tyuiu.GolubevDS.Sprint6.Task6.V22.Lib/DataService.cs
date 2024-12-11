namespace Tyuiu.GolubevDS.Sprint6.Task6.V22.Lib;
using tyuiu.cources.programming.interfaces.Sprint6;

public class DataService : ISprint6Task6V22
{
    public string CollectTextFromFile(string str, string path)
    {
        List<string> firstWords = new List<string>();
        using (StreamReader reader = new StreamReader(path))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                var FirstWords = line.Split(' ', StringSplitOptions.RemoveEmptyEntries).FirstOrDefault() ?? string.Empty;
                if (FirstWords.Length > 0)
                {
                    firstWords.Add(FirstWords);
                }
            }
        }
        return string.Join(" ", firstWords);
    }
}
