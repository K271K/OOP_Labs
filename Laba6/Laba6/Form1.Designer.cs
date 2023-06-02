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
            figureGroupBox = new GroupBox();
            buttonTriangle = new Button();
            buttonSquare = new Button();
            buttonCircle = new Button();
            colorDialog1 = new ColorDialog();
            buttonRed = new Button();
            colorGroupBox = new GroupBox();
            AnyColorButton = new Button();
            buttonBlue = new Button();
            buttonYellow = new Button();
            buttonGreen = new Button();
            pictureBox1 = new Panel();
            buttonClear = new Button();
            SaveLoadGroupBox = new GroupBox();
            buttonLoad = new Button();
            buttonSave = new Button();
            saveFileDialog1 = new SaveFileDialog();
            openFileDialog1 = new OpenFileDialog();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            figureGroupBox.SuspendLayout();
            colorGroupBox.SuspendLayout();
            SaveLoadGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // figureGroupBox
            // 
            figureGroupBox.BackColor = Color.NavajoWhite;
            figureGroupBox.Controls.Add(buttonTriangle);
            figureGroupBox.Controls.Add(buttonSquare);
            figureGroupBox.Controls.Add(buttonCircle);
            figureGroupBox.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            figureGroupBox.ForeColor = SystemColors.ControlDarkDark;
            figureGroupBox.Location = new Point(943, 12);
            figureGroupBox.Name = "figureGroupBox";
            figureGroupBox.Size = new Size(252, 67);
            figureGroupBox.TabIndex = 1;
            figureGroupBox.TabStop = false;
            figureGroupBox.Text = "Figures";
            // 
            // buttonTriangle
            // 
            buttonTriangle.BackColor = SystemColors.ControlDarkDark;
            buttonTriangle.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            buttonTriangle.ForeColor = Color.NavajoWhite;
            buttonTriangle.Location = new Point(87, 22);
            buttonTriangle.Name = "buttonTriangle";
            buttonTriangle.Size = new Size(75, 39);
            buttonTriangle.TabIndex = 2;
            buttonTriangle.Text = "Triangle";
            buttonTriangle.UseVisualStyleBackColor = false;
            buttonTriangle.Click += buttonFigure_Click;
            // 
            // buttonSquare
            // 
            buttonSquare.BackColor = SystemColors.ControlDarkDark;
            buttonSquare.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSquare.ForeColor = Color.NavajoWhite;
            buttonSquare.Location = new Point(168, 22);
            buttonSquare.Name = "buttonSquare";
            buttonSquare.Size = new Size(75, 39);
            buttonSquare.TabIndex = 1;
            buttonSquare.Text = "Square";
            buttonSquare.UseVisualStyleBackColor = false;
            buttonSquare.Click += buttonFigure_Click;
            // 
            // buttonCircle
            // 
            buttonCircle.BackColor = SystemColors.ControlDarkDark;
            buttonCircle.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCircle.ForeColor = Color.NavajoWhite;
            buttonCircle.Location = new Point(6, 22);
            buttonCircle.Name = "buttonCircle";
            buttonCircle.Size = new Size(75, 39);
            buttonCircle.TabIndex = 0;
            buttonCircle.Text = "Circle";
            buttonCircle.UseVisualStyleBackColor = false;
            buttonCircle.Click += buttonFigure_Click;
            // 
            // buttonRed
            // 
            buttonRed.BackColor = Color.Red;
            buttonRed.Location = new Point(11, 21);
            buttonRed.Name = "buttonRed";
            buttonRed.Size = new Size(30, 30);
            buttonRed.TabIndex = 2;
            buttonRed.UseVisualStyleBackColor = false;
            buttonRed.Click += ColorButton_Click;
            // 
            // colorGroupBox
            // 
            colorGroupBox.BackColor = Color.NavajoWhite;
            colorGroupBox.Controls.Add(AnyColorButton);
            colorGroupBox.Controls.Add(buttonBlue);
            colorGroupBox.Controls.Add(buttonYellow);
            colorGroupBox.Controls.Add(buttonGreen);
            colorGroupBox.Controls.Add(buttonRed);
            colorGroupBox.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            colorGroupBox.ForeColor = SystemColors.ControlDarkDark;
            colorGroupBox.Location = new Point(943, 98);
            colorGroupBox.Name = "colorGroupBox";
            colorGroupBox.Size = new Size(252, 76);
            colorGroupBox.TabIndex = 3;
            colorGroupBox.TabStop = false;
            colorGroupBox.Text = "Color";
            // 
            // AnyColorButton
            // 
            AnyColorButton.BackColor = SystemColors.ActiveBorder;
            AnyColorButton.Location = new Point(155, 22);
            AnyColorButton.Name = "AnyColorButton";
            AnyColorButton.Size = new Size(30, 30);
            AnyColorButton.TabIndex = 2;
            AnyColorButton.UseVisualStyleBackColor = false;
            AnyColorButton.Click += AnyColorButton_Click;
            // 
            // buttonBlue
            // 
            buttonBlue.BackColor = Color.Blue;
            buttonBlue.Location = new Point(119, 22);
            buttonBlue.Name = "buttonBlue";
            buttonBlue.Size = new Size(30, 30);
            buttonBlue.TabIndex = 2;
            buttonBlue.UseVisualStyleBackColor = false;
            buttonBlue.Click += ColorButton_Click;
            // 
            // buttonYellow
            // 
            buttonYellow.BackColor = Color.Yellow;
            buttonYellow.Location = new Point(83, 22);
            buttonYellow.Name = "buttonYellow";
            buttonYellow.Size = new Size(30, 30);
            buttonYellow.TabIndex = 2;
            buttonYellow.UseVisualStyleBackColor = false;
            buttonYellow.Click += ColorButton_Click;
            // 
            // buttonGreen
            // 
            buttonGreen.BackColor = Color.Green;
            buttonGreen.Location = new Point(47, 21);
            buttonGreen.Name = "buttonGreen";
            buttonGreen.Size = new Size(30, 30);
            buttonGreen.TabIndex = 2;
            buttonGreen.UseVisualStyleBackColor = false;
            buttonGreen.Click += ColorButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ControlLightLight;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(901, 556);
            pictureBox1.TabIndex = 0;
            pictureBox1.Paint += pictureBox1_Paint;
            pictureBox1.MouseDown += pictureBox1_MouseDown;
            // 
            // buttonClear
            // 
            buttonClear.BackColor = Color.NavajoWhite;
            buttonClear.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonClear.ForeColor = SystemColors.ControlDarkDark;
            buttonClear.Location = new Point(943, 193);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(113, 37);
            buttonClear.TabIndex = 4;
            buttonClear.Text = "Clear All";
            buttonClear.UseVisualStyleBackColor = false;
            buttonClear.Click += clearBTN_Click;
            // 
            // SaveLoadGroupBox
            // 
            SaveLoadGroupBox.BackColor = Color.NavajoWhite;
            SaveLoadGroupBox.Controls.Add(buttonLoad);
            SaveLoadGroupBox.Controls.Add(buttonSave);
            SaveLoadGroupBox.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            SaveLoadGroupBox.ForeColor = SystemColors.ControlDarkDark;
            SaveLoadGroupBox.Location = new Point(943, 246);
            SaveLoadGroupBox.Name = "SaveLoadGroupBox";
            SaveLoadGroupBox.Size = new Size(252, 80);
            SaveLoadGroupBox.TabIndex = 5;
            SaveLoadGroupBox.TabStop = false;
            SaveLoadGroupBox.Text = "File";
            // 
            // buttonLoad
            // 
            buttonLoad.BackColor = SystemColors.ControlDarkDark;
            buttonLoad.ForeColor = Color.NavajoWhite;
            buttonLoad.Location = new Point(139, 22);
            buttonLoad.Name = "buttonLoad";
            buttonLoad.Size = new Size(93, 33);
            buttonLoad.TabIndex = 0;
            buttonLoad.Text = "Load";
            buttonLoad.UseVisualStyleBackColor = false;
            buttonLoad.Click += buttonLoad_Click;
            // 
            // buttonSave
            // 
            buttonSave.BackColor = SystemColors.ControlDarkDark;
            buttonSave.ForeColor = Color.NavajoWhite;
            buttonSave.Location = new Point(22, 22);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(91, 33);
            buttonSave.TabIndex = 0;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.Filter = "TXT files|*.txt";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Filter = "TXT files|*.txt";
            // 
            // label1
            // 
            label1.BackColor = Color.NavajoWhite;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(943, 346);
            label1.Name = "label1";
            label1.Padding = new Padding(3);
            label1.Size = new Size(252, 82);
            label1.TabIndex = 6;
            label1.Text = "Shift - сгруппировать объекты. Z - разгруппировать.\r\n";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(949, 456);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 7;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(949, 493);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 7;
            label3.Text = "label2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1207, 637);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(SaveLoadGroupBox);
            Controls.Add(buttonClear);
            Controls.Add(pictureBox1);
            Controls.Add(colorGroupBox);
            Controls.Add(figureGroupBox);
            KeyPreview = true;
            Name = "Form1";
            Text = "MyPaint";
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            KeyUp += Form1_KeyUp;
            figureGroupBox.ResumeLayout(false);
            colorGroupBox.ResumeLayout(false);
            SaveLoadGroupBox.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox figureGroupBox;
        private Button buttonTriangle;
        private Button buttonSquare;
        private Button buttonCircle;
        private ColorDialog colorDialog1;
        private Button buttonRed;
        private GroupBox colorGroupBox;
        private Button AnyColorButton;
        private Button buttonBlue;
        private Button buttonYellow;
        private Button buttonGreen;
        private Panel pictureBox1;
        private Button buttonClear;
        private GroupBox SaveLoadGroupBox;
        private Button buttonLoad;
        private Button buttonSave;
        private SaveFileDialog saveFileDialog1;
        private OpenFileDialog openFileDialog1;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}