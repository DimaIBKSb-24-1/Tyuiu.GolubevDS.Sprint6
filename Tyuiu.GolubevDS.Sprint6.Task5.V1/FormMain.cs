namespace Tyuiu.GolubevDS.Sprint6.Task5.V1;
using Tyuiu.GolubevDS.Sprint6.Task5.V1.Lib;

public partial class FormMain : Form
{
    public FormMain()
    {
        InitializeComponent();
    }
    DataService ds = new DataService();
    string path = @"C:\DataSprint5\InPutFileTask5V1.txt";

    private void buttonDone_GDS_Click(object sender, EventArgs e)
    {
        dataGridViewRes_GDS.ColumnCount = 2;
        dataGridViewRes_GDS.Columns[0].Width = 20;
        dataGridViewRes_GDS.Columns[1].Width = 50;

        this.chartOut_GDS.ChartAreas[0].AxisX.Title = "Îñü Õ";
        this.chartOut_GDS.ChartAreas[0].AxisY.Title = "Îñü Y";

        chartOut_GDS.Series[0].Points.Clear();
        double[] numsMass = new double[ds.len];
        numsMass = ds.LoadFromDataFile(path);
        for (int i = 0; i < numsMass.Length; i++)
        {
            dataGridViewRes_GDS.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
            chartOut_GDS.Series[0].Points.AddXY(i, numsMass[i]);
        }
    }

    private void buttonOutData_GDS_Click(object sender, EventArgs e)
    {
        System.Diagnostics.Process txt = new System.Diagnostics.Process();
        txt.StartInfo.FileName = "notepad.exe";
        txt.StartInfo.Arguments = path;
        txt.Start();
    }
}
