namespace Tyuiu.GolubevDS.Sprint6.Task7.V10.Lib;
using tyuiu.cources.programming.interfaces.Sprint6;

public class DataService : ISprint6Task7V10
{
    public int[,] GetMatrix(string path)
    {
        string fileData = File.ReadAllText(path);

        // Нормализация окончания строк  
        string[] lines = fileData.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

        int rows = lines.Length;
        int columns = lines[0].Split(';').Length; // Предполагается, что все строки имеют одинаковое количество столбцов  
        int[,] matrix = new int[rows, columns];

        for (int i = 0; i < rows; i++)
        {
            string[] values = lines[i].Split(';');

            for (int j = 0; j < columns; j++)
            {
                // Попробуйте парсить и обработать исключения в случае нецелочисленных значений  
                if (int.TryParse(values[j], out int value))
                {
                    if (value >= 5 && value <= 10)
                    {
                        matrix[i, j] = 0; // Заменяем на 0 только если в пределах диапазона  
                    }
                    else
                    {
                        matrix[i, j] = value; // Присваиваем оригинальное значение, если вне диапазона  
                    }
                }
                else
                {
                    // Обработка ошибки парсинга (по желанию): установить значение по умолчанию, залогировать ошибку и т.д.  
                    matrix[i, j] = 0; // или бросить исключение в зависимости от требований  
                }
            }
        }

        return matrix;
    }
}
