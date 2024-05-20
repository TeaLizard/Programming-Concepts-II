namespace InClass_Asst5_PROG1965_W24
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
            richTextBoxQuestion = new RichTextBox();
            listBoxAnswer = new ListBox();
            label1 = new Label();
            buttonSubmitAnswer = new Button();
            SubmitPanel = new Panel();
            button2 = new Button();
            button1 = new Button();
            SubmitLabel = new Label();
            SubmitPanel.SuspendLayout();
            SuspendLayout();
            // 
            // richTextBoxQuestion
            // 
            richTextBoxQuestion.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            richTextBoxQuestion.Location = new Point(584, 32);
            richTextBoxQuestion.Margin = new Padding(4);
            richTextBoxQuestion.Name = "richTextBoxQuestion";
            richTextBoxQuestion.Size = new Size(666, 775);
            richTextBoxQuestion.TabIndex = 0;
            richTextBoxQuestion.Text = "";
            // 
            // listBoxAnswer
            // 
            listBoxAnswer.FormattingEnabled = true;
            listBoxAnswer.ItemHeight = 25;
            listBoxAnswer.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" });
            listBoxAnswer.Location = new Point(434, 32);
            listBoxAnswer.Margin = new Padding(4);
            listBoxAnswer.Name = "listBoxAnswer";
            listBoxAnswer.Size = new Size(39, 229);
            listBoxAnswer.Sorted = true;
            listBoxAnswer.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(376, 298);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(168, 25);
            label1.TabIndex = 2;
            label1.Text = "Choose an Answer";
            // 
            // buttonSubmitAnswer
            // 
            buttonSubmitAnswer.Font = new Font("PMingLiU-ExtB", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSubmitAnswer.Location = new Point(85, 519);
            buttonSubmitAnswer.Margin = new Padding(4);
            buttonSubmitAnswer.Name = "buttonSubmitAnswer";
            buttonSubmitAnswer.Size = new Size(185, 192);
            buttonSubmitAnswer.TabIndex = 3;
            buttonSubmitAnswer.Text = "Submit Answer";
            buttonSubmitAnswer.UseVisualStyleBackColor = true;
            buttonSubmitAnswer.Click += SubmitAnswer;
            // 
            // SubmitPanel
            // 
            SubmitPanel.Controls.Add(button2);
            SubmitPanel.Controls.Add(button1);
            SubmitPanel.Controls.Add(SubmitLabel);
            SubmitPanel.Location = new Point(277, 268);
            SubmitPanel.Name = "SubmitPanel";
            SubmitPanel.Size = new Size(735, 306);
            SubmitPanel.TabIndex = 4;
            SubmitPanel.Visible = false;
            // 
            // button2
            // 
            button2.Location = new Point(46, 217);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 2;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            button2.Click += SubmitMessageBoxClick;
            // 
            // button1
            // 
            button1.Location = new Point(46, 177);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 1;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += SubmitMessageBoxClick;
            // 
            // SubmitLabel
            // 
            SubmitLabel.AutoSize = true;
            SubmitLabel.Location = new Point(27, 23);
            SubmitLabel.Name = "SubmitLabel";
            SubmitLabel.Size = new Size(59, 25);
            SubmitLabel.TabIndex = 0;
            SubmitLabel.Text = "label2";
            // 
            // FormPartTwo
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1276, 834);
            Controls.Add(SubmitPanel);
            Controls.Add(buttonSubmitAnswer);
            Controls.Add(label1);
            Controls.Add(listBoxAnswer);
            Controls.Add(richTextBoxQuestion);
            Margin = new Padding(4);
            Name = "FormPartTwo";
            Text = "FormPartTwo";
            Load += FormPartTwo_Load;
            SubmitPanel.ResumeLayout(false);
            SubmitPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBoxQuestion;
        private ListBox listBoxAnswer;
        private Label label1;
        private Button buttonSubmitAnswer;
        private Panel SubmitPanel;
        private Button button2;
        private Button button1;
        private Label SubmitLabel;
    }
}