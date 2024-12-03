namespace Tyuiu.GolubevDS.Sprint6.Task2.V12;
using Tyuiu.GolubevDS.Sprint6.Task2.V12.Lib;

public partial class FormMain : Form
{
    public FormMain()
    {
        InitializeComponent();
    }
    DataService ds = new DataService();
    private void buttonRes_GDS_Click(object sender, EventArgs e)
    {
        try
        {
            int startValue = Convert.ToInt32(textBoxStart_GDS.Text);
            int stopValue = Convert.ToInt32(textBoxStop_GDS.Text);
            int step = ds.GetMassFunction(startValue, stopValue).Length;
            double[] valueArray = new double[step];
            valueArray = ds.GetMassFunction(startValue, stopValue);

            this.chart1.Titles.Add("График функции F(x)");
            this.chart1.ChartAreas[0].AxisX.Title = "Ось Х";
            this.chart1.ChartAreas[0].AxisY.Title = "Ось Y";

            for (int i = 0; i <= step - 1; i++)
            {
                this.dataGridView1.Rows.Add(Convert.ToString(startValue), Convert.ToString(valueArray[i]));
                this.chart1.Series[0].Points.AddXY(startValue, valueArray[i]);
                startValue++;
            }
        }
        catch
        {
            MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }

    private void buttonInfo_Click(object sender, EventArgs e)
    {
        MessageBox.Show("Таск 2 выполнил студент группы ИБКСб 24 Голубев Д.С", "Сообщение", MessageBoxButtons.OK);
    }

    private void buttonRes_GDS_MouseEnter(object sender, EventArgs e)
    {
        buttonRes_GDS.BackColor = Color.Gray;
    }

    private void buttonRes_GDS_MouseLeave(object sender, EventArgs e)
    {
        buttonRes_GDS.BackColor = Color.LimeGreen;
    }

    private void buttonRes_GDS_MouseDown(object sender, MouseEventArgs e)
    {
        buttonRes_GDS.BackColor = Color.LightSkyBlue;
    }
}
