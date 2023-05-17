namespace Laba6
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
            panel1 = new Panel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Location = new Point(-1, 113);
            panel1.Name = "panel1";
            panel1.Size = new Size(1208, 525);
            panel1.TabIndex = 0;
            panel1.Click += panel1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(102, 38);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Add1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(199, 38);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 2;
            button2.Text = "Add2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(298, 38);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 3;
            button3.Text = "Add3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(417, 38);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 4;
            button4.Text = "pop";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(691, 46);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(504, 23);
            textBox1.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1207, 637);
            Controls.Add(textBox1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private TextBox textBox1;
    }
}