namespace Tyuiu.GolubevDS.Sprint6.Task4.V23;
using Tyuiu.GolubevDS.Sprint6.Task4.V23.Lib;

public partial class FormMain : Form
{
    public FormMain()
    {
        InitializeComponent();
    }
    DataService ds = new DataService();

    private void buttonDone_GDS_Click(object sender, EventArgs e)
    {
        try
        {
            int startStep = Convert.ToInt32(textBoxStart_GDS.Text);
            int stopStep = Convert.ToInt32(textBoxStop_GDS.Text);
            int len = ds.GetMassFunction(startStep, stopStep).Length;
            double[] valueArray;
            valueArray = new double[len];
            valueArray = ds.GetMassFunction(startStep, stopStep);
            this.chartRes_GDS.ChartAreas[0].AxisX.Title = "Ось Х";
            this.chartRes_GDS.ChartAreas[0].AxisY.Title = "Ось Y";

            textBoxRes_GDS.Text = "";

            chartRes_GDS.Series[0].Points.Clear();
            for (int i = 0; i <= len - 1; i++)
            {
                chartRes_GDS.Series[0].Points.AddXY(startStep, valueArray[i]);
                textBoxRes_GDS.AppendText(valueArray[i] + Environment.NewLine);
                startStep++;
            }
        }
        catch
        {
            MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }

    private void buttonSave_GDS_Click(object sender, EventArgs e)
    {
        try
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4V23.txt";
            File.WriteAllText(path, textBoxRes_GDS.Text);

            DialogResult dialogResult = MessageBox.Show("Файл" + path + "успешно сохранён\n Открыть его в блокноте?", "Сообщение " , MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                System.Diagnostics.Process txt = new System.Diagnostics.Process();
                txt.StartInfo.FileName = "notepad.exe";
                txt.StartInfo.Arguments = path;
                txt.Start();
            }
        }
        catch 
        {
            MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
