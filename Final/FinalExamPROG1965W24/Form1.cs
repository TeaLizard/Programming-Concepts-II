using System.IO;

namespace FinalExamPROG1965W24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonPartOne_Click(object sender, EventArgs e)
        {
            FormPartOne formPartOne = new FormPartOne();
            formPartOne.ShowDialog();
        }

        private void buttonPartTwo_Click(object sender, EventArgs e)
        {
            FormPartTwo formPartTwo = new FormPartTwo();
            formPartTwo.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
