namespace InClass_Asst5_PROG1965_W24
{
    partial class FormTest
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
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(554, 108);
            button1.Name = "button1";
            button1.Size = new Size(94, 77);
            button1.TabIndex = 0;
            button1.Text = "Part One";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(554, 280);
            button2.Name = "button2";
            button2.Size = new Size(94, 79);
            button2.TabIndex = 1;
            button2.Text = "Part Two";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // FormTest
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 524);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "FormTest";
            Text = "In-class Assignment 5";
            Load += FormTest_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
    }
}
