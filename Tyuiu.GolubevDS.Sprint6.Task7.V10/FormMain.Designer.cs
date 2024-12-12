namespace Tyuiu.GolubevDS.Sprint6.Task7.V10
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
            openFileDialog = new OpenFileDialog();
            saveFileDialog = new SaveFileDialog();
            groupBoxTask = new GroupBox();
            textBoxTask = new TextBox();
            buttonInt_GDS = new Button();
            buttonRes_GDS = new Button();
            buttonSave = new Button();
            buttonInfo = new Button();
            toolTipInfo = new ToolTip(components);
            groupBoxInt = new GroupBox();
            dataGridViewInt = new DataGridView();
            groupBoxOut = new GroupBox();
            dataGridViewOut = new DataGridView();
            groupBoxTask.SuspendLayout();
            groupBoxInt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInt).BeginInit();
            groupBoxOut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut).BeginInit();
            SuspendLayout();
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog1";
            // 
            // groupBoxTask
            // 
            groupBoxTask.Controls.Add(textBoxTask);
            groupBoxTask.Location = new Point(13, 78);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Size = new Size(1272, 78);
            groupBoxTask.TabIndex = 0;
            groupBoxTask.TabStop = false;
            groupBoxTask.Text = "Условие";
            // 
            // textBoxTask
            // 
            textBoxTask.Location = new Point(6, 21);
            textBoxTask.Multiline = true;
            textBoxTask.Name = "textBoxTask";
            textBoxTask.Size = new Size(1260, 51);
            textBoxTask.TabIndex = 0;
            textBoxTask.Text = resources.GetString("textBoxTask.Text");
            // 
            // buttonInt_GDS
            // 
            buttonInt_GDS.Image = (Image)resources.GetObject("buttonInt_GDS.Image");
            buttonInt_GDS.Location = new Point(13, 12);
            buttonInt_GDS.Margin = new Padding(3, 2, 3, 2);
            buttonInt_GDS.Name = "buttonInt_GDS";
            buttonInt_GDS.Size = new Size(75, 60);
            buttonInt_GDS.TabIndex = 0;
            toolTipInfo.SetToolTip(buttonInt_GDS, "Ввод данных ");
            buttonInt_GDS.UseVisualStyleBackColor = false;
            buttonInt_GDS.Click += buttonInt_GDS_Click;
            // 
            // buttonRes_GDS
            // 
            buttonRes_GDS.Image = (Image)resources.GetObject("buttonRes_GDS.Image");
            buttonRes_GDS.Location = new Point(94, 12);
            buttonRes_GDS.Name = "buttonRes_GDS";
            buttonRes_GDS.Size = new Size(75, 60);
            buttonRes_GDS.TabIndex = 1;
            toolTipInfo.SetToolTip(buttonRes_GDS, "Выполнить проверку");
            buttonRes_GDS.UseVisualStyleBackColor = false;
            buttonRes_GDS.Click += buttonRes_GDS_Click;
            // 
            // buttonSave
            // 
            buttonSave.Image = (Image)resources.GetObject("buttonSave.Image");
            buttonSave.Location = new Point(175, 12);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(77, 60);
            buttonSave.TabIndex = 2;
            toolTipInfo.SetToolTip(buttonSave, "Сохранить");
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonInfo
            // 
            buttonInfo.Image = (Image)resources.GetObject("buttonInfo.Image");
            buttonInfo.Location = new Point(1187, 12);
            buttonInfo.Name = "buttonInfo";
            buttonInfo.Size = new Size(94, 60);
            buttonInfo.TabIndex = 3;
            toolTipInfo.SetToolTip(buttonInfo, "Узнать информацию о создателе");
            buttonInfo.UseVisualStyleBackColor = false;
            // 
            // groupBoxInt
            // 
            groupBoxInt.Controls.Add(dataGridViewInt);
            groupBoxInt.Location = new Point(13, 162);
            groupBoxInt.Name = "groupBoxInt";
            groupBoxInt.Size = new Size(641, 295);
            groupBoxInt.TabIndex = 4;
            groupBoxInt.TabStop = false;
            groupBoxInt.Text = "Ввод данных";
            // 
            // dataGridViewInt
            // 
            dataGridViewInt.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewInt.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            dataGridViewInt.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInt.Location = new Point(6, 26);
            dataGridViewInt.Name = "dataGridViewInt";
            dataGridViewInt.RowHeadersWidth = 51;
            dataGridViewInt.Size = new Size(629, 263);
            dataGridViewInt.TabIndex = 0;
            // 
            // groupBoxOut
            // 
            groupBoxOut.Controls.Add(dataGridViewOut);
            groupBoxOut.Location = new Point(697, 162);
            groupBoxOut.Name = "groupBoxOut";
            groupBoxOut.Size = new Size(582, 295);
            groupBoxOut.TabIndex = 5;
            groupBoxOut.TabStop = false;
            groupBoxOut.Text = "Вывод данных";
            // 
            // dataGridViewOut
            // 
            dataGridViewOut.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewOut.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            dataGridViewOut.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOut.Location = new Point(16, 26);
            dataGridViewOut.Name = "dataGridViewOut";
            dataGridViewOut.RowHeadersWidth = 51;
            dataGridViewOut.Size = new Size(560, 263);
            dataGridViewOut.TabIndex = 0;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1318, 469);
            Controls.Add(groupBoxOut);
            Controls.Add(groupBoxInt);
            Controls.Add(buttonInfo);
            Controls.Add(buttonSave);
            Controls.Add(buttonRes_GDS);
            Controls.Add(buttonInt_GDS);
            Controls.Add(groupBoxTask);
            Name = "FormMain";
            Text = "Голубев Д.С  Группа ИБКСб 24-1";
            Load += FormMain_Load;
            groupBoxTask.ResumeLayout(false);
            groupBoxTask.PerformLayout();
            groupBoxInt.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewInt).EndInit();
            groupBoxOut.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;
        private GroupBox groupBoxTask;
        private TextBox textBoxTask;
        private Button buttonInt_GDS;
        private Button buttonRes_GDS;
        private Button buttonSave;
        private Button buttonInfo;
        private ToolTip toolTipInfo;
        private GroupBox groupBoxInt;
        private DataGridView dataGridViewInt;
        private GroupBox groupBoxOut;
        private DataGridView dataGridViewOut;
    }
}
