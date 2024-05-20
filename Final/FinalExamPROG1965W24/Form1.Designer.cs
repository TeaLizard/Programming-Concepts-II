namespace FinalExamPROG1965W24
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
            buttonPartOne = new Button();
            buttonPartTwo = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // buttonPartOne
            // 
            buttonPartOne.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonPartOne.Location = new Point(79, 111);
            buttonPartOne.Margin = new Padding(4, 4, 4, 4);
            buttonPartOne.Name = "buttonPartOne";
            buttonPartOne.Size = new Size(375, 375);
            buttonPartOne.TabIndex = 0;
            buttonPartOne.Text = "Part One";
            buttonPartOne.UseVisualStyleBackColor = true;
            buttonPartOne.Click += buttonPartOne_Click;
            // 
            // buttonPartTwo
            // 
            buttonPartTwo.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonPartTwo.Location = new Point(535, 111);
            buttonPartTwo.Margin = new Padding(4, 4, 4, 4);
            buttonPartTwo.Name = "buttonPartTwo";
            buttonPartTwo.Size = new Size(375, 375);
            buttonPartTwo.TabIndex = 1;
            buttonPartTwo.Text = "Part Two";
            buttonPartTwo.UseVisualStyleBackColor = true;
            buttonPartTwo.Click += buttonPartTwo_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(225, 47);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(487, 32);
            label1.TabIndex = 2;
            label1.Text = "Final Exam - PROG1965 - W24 - Section 6";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 562);
            Controls.Add(label1);
            Controls.Add(buttonPartTwo);
            Controls.Add(buttonPartOne);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Form1";
            Text = "Owen Williams | 8932017";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonPartOne;
        private Button buttonPartTwo;
        private Label label1;
    }
}
