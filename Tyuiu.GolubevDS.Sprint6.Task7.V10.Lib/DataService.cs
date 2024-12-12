namespace Tyuiu.GolubevDS.Sprint6.Task7.V10.Lib;
using tyuiu.cources.programming.interfaces.Sprint6;

public class DataService : ISprint6Task7V10
{
    public int[,] GetMatrix(string path)
    {
        try
        {
            string fileData = File.ReadAllText(path);
            string[] lines = fileData.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            int rows = lines.Length;
            int columns = lines[0].Split(';').Length;
            int[,] matrix = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                string[] values = lines[i].Split(';');
                for (int j = 0; j < columns; j++)
                {
                    if (int.TryParse(values[j], out int value))
                    {
                        // Логика замены значений  
                        if (value >= 5 && value <= 10)
                        {
                            matrix[i, j] = value; // Оставляем значение  
                        }
                        else
                        {
                            matrix[i, j] = value; // Присваиваем оригинальное значение  
                        }
                    }
                    else
                    {
                        // Обработка ошибки парсинга  
                        matrix[i, j] = 0; // Или какое-то другое значение по умолчанию  
                    }
                }
            }
            return matrix;
        }
        catch (Exception ex)
        {
            
            return new int[0, 0]; // Возвращаем пустой массив в случае ошибки  
        }
    }
}
