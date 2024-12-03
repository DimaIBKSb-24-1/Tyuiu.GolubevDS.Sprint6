namespace Tyuiu.GolubevDS.Sprint6.Task1.V1;
using Tyuiu.GolubevDS.Sprint6.Task1.V1.Lib;

public partial class FormMain : Form
{
    public FormMain()
    {
        InitializeComponent();
    }
    DataService ds = new DataService();

    private void textBoxStart_KeyPress(object sender, KeyPressEventArgs e)
    {

    }

    private void textBoxStop_KeyPress(object sender, KeyPressEventArgs e)
    {

    }

    private void buttonRes_Click(object sender, EventArgs e)
    {
        try
        {
            int startStep = Convert.ToInt32(textBoxStart.Text);
            int stopStep = Convert.ToInt32(textBoxStop.Text);
            string strLine;
            int len = ds.GetMassFunction(startStep, stopStep).Length;
            double[] valueArray;
            valueArray = new double[len];
            valueArray = ds.GetMassFunction(startStep, stopStep);
            textBoxOut.Text = "";
            textBoxOut.AppendText("+-----------+-----------+" + Environment.NewLine);
            textBoxOut.AppendText("|     X     |   f(x)    |" + Environment.NewLine);
            textBoxOut.AppendText("+-----------+-----------+" + Environment.NewLine);
            for (int i = 0; i <= len - 1; i++)
            {
                strLine = String.Format("|{0,5:d}      |  {1,5:f2}    |", startStep, valueArray[i]);
                textBoxOut.AppendText(strLine + Environment.NewLine);
                startStep++;
            }
            textBoxOut.AppendText("+-----------+-----------+" + Environment.NewLine);
        }
        catch
        {
            MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void buttonInfo_Click(object sender, EventArgs e)
    {
        MessageBox.Show("Таск 1 выполнил студент группы ИБКСб 24 ", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}
