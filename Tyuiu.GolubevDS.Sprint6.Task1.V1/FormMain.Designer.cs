namespace Tyuiu.GolubevDS.Sprint6.Task1.V1
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
            groupBox1 = new GroupBox();
            textBoxStart = new TextBox();
            textBoxStop = new TextBox();
            groupBox2 = new GroupBox();
            buttonRes = new Button();
            buttonInfo = new Button();
            groupBox3 = new GroupBox();
            textBoxOut = new TextBox();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(507, 238);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Условие";
            // 
            // textBoxStart
            // 
            textBoxStart.Location = new Point(27, 399);
            textBoxStart.Name = "textBoxStart";
            textBoxStart.Size = new Size(125, 27);
            textBoxStart.TabIndex = 1;
            textBoxStart.KeyPress += textBoxStart_KeyPress;
            // 
            // textBoxStop
            // 
            textBoxStop.Location = new Point(167, 98);
            textBoxStop.Name = "textBoxStop";
            textBoxStop.Size = new Size(125, 27);
            textBoxStop.TabIndex = 2;
            textBoxStop.KeyPress += textBoxStop_KeyPress;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBoxStop);
            groupBox2.Location = new Point(12, 301);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(311, 137);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ввод данных";
            // 
            // buttonRes
            // 
            buttonRes.Location = new Point(379, 397);
            buttonRes.Name = "buttonRes";
            buttonRes.Size = new Size(123, 41);
            buttonRes.TabIndex = 4;
            buttonRes.Text = "Результат";
            buttonRes.UseVisualStyleBackColor = true;
            buttonRes.Click += buttonRes_Click;
            // 
            // buttonInfo
            // 
            buttonInfo.Location = new Point(392, 346);
            buttonInfo.Name = "buttonInfo";
            buttonInfo.Size = new Size(94, 29);
            buttonInfo.TabIndex = 5;
            buttonInfo.Text = "Инфо";
            buttonInfo.UseVisualStyleBackColor = true;
            buttonInfo.Click += buttonInfo_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBoxOut);
            groupBox3.Location = new Point(525, 20);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(263, 418);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            groupBox3.Text = "Вывод данных";
            // 
            // textBoxOut
            // 
            textBoxOut.Location = new Point(19, 39);
            textBoxOut.Multiline = true;
            textBoxOut.Name = "textBoxOut";
            textBoxOut.Size = new Size(222, 367);
            textBoxOut.TabIndex = 0;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox3);
            Controls.Add(buttonInfo);
            Controls.Add(buttonRes);
            Controls.Add(textBoxStart);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Name = "FormMain";
            Text = "Голубев Д.С";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBoxStart;
        private TextBox textBoxStop;
        private GroupBox groupBox2;
        private Button buttonRes;
        private Button buttonInfo;
        private GroupBox groupBox3;
        private TextBox textBoxOut;
    }
}
