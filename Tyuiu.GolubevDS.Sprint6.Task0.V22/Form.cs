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
        if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8)) ;
        e.Handled = true;
    }

    private void button1_Click(object sender, EventArgs e)
    {
        string inputData = textBox2_TextChanged;
        label1.Text = $"Вы ввели: {inputData}";
    }

    private void textBox2_TextChanged(object sender, EventArgs e)
    {

    }
}
