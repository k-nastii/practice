using ScottPlot.AxisPanels;
using ScottPlot.AxisPanels.Experimental;
using ScottPlot.Plottables;
using System.Linq.Expressions;

namespace WinFormsPractice
{
    partial class Form1
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
            formsPlot1 = new ScottPlot.WinForms.FormsPlot();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button8 = new Button();
            button7 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            textBox1 = new TextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // formsPlot1
            // 
            formsPlot1.DisplayScale = 1F;
            formsPlot1.Location = new Point(48, 16);
            formsPlot1.Margin = new Padding(3, 4, 3, 4);
            formsPlot1.Name = "formsPlot1";
            formsPlot1.Size = new Size(1143, 800);
            formsPlot1.TabIndex = 0;
            formsPlot1.UseWaitCursor = true;
            // 
            // button3
            // 
            button3.Location = new Point(1301, 767);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(96, 53);
            button3.TabIndex = 3;
            button3.Text = "UP";
            button3.UseVisualStyleBackColor = true;
            button3.UseWaitCursor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(1301, 828);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(96, 53);
            button4.TabIndex = 4;
            button4.Text = "DOWN";
            button4.UseVisualStyleBackColor = true;
            button4.UseWaitCursor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(1198, 800);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(96, 53);
            button5.TabIndex = 5;
            button5.Text = "LEFT";
            button5.UseVisualStyleBackColor = true;
            button5.UseWaitCursor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(1403, 800);
            button6.Margin = new Padding(3, 4, 3, 4);
            button6.Name = "button6";
            button6.Size = new Size(96, 53);
            button6.TabIndex = 6;
            button6.Text = "RIGHT";
            button6.UseVisualStyleBackColor = true;
            button6.UseWaitCursor = true;
            button6.Click += button6_Click;
            // 
            // button8
            // 
            button8.Location = new Point(1301, 609);
            button8.Margin = new Padding(3, 4, 3, 4);
            button8.Name = "button8";
            button8.Size = new Size(96, 53);
            button8.TabIndex = 8;
            button8.Text = "SCALE+ Y";
            button8.UseVisualStyleBackColor = true;
            button8.UseWaitCursor = true;
            button8.Click += button8_Click;
            // 
            // button7
            // 
            button7.Location = new Point(1301, 671);
            button7.Margin = new Padding(3, 4, 3, 4);
            button7.Name = "button7";
            button7.Size = new Size(96, 53);
            button7.TabIndex = 9;
            button7.Text = "SCALE- Y";
            button7.UseVisualStyleBackColor = true;
            button7.UseWaitCursor = true;
            button7.Click += button7_Click;
            // 
            // button9
            // 
            button9.Location = new Point(1198, 641);
            button9.Margin = new Padding(3, 4, 3, 4);
            button9.Name = "button9";
            button9.Size = new Size(96, 53);
            button9.TabIndex = 10;
            button9.Text = "SCALE- X";
            button9.UseVisualStyleBackColor = true;
            button9.UseWaitCursor = true;
            button9.Click += button9_Click;
            // 
            // button10
            // 
            button10.Location = new Point(1403, 641);
            button10.Margin = new Padding(3, 4, 3, 4);
            button10.Name = "button10";
            button10.Size = new Size(96, 53);
            button10.TabIndex = 11;
            button10.Text = "SCALE+ X";
            button10.UseVisualStyleBackColor = true;
            button10.UseWaitCursor = true;
            button10.Click += button10_Click;
            // 
            // button11
            // 
            button11.Location = new Point(1278, 360);
            button11.Margin = new Padding(3, 4, 3, 4);
            button11.Name = "button11";
            button11.Size = new Size(138, 53);
            button11.TabIndex = 12;
            button11.Text = "Create from file";
            button11.UseVisualStyleBackColor = true;
            button11.UseWaitCursor = true;
            button11.Click += button11_Click;
            // 
            // button12
            // 
            button12.Location = new Point(1278, 287);
            button12.Margin = new Padding(3, 4, 3, 4);
            button12.Name = "button12";
            button12.Size = new Size(138, 53);
            button12.TabIndex = 1;
            button12.Text = "Create my function";
            button12.UseVisualStyleBackColor = true;
            button12.UseWaitCursor = true;
            button12.Click += button1_Click;
            // 
            // button13
            // 
            button13.Location = new Point(1278, 433);
            button13.Margin = new Padding(3, 4, 3, 4);
            button13.Name = "button13";
            button13.Size = new Size(138, 53);
            button13.TabIndex = 2;
            button13.Text = "Create from input";
            button13.UseVisualStyleBackColor = true;
            button13.UseWaitCursor = true;
            button13.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 14F);
            textBox1.Location = new Point(1278, 515);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(242, 39);
            textBox1.TabIndex = 13;
            textBox1.Text = "Sin(x) + Cos(x)";
            textBox1.UseWaitCursor = true;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 14F);
            textBox2.Location = new Point(1301, 63);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(67, 39);
            textBox2.TabIndex = 14;
            textBox2.Text = "0.01";
            textBox2.UseWaitCursor = true;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 14F);
            textBox3.Location = new Point(1301, 113);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(67, 39);
            textBox3.TabIndex = 15;
            textBox3.Text = "-10.0";
            textBox3.UseWaitCursor = true;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 14F);
            textBox4.Location = new Point(1301, 164);
            textBox4.Margin = new Padding(3, 4, 3, 4);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(67, 39);
            textBox4.TabIndex = 16;
            textBox4.Text = "10.0";
            textBox4.UseWaitCursor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(1239, 67);
            label1.Name = "label1";
            label1.Size = new Size(61, 32);
            label1.TabIndex = 17;
            label1.Text = "Step";
            label1.UseWaitCursor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(1239, 117);
            label2.Name = "label2";
            label2.Size = new Size(56, 32);
            label2.TabIndex = 18;
            label2.Text = "Min";
            label2.UseWaitCursor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(1239, 168);
            label3.Name = "label3";
            label3.Size = new Size(59, 32);
            label3.TabIndex = 19;
            label3.Text = "Max";
            label3.UseWaitCursor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.Location = new Point(1198, 515);
            label4.Name = "label4";
            label4.Size = new Size(74, 32);
            label4.TabIndex = 20;
            label4.Text = "F(x) =";
            label4.UseWaitCursor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(1520, 908);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button13);
            Controls.Add(formsPlot1);
            Controls.Add(button12);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            HelpButton = true;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Кочержинська_ПА-23-1";
            UseWaitCursor = true;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ScottPlot.WinForms.FormsPlot formsPlot1;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button8;
        private Button button7;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private TextBox textBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
