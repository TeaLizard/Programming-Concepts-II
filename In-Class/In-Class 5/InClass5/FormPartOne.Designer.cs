namespace InClass_Asst5_PROG1965_W24
{
    partial class FormPartOne
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
            NameBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            PasswordBox = new TextBox();
            label3 = new Label();
            DateTimePicker = new DateTimePicker();
            button1 = new Button();
            SuspendLayout();
            // 
            // NameBox
            // 
            NameBox.Location = new Point(209, 66);
            NameBox.Name = "NameBox";
            NameBox.Size = new Size(150, 31);
            NameBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(83, 72);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 1;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(83, 109);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // PasswordBox
            // 
            PasswordBox.Location = new Point(209, 103);
            PasswordBox.Name = "PasswordBox";
            PasswordBox.Size = new Size(150, 31);
            PasswordBox.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(83, 146);
            label3.Name = "label3";
            label3.Size = new Size(115, 25);
            label3.TabIndex = 5;
            label3.Text = "Date Created";
            // 
            // DateTimePicker
            // 
            DateTimePicker.Location = new Point(209, 146);
            DateTimePicker.Name = "DateTimePicker";
            DateTimePicker.Size = new Size(300, 31);
            DateTimePicker.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(209, 212);
            button1.Name = "button1";
            button1.Size = new Size(157, 34);
            button1.TabIndex = 7;
            button1.Text = "Create New User";
            button1.UseVisualStyleBackColor = true;
            button1.Click += CreateUser;
            // 
            // FormPartOne
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 562);
            Controls.Add(button1);
            Controls.Add(DateTimePicker);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(PasswordBox);
            Controls.Add(label1);
            Controls.Add(NameBox);
            Margin = new Padding(4);
            Name = "FormPartOne";
            Text = "FormPartOne";
            Load += FormPartOne_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox NameBox;
        private Label label1;
        private Label label2;
        private TextBox PasswordBox;
        private Label label3;
        private DateTimePicker DateTimePicker;
        private Button button1;
    }
}