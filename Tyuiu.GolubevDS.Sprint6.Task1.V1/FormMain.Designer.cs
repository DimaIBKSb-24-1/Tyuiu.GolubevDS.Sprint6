namespace Tyuiu.GolubevDS.Sprint6.Task1.V1;

using System;
using Tyuiu.GolubevDS.Sprint6.Task1.V1.Lib;

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

    private void InitializeComponent()
    {
        InitializeComponent(textBox_GDS);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent(TextBox textBox_GDS)
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
        groupBox_GDS = new GroupBox();
        textBox_GDS = new TextBox();
        groupBox1_GDS = new GroupBox();
        textBoxStart_GDS = new TextBox();
        textBoxStop_GDS = new TextBox();
        textBoxInfoStart = new TextBox();
        textBoxInfoStop_GDS = new TextBox();
        buttonRes = new Button();
        buttonInfo = new Button();
        groupBoxOut = new GroupBox();
        
        groupBox_GDS.SuspendLayout();
        groupBox1_GDS.SuspendLayout();
        groupBoxOut.SuspendLayout();
        SuspendLayout();
        // 
        // groupBox_GDS
        // 
        groupBox_GDS.Controls.Add(textBox_GDS);
        groupBox_GDS.Location = new Point(12, 12);
        groupBox_GDS.Name = "groupBox_GDS";
        groupBox_GDS.Size = new Size(488, 217);
        groupBox_GDS.TabIndex = 0;
        groupBox_GDS.TabStop = false;
        groupBox_GDS.Text = "Условие";
        // 
        // textBox_GDS
        // 
        textBox_GDS.BackColor = SystemColors.Control;
        textBox_GDS.Location = new Point(6, 26);
        textBox_GDS.Multiline = true;
        textBox_GDS.Name = "textBox_GDS";
        textBox_GDS.Size = new Size(461, 185);
        textBox_GDS.TabIndex = 1;
        textBox_GDS.Text = resources.GetString("textBox_GDS.Text");
        textBox_GDS.TextChanged += this.textBox1_TextChanged;
        // 
        // groupBox1_GDS
        // 
        groupBox1_GDS.Controls.Add(textBoxInfoStop_GDS);
        groupBox1_GDS.Controls.Add(textBoxInfoStart);
        groupBox1_GDS.Controls.Add(textBoxStop_GDS);
        groupBox1_GDS.Controls.Add(textBoxStart_GDS);
        groupBox1_GDS.Location = new Point(18, 295);
        groupBox1_GDS.Name = "groupBox1_GDS";
        groupBox1_GDS.Size = new Size(325, 143);
        groupBox1_GDS.TabIndex = 1;
        groupBox1_GDS.TabStop = false;
        groupBox1_GDS.Text = "Ввод данных";
        // 
        // textBoxStart_GDS
        // 
        textBoxStart_GDS.Location = new Point(20, 91);
        textBoxStart_GDS.Name = "textBoxStart_GDS";
        textBoxStart_GDS.Size = new Size(125, 27);
        textBoxStart_GDS.TabIndex = 2;
        textBoxStart_GDS.KeyPress += this.textBoxStart_GDS_KeyPress;
        // 
        // textBoxStop_GDS
        // 
        textBoxStop_GDS.Location = new Point(184, 91);
        textBoxStop_GDS.Name = "textBoxStop_GDS";
        textBoxStop_GDS.Size = new Size(125, 27);
        textBoxStop_GDS.TabIndex = 3;
        textBoxStop_GDS.KeyPress += this.textBoxStop_GDS_KeyPress;
        // 
        // textBoxInfoStart
        // 
        textBoxInfoStart.BackColor = SystemColors.Control;
        textBoxInfoStart.Location = new Point(20, 58);
        textBoxInfoStart.Name = "textBoxInfoStart";
        textBoxInfoStart.Size = new Size(125, 27);
        textBoxInfoStart.TabIndex = 4;
        textBoxInfoStart.Text = "Начало шага";
        // 
        // textBoxInfoStop_GDS
        // 
        textBoxInfoStop_GDS.BackColor = SystemColors.Control;
        textBoxInfoStop_GDS.Location = new Point(184, 58);
        textBoxInfoStop_GDS.Name = "textBoxInfoStop_GDS";
        textBoxInfoStop_GDS.Size = new Size(125, 27);
        textBoxInfoStop_GDS.TabIndex = 5;
        textBoxInfoStop_GDS.Text = "Конец шага";
        // 
        // buttonRes
        // 
        buttonRes.Location = new Point(375, 373);
        buttonRes.Name = "buttonRes";
        buttonRes.Size = new Size(125, 65);
        buttonRes.TabIndex = 2;
        buttonRes.Text = "Решение";
        buttonRes.UseVisualStyleBackColor = true;
        buttonRes.Click += this.buttonRes_Click;
        // 
        // buttonInfo
        // 
        buttonInfo.Location = new Point(386, 320);
        buttonInfo.Name = "buttonInfo";
        buttonInfo.Size = new Size(104, 47);
        buttonInfo.TabIndex = 3;
        buttonInfo.Text = "Справка";
        buttonInfo.UseVisualStyleBackColor = true;
        // 
        // groupBoxOut
        // 
     
        groupBoxOut.Location = new Point(523, 12);
        groupBoxOut.Name = "groupBoxOut";
        groupBoxOut.Size = new Size(265, 426);
        groupBoxOut.TabIndex = 4;
        groupBoxOut.TabStop = false;
        groupBoxOut.Text = "Вывод данных";
        // 
        // textBoxEndRes
        // 
    
        // 
        // FormMain
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(groupBoxOut);
        Controls.Add(buttonInfo);
        Controls.Add(buttonRes);
        Controls.Add(groupBox1_GDS);
        Controls.Add(groupBox_GDS);
        Name = "FormMain";
        Text = "Form1";
        Load += FormMain_Load;
        groupBox_GDS.ResumeLayout(false);
        groupBox_GDS.PerformLayout();
        groupBox1_GDS.ResumeLayout(false);
        groupBox1_GDS.PerformLayout();
        groupBoxOut.ResumeLayout(false);
        groupBoxOut.PerformLayout();
        ResumeLayout(false);
    }

   

    #endregion

    private GroupBox groupBox_GDS;
    private TextBox textBox_GDS;
    private GroupBox groupBox1_GDS;
    private TextBox textBoxInfoStop_GDS;
    private TextBox textBoxInfoStart;
    private TextBox textBoxStop_GDS;
    private TextBox textBoxStart_GDS;
    private Button buttonRes;
    private Button buttonInfo;
    private GroupBox groupBoxOut;
    
}
