using System.IO;
using System.Numerics;

namespace InClassAlarmClock
{
    public partial class Form1 : Form
    {
        private static string? AlarmSetTimeSecond, AlarmSetTimeMinute, AlarmSetTimeHour;
        private static System.Media.SoundPlayer? Player;
        private static string AlarmSound = @"C:\Users\Owen\source\repos\InClassAlarmClock\InClassAlarmClock\sounds\alarm.wav";
        private static string ClockSound = @"C:\Users\Owen\source\repos\InClassAlarmClock\InClassAlarmClock\sounds\clock.wav";
        private static bool AlarmIsPlaying = false;
        private static DateTime AlarmSetTime;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TimeBox.Text = DateTime.Now.ToString("hh:mm:ss tt");
            CurrentDayLabel.Text = DateTime.Now.DayOfWeek.ToString();
            Player = new System.Media.SoundPlayer(ClockSound);
            Player.PlayLooping();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            TimeBox.Text = DateTime.Now.ToString("hh:mm:ss tt");

            if (CheckBox.Checked && AlarmSetTimeHour == DateTime.Now.Hour.ToString() && AlarmSetTimeMinute == DateTime.Now.Minute.ToString() && AlarmSetTimeSecond == DateTime.Now.Second.ToString())
            { // Set alarm off
                Player = new System.Media.SoundPlayer(AlarmSound);
                Player.PlayLooping();
                AlarmIsPlaying = true;
            }
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            Button buttonInput = (Button)sender;

            switch (buttonInput.TabIndex)
            {
                case 3: // Snooze
                    Player = new System.Media.SoundPlayer(ClockSound);
                    Player.PlayLooping();
                    AlarmIsPlaying = false;
                    AlarmSetTimeSecond = DateTime.Now.AddSeconds(30).Second.ToString();
                    AlarmSetTimeMinute = DateTime.Now.AddSeconds(30).Minute.ToString();
                    AlarmSetTimeHour = DateTime.Now.AddSeconds(30).Hour.ToString();
                    SetTimeLabel.Text = $"Time set to {AlarmSetTimeHour} : {AlarmSetTimeMinute} : {AlarmSetTimeSecond} Activated";
                    return;

                case 5: // Set Alarm
                    AlarmSetTimeSecond = DateTimePicker.Value.Second.ToString();
                    AlarmSetTimeMinute = DateTimePicker.Value.Minute.ToString();
                    AlarmSetTimeHour = DateTimePicker.Value.Hour.ToString();
                    SetTimeLabel.Text = $"Time set to {AlarmSetTimeHour} : {AlarmSetTimeMinute} : {AlarmSetTimeSecond} Activated";
                    return;

                case 6: // Reset
                    Player = new System.Media.SoundPlayer(ClockSound);
                    Player.PlayLooping();
                    AlarmIsPlaying = false;
                    SetTimeLabel.Text = "Alarm Reset";
                    AlarmSetTimeSecond = "";
                    AlarmSetTimeMinute = "";
                    AlarmSetTimeHour = "";
                    return;

                case 4: // Alarm Off
                    Player = new System.Media.SoundPlayer(ClockSound);
                    Player.PlayLooping();
                    AlarmIsPlaying = false;
                    return;
            }
        }
    }
}