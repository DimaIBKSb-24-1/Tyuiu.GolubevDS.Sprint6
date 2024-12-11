namespace Tyuiu.GolubevDS.Sprint6.Task6.V22;
using Tyuiu.GolubevDS.Sprint6.Task6.V22.Lib;

public partial class FormMain : Form
{
    public FormMain()
    {
        InitializeComponent();
    }
    string openFilePath;
    DataService ds = new DataService();

    private void buttonOpenFile_Click(object sender, EventArgs e)
    {
        openFileTask.ShowDialog();

        // �������� ���� ���������� �����  
        openFilePath = openFileTask.FileName;

        // ��������� ����� �� ����� � ���������� ��� ��� ����� � TextBox  
        textBoxInt_GDS.Text = File.ReadAllText(openFilePath); // ���������, ��� ������������ �������� Text  

        // �������� ����� ���������� �����  
        groupBox1.Text += " " + openFileTask.FileName;

        // �������� ������  
        buttonRes_GDS.Enabled = true;
    }

    private void openFileTask_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
    {

    }

    private void toolTip1_Popup(object sender, PopupEventArgs e)
    {

    }

    private void buttonRes_GDS_Click(object sender, EventArgs e)
    {
        string srt = "**";
        textBoxRes_GDS.Text = ds.CollectTextFromFile(srt, openFilePath);
    }

    private void buttonInfo_Click(object sender, EventArgs e)
    {
        FormAbout formAbout = new FormAbout();
        formAbout.ShowDialog();
    }
}
