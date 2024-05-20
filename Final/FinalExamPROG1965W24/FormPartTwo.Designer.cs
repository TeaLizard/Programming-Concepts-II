namespace FinalExamPROG1965W24
{
    partial class FormPartTwo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBox1 = new ListBox();
            button1 = new Button();
            richTextBox1 = new RichTextBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            label2 = new Label();
            label3 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" });
            listBox1.Location = new Point(102, 36);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(42, 124);
            listBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(48, 204);
            button1.Name = "button1";
            button1.Size = new Size(157, 63);
            button1.TabIndex = 1;
            button1.Text = "Submit Answer";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(279, 12);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(612, 465);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 163);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.GradientInactiveCaption;
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(listBox1);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(14, 152);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(247, 325);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Choose an answer";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.GradientInactiveCaption;
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(12, 13);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(249, 36);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Click a question number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 279);
            label2.Name = "label2";
            label2.Size = new Size(229, 20);
            label2.TabIndex = 4;
            label2.Text = "Number of questions answered";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(104, 300);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 5;
            // 
            // FormPartTwo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(903, 491);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(richTextBox1);
            Name = "FormPartTwo";
            Text = "FormPartTwo";
            Load += FormPartTwo_Load_1;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private Button button1;
        private RichTextBox richTextBox1;
        private Label label1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label3;
        private Label label2;
    }
}