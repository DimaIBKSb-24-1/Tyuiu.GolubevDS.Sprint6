namespace Tyuiu.GolubevDS.Sprint6.Task2.V12
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
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            textBoxStop_GDS = new TextBox();
            textBoxStart_GDS = new TextBox();
            buttonRes_GDS = new Button();
            buttonInfo = new Button();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(517, 269);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Условие";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBoxStop_GDS);
            groupBox2.Controls.Add(textBoxStart_GDS);
            groupBox2.Location = new Point(12, 313);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(359, 125);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ввод данных";
            // 
            // textBoxStop_GDS
            // 
            textBoxStop_GDS.Location = new Point(200, 78);
            textBoxStop_GDS.Name = "textBoxStop_GDS";
            textBoxStop_GDS.Size = new Size(125, 27);
            textBoxStop_GDS.TabIndex = 1;
            // 
            // textBoxStart_GDS
            // 
            textBoxStart_GDS.Location = new Point(16, 78);
            textBoxStart_GDS.Name = "textBoxStart_GDS";
            textBoxStart_GDS.Size = new Size(125, 27);
            textBoxStart_GDS.TabIndex = 0;
            // 
            // buttonRes_GDS
            // 
            buttonRes_GDS.Location = new Point(408, 391);
            buttonRes_GDS.Name = "buttonRes_GDS";
            buttonRes_GDS.Size = new Size(121, 47);
            buttonRes_GDS.TabIndex = 2;
            buttonRes_GDS.Text = "Результат";
            buttonRes_GDS.UseVisualStyleBackColor = true;
            buttonRes_GDS.Click += buttonRes_GDS_Click;
            buttonRes_GDS.MouseDown += buttonRes_GDS_MouseDown;
            buttonRes_GDS.MouseEnter += buttonRes_GDS_MouseEnter;
            buttonRes_GDS.MouseLeave += buttonRes_GDS_MouseLeave;
            // 
            // buttonInfo
            // 
            buttonInfo.Location = new Point(408, 342);
            buttonInfo.Name = "buttonInfo";
            buttonInfo.Size = new Size(121, 43);
            buttonInfo.TabIndex = 3;
            buttonInfo.Text = "Инфо";
            buttonInfo.UseVisualStyleBackColor = true;
            buttonInfo.Click += buttonInfo_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dataGridView1.Location = new Point(550, 27);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(304, 411);
            dataGridView1.TabIndex = 4;
            // 
            // Column1
            // 
            Column1.HeaderText = "X";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 150;
            // 
            // Column2
            // 
            Column2.HeaderText = "F(X)";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 150;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(874, 43);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(562, 375);
            chart1.TabIndex = 5;
            chart1.Text = "chart1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1261, 450);
            Controls.Add(chart1);
            Controls.Add(dataGridView1);
            Controls.Add(buttonInfo);
            Controls.Add(buttonRes_GDS);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FormMain";
            Text = "Голубев Д.С";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox textBoxStop_GDS;
        private TextBox textBoxStart_GDS;
        private Button buttonRes_GDS;
        private Button buttonInfo;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}
