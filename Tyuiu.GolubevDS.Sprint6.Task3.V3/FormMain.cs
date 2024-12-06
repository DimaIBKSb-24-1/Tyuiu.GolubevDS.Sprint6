namespace Tyuiu.GolubevDS.Sprint6.Task3.V3;
using Tyuiu.GolubevDS.Sprint6.Task3.V3.Lib;

public partial class FormMain : Form
{
    public FormMain()
    {
        InitializeComponent();
    }
    DataService ds = new DataService();
    int[,] mtrx = new int[5, 5] { { -18, 21, 10, -2, 12 },
        { -18, -10, 33, -20, 32 },
        { 14, -15, -14, 12, -18 },
        { -19, 5, -3, 28, -17 },
        { -14, -9, 23, -13, 11 } };

    private void FormMain_Load(object sender, EventArgs e)
    {
        int rows = mtrx.GetUpperBound(0) + 1;
        int columns = mtrx.Length / rows;
        dataGridView_GDS.ColumnCount = columns;
        dataGridView_GDS.RowCount = rows;

        for (int i = 0; i < columns; i++)
        {
            dataGridView_GDS.Columns[i].Width = 25;
        }

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                dataGridView_GDS.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i, j]);
            }
        }

    }

    private void buttonRes_GDS_Click(object sender, EventArgs e)
    {
        int[,] res = ds.Calculate(mtrx);
        int rows = res.GetUpperBound(0) + 1;
        int columns = res.Length / rows;

        dataGridViewOut_GDS.ColumnCount = columns;
        dataGridViewOut_GDS.RowCount = rows;

        for (int i = 0; i < columns; i++)
        {
            dataGridViewOut_GDS.Columns[i].Width = 25;
        }

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                dataGridViewOut_GDS.Rows[i].Cells[j].Value = Convert.ToString(res[i, j]);
            }
        }
    }

    private void dataGridView_GDS_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }

    private void dataGridViewOut_GDS_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }
}
