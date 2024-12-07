namespace Tyuiu.GolubevDS.Sprint6.Task4.V23
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            groupBox_GDS = new GroupBox();
            buttonSave_GDS = new Button();
            groupBoxInt_GDS = new GroupBox();
            textBoxStop_GDS = new TextBox();
            textBoxStart_GDS = new TextBox();
            textBoxRes_GDS = new TextBox();
            chartRes_GDS = new System.Windows.Forms.DataVisualization.Charting.Chart();
            buttonDone_GDS = new Button();
            groupBoxInt_GDS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartRes_GDS).BeginInit();
            SuspendLayout();
            // 
            // groupBox_GDS
            // 
            groupBox_GDS.Location = new Point(12, 12);
            groupBox_GDS.Name = "groupBox_GDS";
            groupBox_GDS.Size = new Size(555, 103);
            groupBox_GDS.TabIndex = 0;
            groupBox_GDS.TabStop = false;
            groupBox_GDS.Text = "Условие";
            // 
            // buttonSave_GDS
            // 
            buttonSave_GDS.Location = new Point(1108, 35);
            buttonSave_GDS.Name = "buttonSave_GDS";
            buttonSave_GDS.Size = new Size(131, 63);
            buttonSave_GDS.TabIndex = 5;
            buttonSave_GDS.Text = "Сохранить";
            buttonSave_GDS.UseVisualStyleBackColor = true;
            buttonSave_GDS.Click += buttonSave_GDS_Click;
            // 
            // groupBoxInt_GDS
            // 
            groupBoxInt_GDS.Controls.Add(textBoxStop_GDS);
            groupBoxInt_GDS.Controls.Add(textBoxStart_GDS);
            groupBoxInt_GDS.Location = new Point(588, 12);
            groupBoxInt_GDS.Name = "groupBoxInt_GDS";
            groupBoxInt_GDS.Size = new Size(354, 103);
            groupBoxInt_GDS.TabIndex = 1;
            groupBoxInt_GDS.TabStop = false;
            groupBoxInt_GDS.Text = "Ввод данных";
            // 
            // textBoxStop_GDS
            // 
            textBoxStop_GDS.Location = new Point(198, 59);
            textBoxStop_GDS.Name = "textBoxStop_GDS";
            textBoxStop_GDS.Size = new Size(125, 27);
            textBoxStop_GDS.TabIndex = 1;
            // 
            // textBoxStart_GDS
            // 
            textBoxStart_GDS.Location = new Point(20, 59);
            textBoxStart_GDS.Name = "textBoxStart_GDS";
            textBoxStart_GDS.Size = new Size(125, 27);
            textBoxStart_GDS.TabIndex = 0;
            // 
            // textBoxRes_GDS
            // 
            textBoxRes_GDS.Location = new Point(12, 140);
            textBoxRes_GDS.Multiline = true;
            textBoxRes_GDS.Name = "textBoxRes_GDS";
            textBoxRes_GDS.Size = new Size(354, 412);
            textBoxRes_GDS.TabIndex = 2;
            // 
            // chartRes_GDS
            // 
            chartArea1.Name = "ChartArea1";
            chartRes_GDS.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartRes_GDS.Legends.Add(legend1);
            chartRes_GDS.Location = new Point(405, 140);
            chartRes_GDS.Name = "chartRes_GDS";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartRes_GDS.Series.Add(series1);
            chartRes_GDS.Size = new Size(899, 412);
            chartRes_GDS.TabIndex = 3;
            chartRes_GDS.Text = "chart1";
            title1.Name = "Title1";
            title1.Text = "График 4 - 2x +(2+Cosx)/(2x-2)";
            chartRes_GDS.Titles.Add(title1);
            // 
            // buttonDone_GDS
            // 
            buttonDone_GDS.Location = new Point(957, 35);
            buttonDone_GDS.Name = "buttonDone_GDS";
            buttonDone_GDS.Size = new Size(125, 63);
            buttonDone_GDS.TabIndex = 4;
            buttonDone_GDS.Text = "Выполнить";
            buttonDone_GDS.UseVisualStyleBackColor = true;
            buttonDone_GDS.Click += buttonDone_GDS_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1332, 564);
            Controls.Add(buttonSave_GDS);
            Controls.Add(buttonDone_GDS);
            Controls.Add(chartRes_GDS);
            Controls.Add(textBoxRes_GDS);
            Controls.Add(groupBoxInt_GDS);
            Controls.Add(groupBox_GDS);
            MinimumSize = new Size(1350, 611);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Голубев Д.С";
            groupBoxInt_GDS.ResumeLayout(false);
            groupBoxInt_GDS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartRes_GDS).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox_GDS;
        private GroupBox groupBoxInt_GDS;
        private TextBox textBoxStop_GDS;
        private TextBox textBoxStart_GDS;
        private TextBox textBoxRes_GDS;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRes_GDS;
        private Button buttonDone_GDS;
        private Button buttonSave_GDS;
    }
}
