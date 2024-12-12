namespace Tyuiu.GolubevDS.Sprint6.Task7.V10;
using Tyuiu.GolubevDS.Sprint6.Task7.V10.Lib;

public partial class FormMain : Form
{
    public FormMain()
    {
        InitializeComponent();
        openFileDialog.Filter = "Значение разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        saveFileDialog.Filter = "Значение разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
    }
    static int rows;
    static int colums;
    static string openFilePath;
    DataService ds = new DataService();

    public static int[,] LoadFromFileData(string filePath)
    {
        string fileData = File.ReadAllText(filePath);

        fileData = fileData.Replace('\n', '\r');
        string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

        rows = lines.Length;
        colums = lines[0].Split(';').Length;

        int[,] arrayValues = new int[rows, colums];

        for (int i = 0; i < rows; i++)
        {
            string[] line_r = lines[i].Split(';');
            for (int j = 0; j < colums; j++)
            {
                arrayValues[i, j] = Convert.ToInt32(line_r[j]);
            }
        }
        return arrayValues;
    }

    private void buttonInt_GDS_Click(object sender, EventArgs e)
    {
        openFileDialog.ShowDialog();
        openFilePath = openFileDialog.FileName;

        int[,] arrayValues = new int[rows, colums];

        arrayValues = LoadFromFileData(openFilePath);

        dataGridViewInt.ColumnCount = colums;
        dataGridViewInt.RowCount = rows;
        dataGridViewOut.ColumnCount = colums;
        dataGridViewOut.RowCount = rows;

        for (int i = 0; i < colums; i++)
        {
            dataGridViewInt.Columns[i].Width = 25;
            dataGridViewInt.Columns[i].Width = 25;
        }

        for (int r = 0; r < rows; r++)
        {
            for (int c = 0; c < colums; c++)
            {
                dataGridViewInt.Rows[r].Cells[c].Value = arrayValues[r, c];
            }
        }

        arrayValues = ds.GetMatrix(openFilePath);
        buttonRes_GDS.Enabled = true;
    }

    private void buttonRes_GDS_Click(object sender, EventArgs e)
    {
        int[,] arrayValues = new int[rows, colums];
        arrayValues = ds.GetMatrix(openFilePath);

        for (int r = 0; r < rows; r++)
        {
            for (int c = 0; c < colums; c++)
            {
                dataGridViewOut.Rows[r].Cells[c].Value = arrayValues[r, c];
            }
        }

        buttonSave.Enabled = true;
    }

    private void buttonSave_Click(object sender, EventArgs e)
    {
        saveFileDialog.FileName = "OutPutFileTask7.csv";
        saveFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
        saveFileDialog.ShowDialog();

        string path = saveFileDialog.FileName;

        FileInfo fileInfo = new FileInfo(path);
        bool fileExists = fileInfo.Exists;

        if (fileExists)
        {
            File.Delete(path);
        }

        int rows = dataGridViewOut.RowCount;
        int columns = dataGridViewOut.ColumnCount;

        string str = "";

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                if (j != columns - 1)
                {
                    str = str + dataGridViewOut.Rows[i].Cells[j].Value + ";";
                }
                else
                {
                    str = str + dataGridViewOut.Rows[i].Cells[j].Value;
                }
            }
            File.AppendAllText(path, str + Environment.NewLine);
            str = "";
        }
    }

    private void FormMain_Load(object sender, EventArgs e)
    {
        dataGridViewInt.ColumnCount = 50;
        dataGridViewOut.ColumnCount = 50;

        dataGridViewInt.RowCount = 50;
        dataGridViewOut.RowCount = 50;

        for (int i = 0; i < 50; i++)
        {
            dataGridViewInt.Columns[i].Width = 25;
            dataGridViewOut.Columns[i].Width = 25;
        }
    }
}
