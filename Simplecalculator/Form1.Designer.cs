namespace Simplecalculator
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("STXinwei", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(55, 59);
            label1.Name = "label1";
            label1.Size = new Size(50, 12);
            label1.TabIndex = 0;
            label1.Text = "Value 1";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("STXinwei", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(55, 115);
            label2.Name = "label2";
            label2.Size = new Size(52, 12);
            label2.TabIndex = 1;
            label2.Text = "Value 2";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("STXinwei", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(55, 191);
            label3.Name = "label3";
            label3.Size = new Size(50, 12);
            label3.TabIndex = 2;
            label3.Text = "Output";
            label3.Click += label3_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Control;
            textBox1.Font = new Font("STXinwei", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(143, 53);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 20);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.Control;
            textBox2.Font = new Font("STXinwei", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBox2.Location = new Point(143, 109);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 20);
            textBox2.TabIndex = 4;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.Control;
            textBox3.Font = new Font("STXinwei", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBox3.Location = new Point(143, 185);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(150, 20);
            textBox3.TabIndex = 5;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.CadetBlue;
            button1.Font = new Font("STXinwei", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(39, 249);
            button1.Name = "button1";
            button1.Size = new Size(66, 27);
            button1.TabIndex = 6;
            button1.Text = "+";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.CadetBlue;
            button2.Font = new Font("STXinwei", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(111, 249);
            button2.Name = "button2";
            button2.Size = new Size(66, 27);
            button2.TabIndex = 7;
            button2.Text = "-";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.CadetBlue;
            button3.Font = new Font("STXinwei", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(183, 249);
            button3.Name = "button3";
            button3.Size = new Size(66, 27);
            button3.TabIndex = 8;
            button3.Text = "/";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.CadetBlue;
            button4.Font = new Font("STXinwei", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(255, 249);
            button4.Name = "button4";
            button4.Size = new Size(66, 27);
            button4.TabIndex = 9;
            button4.Text = "x";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OldLace;
            ClientSize = new Size(351, 306);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Calculator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}