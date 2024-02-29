namespace Basic_Calculator
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
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            button16 = new Button();
            button17 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 28F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(12, 90);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(466, 82);
            textBox1.TabIndex = 0;
            textBox1.Text = "0";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(12, 302);
            button1.Name = "button1";
            button1.Size = new Size(97, 91);
            button1.TabIndex = 1;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btn;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(115, 302);
            button2.Name = "button2";
            button2.Size = new Size(97, 91);
            button2.TabIndex = 2;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btn;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(218, 302);
            button3.Name = "button3";
            button3.Size = new Size(97, 91);
            button3.TabIndex = 3;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += btn;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(12, 399);
            button4.Name = "button4";
            button4.Size = new Size(97, 91);
            button4.TabIndex = 4;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += btn;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(115, 399);
            button5.Name = "button5";
            button5.Size = new Size(97, 91);
            button5.TabIndex = 5;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += btn;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point);
            button6.Location = new Point(12, 496);
            button6.Name = "button6";
            button6.Size = new Size(97, 91);
            button6.TabIndex = 6;
            button6.Text = "7";
            button6.UseVisualStyleBackColor = true;
            button6.Click += btn;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point);
            button7.Location = new Point(218, 399);
            button7.Name = "button7";
            button7.Size = new Size(97, 91);
            button7.TabIndex = 7;
            button7.Text = "6";
            button7.UseVisualStyleBackColor = true;
            button7.Click += btn;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point);
            button8.Location = new Point(115, 496);
            button8.Name = "button8";
            button8.Size = new Size(97, 91);
            button8.TabIndex = 8;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += btn;
            // 
            // button9
            // 
            button9.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point);
            button9.Location = new Point(218, 496);
            button9.Name = "button9";
            button9.Size = new Size(97, 91);
            button9.TabIndex = 9;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += btn;
            // 
            // button10
            // 
            button10.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point);
            button10.Location = new Point(12, 593);
            button10.Name = "button10";
            button10.Size = new Size(97, 91);
            button10.TabIndex = 10;
            button10.Text = "0";
            button10.UseVisualStyleBackColor = true;
            button10.Click += btn;
            // 
            // button11
            // 
            button11.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point);
            button11.Location = new Point(115, 593);
            button11.Name = "button11";
            button11.Size = new Size(97, 91);
            button11.TabIndex = 11;
            button11.Text = ".";
            button11.UseVisualStyleBackColor = true;
            button11.Click += btn;
            // 
            // button12
            // 
            button12.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            button12.Location = new Point(218, 593);
            button12.Name = "button12";
            button12.Size = new Size(97, 91);
            button12.TabIndex = 12;
            button12.Text = "Clear";
            button12.UseVisualStyleBackColor = true;
            button12.Click += button12_Click;
            // 
            // button13
            // 
            button13.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point);
            button13.Location = new Point(366, 302);
            button13.Name = "button13";
            button13.Size = new Size(97, 91);
            button13.TabIndex = 13;
            button13.Text = "+";
            button13.UseVisualStyleBackColor = true;
            button13.Click += btn;
            // 
            // button14
            // 
            button14.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point);
            button14.Location = new Point(366, 399);
            button14.Name = "button14";
            button14.Size = new Size(97, 91);
            button14.TabIndex = 14;
            button14.Text = "-";
            button14.UseVisualStyleBackColor = true;
            button14.Click += btn;
            // 
            // button15
            // 
            button15.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point);
            button15.Location = new Point(366, 496);
            button15.Name = "button15";
            button15.Size = new Size(97, 91);
            button15.TabIndex = 15;
            button15.Text = "*";
            button15.UseVisualStyleBackColor = true;
            button15.Click += btn;
            // 
            // button16
            // 
            button16.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point);
            button16.Location = new Point(366, 593);
            button16.Name = "button16";
            button16.Size = new Size(97, 91);
            button16.TabIndex = 16;
            button16.Text = "/";
            button16.UseVisualStyleBackColor = true;
            button16.Click += btn;
            // 
            // button17
            // 
            button17.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point);
            button17.Location = new Point(366, 205);
            button17.Name = "button17";
            button17.Size = new Size(97, 91);
            button17.TabIndex = 17;
            button17.Text = "=";
            button17.UseVisualStyleBackColor = true;
            button17.Click += button17_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(451, 9);
            label1.Name = "label1";
            label1.Size = new Size(27, 32);
            label1.TabIndex = 18;
            label1.Text = "x";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 58);
            label2.Name = "label2";
            label2.Size = new Size(236, 28);
            label2.TabIndex = 19;
            label2.Text = "G Shock Calculator";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 175);
            label3.Name = "label3";
            label3.Size = new Size(324, 28);
            label3.TabIndex = 20;
            label3.Text = "Sheeshable Calcu So Good";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Beige;
            ClientSize = new Size(490, 694);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button17);
            Controls.Add(button16);
            Controls.Add(button15);
            Controls.Add(button14);
            Controls.Add(button13);
            Controls.Add(button12);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bert Calculator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button16;
        private Button button17;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}