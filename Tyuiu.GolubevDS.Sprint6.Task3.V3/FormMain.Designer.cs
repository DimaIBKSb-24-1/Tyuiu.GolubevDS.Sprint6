namespace Tyuiu.GolubevDS.Sprint6.Task3.V3
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
            dataGridView_GDS = new DataGridView();
            groupBoxInt_GDS = new GroupBox();
            groupBoxOut_GDS = new GroupBox();
            dataGridViewOut_GDS = new DataGridView();
            buttonRes_GDS = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView_GDS).BeginInit();
            groupBoxOut_GDS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut_GDS).BeginInit();
            SuspendLayout();
            // 
            // dataGridView_GDS
            // 
            dataGridView_GDS.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView_GDS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_GDS.Location = new Point(256, 22);
            dataGridView_GDS.Name = "dataGridView_GDS";
            dataGridView_GDS.RowHeadersVisible = false;
            dataGridView_GDS.RowHeadersWidth = 51;
            dataGridView_GDS.Size = new Size(280, 222);
            dataGridView_GDS.TabIndex = 0;
            dataGridView_GDS.CellContentClick += dataGridView_GDS_CellContentClick;
            // 
            // groupBoxInt_GDS
            // 
            groupBoxInt_GDS.Location = new Point(12, 12);
            groupBoxInt_GDS.Name = "groupBoxInt_GDS";
            groupBoxInt_GDS.Size = new Size(238, 294);
            groupBoxInt_GDS.TabIndex = 1;
            groupBoxInt_GDS.TabStop = false;
            groupBoxInt_GDS.Text = "Условие";
            // 
            // groupBoxOut_GDS
            // 
            groupBoxOut_GDS.Controls.Add(dataGridViewOut_GDS);
            groupBoxOut_GDS.Location = new Point(542, 22);
            groupBoxOut_GDS.Name = "groupBoxOut_GDS";
            groupBoxOut_GDS.Size = new Size(334, 416);
            groupBoxOut_GDS.TabIndex = 2;
            groupBoxOut_GDS.TabStop = false;
            groupBoxOut_GDS.Text = "Вывод данных";
            // 
            // dataGridViewOut_GDS
            // 
            dataGridViewOut_GDS.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            dataGridViewOut_GDS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOut_GDS.Location = new Point(18, 41);
            dataGridViewOut_GDS.Name = "dataGridViewOut_GDS";
            dataGridViewOut_GDS.RowHeadersVisible = false;
            dataGridViewOut_GDS.RowHeadersWidth = 51;
            dataGridViewOut_GDS.Size = new Size(300, 188);
            dataGridViewOut_GDS.TabIndex = 0;
            dataGridViewOut_GDS.CellContentClick += dataGridViewOut_GDS_CellContentClick;
            // 
            // buttonRes_GDS
            // 
            buttonRes_GDS.Location = new Point(336, 386);
            buttonRes_GDS.Name = "buttonRes_GDS";
            buttonRes_GDS.Size = new Size(119, 52);
            buttonRes_GDS.TabIndex = 3;
            buttonRes_GDS.Text = "Результат";
            buttonRes_GDS.UseVisualStyleBackColor = true;
            buttonRes_GDS.Click += buttonRes_GDS_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(901, 450);
            Controls.Add(buttonRes_GDS);
            Controls.Add(groupBoxOut_GDS);
            Controls.Add(groupBoxInt_GDS);
            Controls.Add(dataGridView_GDS);
            Name = "FormMain";
            Text = "Form1";
            Load += FormMain_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_GDS).EndInit();
            groupBoxOut_GDS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut_GDS).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView_GDS;
        private GroupBox groupBoxInt_GDS;
        private GroupBox groupBoxOut_GDS;
        private DataGridView dataGridViewOut_GDS;
        private Button buttonRes_GDS;
    }
}
