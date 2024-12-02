namespace Tyuiu.GolubevDS.Sprint6.Task0.V22;
using Tyuiu.GolubevDS.Sprint6.Task0.V22.Lib;

public partial class Form : System.Windows.Forms.Form
{
    public Form()
    {
        InitializeComponent();
    }
    DataService ds = new DataService();
    private void pictureBox1_Click(object sender, EventArgs e)
    {

    }

    private void TextBoxVar(object sender, KeyPressEventArgs e)
    {
        if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
        {
            e.Handled = true;
        }
    }

    private void button1_Click(object sender, EventArgs e)
    {
        try
        {
            textBox3.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBox2.Text)));
        }
        catch
        {
            MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void textBox2_TextChanged(object sender, EventArgs e)
    {

    }

    private void textBox3_TextChanged(object sender, EventArgs e)
    {

    }

    private void buttonHelp_Click(object sender, EventArgs e)
    {
        MessageBox.Show("Таск 0 выполнил студент группы ИБКСб 24 Голубев Д.С", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}
