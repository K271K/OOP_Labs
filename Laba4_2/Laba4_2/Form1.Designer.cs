namespace Laba4_2
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
            textBoxA = new TextBox();
            textBoxB = new TextBox();
            textBoxС = new TextBox();
            labelA = new Label();
            labelB = new Label();
            labelC = new Label();
            label_less2 = new Label();
            label_less1 = new Label();
            numericUpDownA = new NumericUpDown();
            numericUpDownB = new NumericUpDown();
            numericUpDownC = new NumericUpDown();
            trackBarA = new TrackBar();
            trackBarB = new TrackBar();
            trackBarC = new TrackBar();
            ((System.ComponentModel.ISupportInitialize)numericUpDownA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownC).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarC).BeginInit();
            SuspendLayout();
            // 
            // textBoxA
            // 
            textBoxA.Location = new Point(119, 258);
            textBoxA.Name = "textBoxA";
            textBoxA.Size = new Size(147, 23);
            textBoxA.TabIndex = 0;
            textBoxA.KeyDown += textBoxes_KeyDown;
            textBoxA.Leave += textBoxes_Leave;
            // 
            // textBoxB
            // 
            textBoxB.Location = new Point(509, 258);
            textBoxB.Name = "textBoxB";
            textBoxB.Size = new Size(147, 23);
            textBoxB.TabIndex = 1;
            textBoxB.KeyDown += textBoxes_KeyDown;
            textBoxB.Leave += textBoxes_Leave;
            // 
            // textBoxС
            // 
            textBoxС.Location = new Point(915, 258);
            textBoxС.Name = "textBoxС";
            textBoxС.Size = new Size(147, 23);
            textBoxС.TabIndex = 2;
            textBoxС.KeyDown += textBoxes_KeyDown;
            textBoxС.Leave += textBoxes_Leave;
            // 
            // labelA
            // 
            labelA.AutoSize = true;
            labelA.Font = new Font("Segoe UI", 64F, FontStyle.Regular, GraphicsUnit.Point);
            labelA.Location = new Point(142, 108);
            labelA.Name = "labelA";
            labelA.Size = new Size(103, 114);
            labelA.TabIndex = 3;
            labelA.Text = "A";
            // 
            // labelB
            // 
            labelB.AutoSize = true;
            labelB.Font = new Font("Segoe UI", 64F, FontStyle.Regular, GraphicsUnit.Point);
            labelB.Location = new Point(531, 108);
            labelB.Name = "labelB";
            labelB.Size = new Size(97, 114);
            labelB.TabIndex = 4;
            labelB.Text = "B";
            // 
            // labelC
            // 
            labelC.AutoSize = true;
            labelC.Font = new Font("Segoe UI", 64F, FontStyle.Regular, GraphicsUnit.Point);
            labelC.Location = new Point(924, 108);
            labelC.Name = "labelC";
            labelC.Size = new Size(101, 114);
            labelC.TabIndex = 4;
            labelC.Text = "C";
            // 
            // label_less2
            // 
            label_less2.AutoSize = true;
            label_less2.Font = new Font("Segoe UI", 64F, FontStyle.Regular, GraphicsUnit.Point);
            label_less2.Location = new Point(700, 108);
            label_less2.Name = "label_less2";
            label_less2.Size = new Size(166, 114);
            label_less2.TabIndex = 4;
            label_less2.Text = "<=";
            // 
            // label_less1
            // 
            label_less1.AutoSize = true;
            label_less1.Font = new Font("Segoe UI", 64F, FontStyle.Regular, GraphicsUnit.Point);
            label_less1.Location = new Point(290, 108);
            label_less1.Name = "label_less1";
            label_less1.Size = new Size(166, 114);
            label_less1.TabIndex = 4;
            label_less1.Text = "<=";
            // 
            // numericUpDownA
            // 
            numericUpDownA.Location = new Point(119, 338);
            numericUpDownA.Name = "numericUpDownA";
            numericUpDownA.Size = new Size(147, 23);
            numericUpDownA.TabIndex = 5;
            numericUpDownA.ValueChanged += NumericUpDowns_ValueChanged;
            // 
            // numericUpDownB
            // 
            numericUpDownB.Location = new Point(509, 338);
            numericUpDownB.Name = "numericUpDownB";
            numericUpDownB.Size = new Size(147, 23);
            numericUpDownB.TabIndex = 5;
            numericUpDownB.ValueChanged += NumericUpDowns_ValueChanged;
            // 
            // numericUpDownC
            // 
            numericUpDownC.Location = new Point(915, 338);
            numericUpDownC.Name = "numericUpDownC";
            numericUpDownC.Size = new Size(147, 23);
            numericUpDownC.TabIndex = 5;
            numericUpDownC.ValueChanged += NumericUpDowns_ValueChanged;
            // 
            // trackBarA
            // 
            trackBarA.Location = new Point(119, 413);
            trackBarA.Maximum = 100;
            trackBarA.Name = "trackBarA";
            trackBarA.Size = new Size(147, 45);
            trackBarA.TabIndex = 6;
            trackBarA.Scroll += trackBars_Scroll;
            // 
            // trackBarB
            // 
            trackBarB.Location = new Point(509, 413);
            trackBarB.Maximum = 100;
            trackBarB.Name = "trackBarB";
            trackBarB.Size = new Size(147, 45);
            trackBarB.TabIndex = 6;
            trackBarB.Scroll += trackBars_Scroll;
            // 
            // trackBarC
            // 
            trackBarC.Location = new Point(915, 413);
            trackBarC.Maximum = 100;
            trackBarC.Name = "trackBarC";
            trackBarC.Size = new Size(147, 45);
            trackBarC.TabIndex = 6;
            trackBarC.Scroll += trackBars_Scroll;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1159, 637);
            Controls.Add(trackBarC);
            Controls.Add(trackBarB);
            Controls.Add(trackBarA);
            Controls.Add(numericUpDownC);
            Controls.Add(numericUpDownB);
            Controls.Add(numericUpDownA);
            Controls.Add(label_less1);
            Controls.Add(label_less2);
            Controls.Add(labelC);
            Controls.Add(labelB);
            Controls.Add(labelA);
            Controls.Add(textBoxС);
            Controls.Add(textBoxB);
            Controls.Add(textBoxA);
            Name = "Form1";
            Text = "Form1";
            FormClosed += Form1_FormClosed;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownA).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownB).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownC).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarA).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarB).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarC).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void TextBoxA_Leave(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private TextBox textBoxA;
        private TextBox textBoxB;
        private TextBox textBoxС;
        private Label labelA;
        private Label labelB;
        private Label labelC;
        private Label label_less2;
        private Label label_less1;
        private NumericUpDown numericUpDownA;
        private NumericUpDown numericUpDownB;
        private NumericUpDown numericUpDownC;
        private TrackBar trackBarA;
        private TrackBar trackBarB;
        private TrackBar trackBarC;
    }
}