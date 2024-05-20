namespace InClass_Asst5_PROG1965_W24
{
    public partial class FormTest : Form
    {
        public FormTest()
        {
            InitializeComponent();
        }

        private void FormTest_Load(object sender, EventArgs e)
        {
            int buttonSize = 50;
            int size = 10;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    int ind = (size * i + j);
                    Button button = new Button();
                    button.Location = new Point(10 + i * buttonSize, 10 + j * buttonSize);
                    button.Name = "buttonQuestion" + (ind + 1).ToString();
                    button.Size = new Size(buttonSize, buttonSize);
                    button.TabIndex = i * 10 + j;
                    button.Text = (ind + 1).ToString();
                    button.UseVisualStyleBackColor = true;
                    button.Visible = true;
                    button.BringToFront();
                    this.Controls.Add(button);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormPartOne formPartOne = new FormPartOne();
            formPartOne.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormPartTwo formPartTwo = new FormPartTwo();
            formPartTwo.ShowDialog();
        }
    }
}
