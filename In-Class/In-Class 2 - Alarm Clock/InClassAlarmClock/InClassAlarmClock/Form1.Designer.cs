namespace InClassAlarmClock
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            TimeBox = new Label();
            Timer = new System.Windows.Forms.Timer(components);
            DateTimePicker = new DateTimePicker();
            CheckBox = new CheckBox();
            SnoozeButton = new Button();
            OffButton = new Button();
            SetAlarmButton = new Button();
            ResetButton = new Button();
            label1 = new Label();
            CurrentDayLabel = new Label();
            SetTimeLabel = new Label();
            SuspendLayout();
            // 
            // TimeBox
            // 
            TimeBox.AutoSize = true;
            TimeBox.Location = new Point(330, 56);
            TimeBox.Name = "TimeBox";
            TimeBox.Size = new Size(79, 25);
            TimeBox.TabIndex = 0;
            TimeBox.Text = "TimeBox";
            // 
            // Timer
            // 
            Timer.Enabled = true;
            Timer.Interval = 1000;
            Timer.Tick += Timer_Tick;
            // 
            // DateTimePicker
            // 
            DateTimePicker.Format = DateTimePickerFormat.Time;
            DateTimePicker.Location = new Point(227, 126);
            DateTimePicker.Name = "DateTimePicker";
            DateTimePicker.ShowUpDown = true;
            DateTimePicker.Size = new Size(300, 31);
            DateTimePicker.TabIndex = 1;
            DateTimePicker.Value = new DateTime(2024, 1, 30, 13, 48, 55, 0);
            // 
            // CheckBox
            // 
            CheckBox.AutoSize = true;
            CheckBox.Location = new Point(564, 135);
            CheckBox.Name = "CheckBox";
            CheckBox.Size = new Size(112, 29);
            CheckBox.TabIndex = 2;
            CheckBox.Text = "Activated";
            CheckBox.UseVisualStyleBackColor = true;
            // 
            // SnoozeButton
            // 
            SnoozeButton.Image = (Image)resources.GetObject("SnoozeButton.Image");
            SnoozeButton.Location = new Point(203, 296);
            SnoozeButton.Name = "SnoozeButton";
            SnoozeButton.Size = new Size(100, 100);
            SnoozeButton.TabIndex = 3;
            SnoozeButton.UseVisualStyleBackColor = true;
            SnoozeButton.Click += ButtonClick;
            // 
            // OffButton
            // 
            OffButton.Image = (Image)resources.GetObject("OffButton.Image");
            OffButton.Location = new Point(415, 296);
            OffButton.Name = "OffButton";
            OffButton.Size = new Size(100, 100);
            OffButton.TabIndex = 4;
            OffButton.UseVisualStyleBackColor = true;
            OffButton.Click += ButtonClick;
            // 
            // SetAlarmButton
            // 
            SetAlarmButton.Location = new Point(309, 296);
            SetAlarmButton.Name = "SetAlarmButton";
            SetAlarmButton.Size = new Size(100, 60);
            SetAlarmButton.TabIndex = 5;
            SetAlarmButton.Text = "Set Alarm";
            SetAlarmButton.UseVisualStyleBackColor = true;
            SetAlarmButton.Click += ButtonClick;
            // 
            // ResetButton
            // 
            ResetButton.Location = new Point(309, 361);
            ResetButton.Name = "ResetButton";
            ResetButton.Size = new Size(100, 35);
            ResetButton.TabIndex = 6;
            ResetButton.Text = "Reset";
            ResetButton.UseVisualStyleBackColor = true;
            ResetButton.Click += ButtonClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(132, 126);
            label1.Name = "label1";
            label1.Size = new Size(89, 25);
            label1.TabIndex = 7;
            label1.Text = "Set Alarm";
            // 
            // CurrentDayLabel
            // 
            CurrentDayLabel.AutoSize = true;
            CurrentDayLabel.Location = new Point(596, 90);
            CurrentDayLabel.Name = "CurrentDayLabel";
            CurrentDayLabel.Size = new Size(106, 25);
            CurrentDayLabel.TabIndex = 8;
            CurrentDayLabel.Text = "Current Day";
            // 
            // SetTimeLabel
            // 
            SetTimeLabel.AutoSize = true;
            SetTimeLabel.Location = new Point(203, 268);
            SetTimeLabel.Name = "SetTimeLabel";
            SetTimeLabel.Size = new Size(0, 25);
            SetTimeLabel.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SetTimeLabel);
            Controls.Add(CurrentDayLabel);
            Controls.Add(label1);
            Controls.Add(ResetButton);
            Controls.Add(SetAlarmButton);
            Controls.Add(OffButton);
            Controls.Add(SnoozeButton);
            Controls.Add(CheckBox);
            Controls.Add(DateTimePicker);
            Controls.Add(TimeBox);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TimeBox;
        private System.Windows.Forms.Timer Timer;
        private DateTimePicker DateTimePicker;
        private CheckBox CheckBox;
        private Button SnoozeButton;
        private Button OffButton;
        private Button SetAlarmButton;
        private Button ResetButton;
        private Label label1;
        private Label CurrentDayLabel;
        private Label SetTimeLabel;
    }
}