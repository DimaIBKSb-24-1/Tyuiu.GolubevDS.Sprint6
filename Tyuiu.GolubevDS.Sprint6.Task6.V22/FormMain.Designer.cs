namespace Tyuiu.GolubevDS.Sprint6.Task6.V22
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            buttonOpenFile = new Button();
            openFileTask = new OpenFileDialog();
            toolTip1 = new ToolTip(components);
            buttonRes_GDS = new Button();
            textBoxRes_GDS = new TextBox();
            textBoxInt_GDS = new TextBox();
            groupBox1 = new GroupBox();
            groupBoxRes = new GroupBox();
            buttonInfo = new Button();
            SuspendLayout();
            // 
            // buttonOpenFile
            // 
            buttonOpenFile.Image = Properties.Resources.uNObuI28EKM;
            buttonOpenFile.Location = new Point(12, 14);
            buttonOpenFile.Name = "buttonOpenFile";
            buttonOpenFile.Size = new Size(100, 46);
            buttonOpenFile.TabIndex = 0;
            toolTip1.SetToolTip(buttonOpenFile, "Открыть Файл \r\n\r\n");
            buttonOpenFile.UseVisualStyleBackColor = true;
            buttonOpenFile.Click += buttonOpenFile_Click;
            // 
            // openFileTask
            // 
            openFileTask.FileName = "openFileTask";
            openFileTask.FileOk += openFileTask_FileOk;
            // 
            // toolTip1
            // 
            toolTip1.ToolTipIcon = ToolTipIcon.Info;
            toolTip1.ToolTipTitle = "Подсказка";
            toolTip1.Popup += toolTip1_Popup;
            // 
            // buttonRes_GDS
            // 
            buttonRes_GDS.Image = (Image)resources.GetObject("buttonRes_GDS.Image");
            buttonRes_GDS.Location = new Point(139, 14);
            buttonRes_GDS.Name = "buttonRes_GDS";
            buttonRes_GDS.Size = new Size(114, 46);
            buttonRes_GDS.TabIndex = 1;
            buttonRes_GDS.Text = "Выполнить";
            toolTip1.SetToolTip(buttonRes_GDS, "Выполнить команду \r\n");
            buttonRes_GDS.UseVisualStyleBackColor = true;
            buttonRes_GDS.Click += buttonRes_GDS_Click;
            // 
            // textBoxRes_GDS
            // 
            textBoxRes_GDS.Location = new Point(444, 157);
            textBoxRes_GDS.Multiline = true;
            textBoxRes_GDS.Name = "textBoxRes_GDS";
            textBoxRes_GDS.Size = new Size(332, 281);
            textBoxRes_GDS.TabIndex = 2;
            // 
            // textBoxInt_GDS
            // 
            textBoxInt_GDS.Location = new Point(12, 157);
            textBoxInt_GDS.Multiline = true;
            textBoxInt_GDS.Name = "textBoxInt_GDS";
            textBoxInt_GDS.Size = new Size(319, 281);
            textBoxInt_GDS.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(12, 135);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(319, 303);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // groupBoxRes
            // 
            groupBoxRes.Location = new Point(433, 135);
            groupBoxRes.Name = "groupBoxRes";
            groupBoxRes.Size = new Size(343, 303);
            groupBoxRes.TabIndex = 5;
            groupBoxRes.TabStop = false;
            groupBoxRes.Text = "groupBox2";
            // 
            // buttonInfo
            // 
            buttonInfo.Image = (Image)resources.GetObject("buttonInfo.Image");
            buttonInfo.Location = new Point(662, 24);
            buttonInfo.Name = "buttonInfo";
            buttonInfo.Size = new Size(94, 46);
            buttonInfo.TabIndex = 6;
            buttonInfo.UseVisualStyleBackColor = true;
            buttonInfo.Click += buttonInfo_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonInfo);
            Controls.Add(textBoxInt_GDS);
            Controls.Add(textBoxRes_GDS);
            Controls.Add(buttonRes_GDS);
            Controls.Add(buttonOpenFile);
            Controls.Add(groupBox1);
            Controls.Add(groupBoxRes);
            Name = "FormMain";
            Text = "Голубев Д.С";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonOpenFile;
        private OpenFileDialog openFileTask;
        private ToolTip toolTip1;
        private Button buttonRes_GDS;
        private TextBox textBoxRes_GDS;
        private TextBox textBoxInt_GDS;
        private GroupBox groupBox1;
        private GroupBox groupBoxRes;
        private Button buttonInfo;
    }
}
