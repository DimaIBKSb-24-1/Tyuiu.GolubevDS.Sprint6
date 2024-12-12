namespace Tyuiu.GolubevDS.Sprint6.Task7.V10.Lib;
using tyuiu.cources.programming.interfaces.Sprint6;

public class DataService : ISprint6Task7V10
{
    public int[,] GetMatrix(string path)
    {
        string fileData = File.ReadAllText(path);

        fileData = fileData.Replace('\n', '\r');
        string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);


        int rows = lines.Length;
        int columns = lines[0].Split(';').Length;
        int[,] matrix = new int[rows, columns];


        for (int i = 0; i < rows; i++)
        {
            string[] values = lines[i].Split(';');

            for (int j = 0; j < columns; j++)
            {
                matrix[i, j] = int.Parse(values[j]);

                if (matrix[i, j] >= 5 && matrix[i, j] <= 10)
                {
                    matrix[i, j] = 0;
                }

            }
        }
        return matrix;
    }
}
