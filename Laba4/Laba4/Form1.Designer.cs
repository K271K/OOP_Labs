using Microsoft.VisualBasic.Logging;
using System.Collections.Specialized;

namespace Laba4
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
            testContainer = new ListBox();
            InterSection = new CheckBox();
            label1 = new Label();
            ctrlSwtich = new CheckBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(0, 44);
            panel1.Name = "panel1";
            panel1.Size = new Size(1299, 586);
            panel1.TabIndex = 0;
            panel1.MouseClick += panel1_MouseClick;
            // 
            // testContainer
            // 
            testContainer.FormattingEnabled = true;
            testContainer.ItemHeight = 15;
            testContainer.Location = new Point(1319, 44);
            testContainer.Name = "testContainer";
            testContainer.Size = new Size(180, 124);
            testContainer.TabIndex = 1;
            // 
            // InterSection
            // 
            InterSection.AutoSize = true;
            InterSection.Location = new Point(155, 16);
            InterSection.Name = "InterSection";
            InterSection.Size = new Size(89, 19);
            InterSection.TabIndex = 2;
            InterSection.Text = "InterSection";
            InterSection.UseVisualStyleBackColor = true;
            InterSection.CheckedChanged += InterSection_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1319, 191);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 3;
            label1.Text = "label1";
            // 
            // ctrlSwtich
            // 
            ctrlSwtich.AutoSize = true;
            ctrlSwtich.Location = new Point(30, 16);
            ctrlSwtich.Name = "ctrlSwtich";
            ctrlSwtich.Size = new Size(82, 19);
            ctrlSwtich.TabIndex = 4;
            ctrlSwtich.Text = "CTRL work";
            ctrlSwtich.UseVisualStyleBackColor = true;
            ctrlSwtich.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1320, 216);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 5;
            label2.Text = "label2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1523, 630);
            Controls.Add(label2);
            Controls.Add(ctrlSwtich);
            Controls.Add(label1);
            Controls.Add(InterSection);
            Controls.Add(testContainer);
            Controls.Add(panel1);
            KeyPreview = true;
            Name = "Form1";
            Text = "Form1";
            KeyDown += Form1_KeyDown;
            KeyUp += Form1_KeyUp;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private ListBox testContainer;
        private CheckBox InterSection;
        private Label label1;
        private CheckBox ctrlSwtich;
        private Label label2;
    }


}