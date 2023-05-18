﻿namespace Laba6
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
            pictureBox1 = new PictureBox();
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            figureGroupBox.SuspendLayout();
            colorGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ControlLightLight;
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(916, 637);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Paint += pictureBox1_Paint;
            pictureBox1.MouseDown += pictureBox1_MouseDown;
            // 
            // figureGroupBox
            // 
            figureGroupBox.Controls.Add(buttonTriangle);
            figureGroupBox.Controls.Add(buttonSquare);
            figureGroupBox.Controls.Add(buttonCircle);
            figureGroupBox.Location = new Point(943, 12);
            figureGroupBox.Name = "figureGroupBox";
            figureGroupBox.Size = new Size(252, 100);
            figureGroupBox.TabIndex = 1;
            figureGroupBox.TabStop = false;
            figureGroupBox.Text = "Figures";
            // 
            // buttonTriangle
            // 
            buttonTriangle.Location = new Point(87, 22);
            buttonTriangle.Name = "buttonTriangle";
            buttonTriangle.Size = new Size(75, 23);
            buttonTriangle.TabIndex = 2;
            buttonTriangle.Text = "Triangle";
            buttonTriangle.UseVisualStyleBackColor = true;
            buttonTriangle.Click += buttonFigure_Click;
            // 
            // buttonSquare
            // 
            buttonSquare.Location = new Point(168, 22);
            buttonSquare.Name = "buttonSquare";
            buttonSquare.Size = new Size(75, 23);
            buttonSquare.TabIndex = 1;
            buttonSquare.Text = "Square";
            buttonSquare.UseVisualStyleBackColor = true;
            buttonSquare.Click += buttonFigure_Click;
            // 
            // buttonCircle
            // 
            buttonCircle.Location = new Point(6, 22);
            buttonCircle.Name = "buttonCircle";
            buttonCircle.Size = new Size(75, 23);
            buttonCircle.TabIndex = 0;
            buttonCircle.Text = "Circle";
            buttonCircle.UseVisualStyleBackColor = true;
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
            colorGroupBox.Controls.Add(AnyColorButton);
            colorGroupBox.Controls.Add(buttonBlue);
            colorGroupBox.Controls.Add(buttonYellow);
            colorGroupBox.Controls.Add(buttonGreen);
            colorGroupBox.Controls.Add(buttonRed);
            colorGroupBox.Location = new Point(943, 144);
            colorGroupBox.Name = "colorGroupBox";
            colorGroupBox.Size = new Size(252, 100);
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1207, 637);
            Controls.Add(colorGroupBox);
            Controls.Add(figureGroupBox);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            figureGroupBox.ResumeLayout(false);
            colorGroupBox.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
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
    }
}