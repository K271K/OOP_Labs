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
            this.panel1 = new System.Windows.Forms.Panel();
            this.testContainer = new System.Windows.Forms.ListBox();
            this.InterSection = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ctrlSwtich = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(0, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1299, 586);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            // 
            // testContainer
            // 
            this.testContainer.FormattingEnabled = true;
            this.testContainer.ItemHeight = 15;
            this.testContainer.Location = new System.Drawing.Point(1305, 44);
            this.testContainer.Name = "testContainer";
            this.testContainer.Size = new System.Drawing.Size(213, 124);
            this.testContainer.TabIndex = 1;
            // 
            // InterSection
            // 
            this.InterSection.AutoSize = true;
            this.InterSection.Location = new System.Drawing.Point(155, 16);
            this.InterSection.Name = "InterSection";
            this.InterSection.Size = new System.Drawing.Size(89, 19);
            this.InterSection.TabIndex = 2;
            this.InterSection.Text = "InterSection";
            this.InterSection.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1319, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // ctrlSwtich
            // 
            this.ctrlSwtich.AutoSize = true;
            this.ctrlSwtich.Location = new System.Drawing.Point(30, 16);
            this.ctrlSwtich.Name = "ctrlSwtich";
            this.ctrlSwtich.Size = new System.Drawing.Size(82, 19);
            this.ctrlSwtich.TabIndex = 4;
            this.ctrlSwtich.Text = "CTRL work";
            this.ctrlSwtich.UseVisualStyleBackColor = true;
            this.ctrlSwtich.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1320, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1523, 630);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ctrlSwtich);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InterSection);
            this.Controls.Add(this.testContainer);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

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