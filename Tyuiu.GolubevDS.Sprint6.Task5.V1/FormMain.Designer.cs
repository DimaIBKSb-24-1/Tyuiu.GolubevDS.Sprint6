namespace Tyuiu.GolubevDS.Sprint6.Task5.V1
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
            buttonDone_GDS = new Button();
            groupBox1 = new GroupBox();
            dataGridViewRes_GDS = new DataGridView();
            chartOut_GDS = new System.Windows.Forms.DataVisualization.Charting.Chart();
            buttonOutData_GDS = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRes_GDS).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartOut_GDS).BeginInit();
            SuspendLayout();
            // 
            // buttonDone_GDS
            // 
            buttonDone_GDS.Location = new Point(549, 27);
            buttonDone_GDS.Name = "buttonDone_GDS";
            buttonDone_GDS.Size = new Size(127, 60);
            buttonDone_GDS.TabIndex = 0;
            buttonDone_GDS.Text = "Выполнить";
            buttonDone_GDS.UseVisualStyleBackColor = true;
            buttonDone_GDS.Click += buttonDone_GDS_Click;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(485, 92);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Условие";
            // 
            // dataGridViewRes_GDS
            // 
            dataGridViewRes_GDS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRes_GDS.Location = new Point(12, 110);
            dataGridViewRes_GDS.Name = "dataGridViewRes_GDS";
            dataGridViewRes_GDS.RowHeadersWidth = 51;
            dataGridViewRes_GDS.Size = new Size(300, 410);
            dataGridViewRes_GDS.TabIndex = 2;
            // 
            // chartOut_GDS
            // 
            chartArea1.Name = "ChartArea1";
            chartOut_GDS.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartOut_GDS.Legends.Add(legend1);
            chartOut_GDS.Location = new Point(351, 110);
            chartOut_GDS.Name = "chartOut_GDS";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartOut_GDS.Series.Add(series1);
            chartOut_GDS.Size = new Size(695, 410);
            chartOut_GDS.TabIndex = 3;
            chartOut_GDS.Text = "chart1";
            // 
            // buttonOutData_GDS
            // 
            buttonOutData_GDS.Location = new Point(703, 27);
            buttonOutData_GDS.Name = "buttonOutData_GDS";
            buttonOutData_GDS.Size = new Size(136, 60);
            buttonOutData_GDS.TabIndex = 4;
            buttonOutData_GDS.Text = "Открыть файл";
            buttonOutData_GDS.UseVisualStyleBackColor = true;
            buttonOutData_GDS.Click += buttonOutData_GDS_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1183, 532);
            Controls.Add(buttonOutData_GDS);
            Controls.Add(chartOut_GDS);
            Controls.Add(dataGridViewRes_GDS);
            Controls.Add(groupBox1);
            Controls.Add(buttonDone_GDS);
            Name = "FormMain";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridViewRes_GDS).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartOut_GDS).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonDone_GDS;
        private GroupBox groupBox1;
        private DataGridView dataGridViewRes_GDS;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartOut_GDS;
        private Button buttonOutData_GDS;
    }
}
