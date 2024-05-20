namespace InClass1
{
    public partial class Form1 : Form
    {
        private double val_1, val_2, result = 0;
        private string peration = ""; 
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void DigitClick(object sender, EventArgs e)
        {
            Button buttonInput = (Button)sender;
            if (TextBox.Text == "0")
            {
                TextBox.Text = buttonInput.Text;
            }
            else if (TextBox.Text.Contains(".") && buttonInput.Text == ".")
            {
                // Nothing
            }
            else
            {
                TextBox.Text += buttonInput.Text;

            }
        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void OperationClick(object sender, EventArgs e)
        {
            Button buttonInput = (Button)sender;
            if (buttonInput.Text == "+" || buttonInput.Text == "-" || buttonInput.Text == "x" || buttonInput.Text == "/")
            {
                peration = buttonInput.Text;
                val_1 = double.Parse(TextBox.Text);
                TextBox.Clear();
            }
            
            switch (buttonInput.Text)
            {
                

                case "=":
                    val_2 = double.Parse(TextBox.Text);
                    TextBox.Clear();
                    if (peration == "+")
                    {
                        result = val_1 + val_2;
                        TextBox.Text = result.ToString();
                    }
                    else if (peration == "-")
                    {
                        result = val_1 - val_2;
                        TextBox.Text = result.ToString();
                    }
                    else if (peration == "x")
                    {
                        result = val_1 * val_2;
                        TextBox.Text = result.ToString();
                    }
                    else if (peration == "/" && val_2 == 0)
                    {
                        TextBox.Text = "Error divide by zero";
                    }
                    else if (peration == "/")
                    {
                        result = val_1 / val_2;
                        TextBox.Text = result.ToString();
                    }
                    else
                    {
                        TextBox.Text = "Error operation not found";
                    }

                    if (peration == "/" && val_2 == 0)
                    {
                        TextBox.Text = "Error divide by zero";
                    }
                    else
                    {
                        TextBox.Text = result.ToString();
                    }
                    
                    val_1 = 0; val_2 = 0; peration = "";
                    break;

                case "C":
                    TextBox.Clear();
                    break;

                case "CE":
                    TextBox.Clear();
                    val_1 = 0; val_2 = 0; peration = "";
                    break;

                case "+": case "-": case "x": case "/":
                    
                    break;

                default:
                    TextBox.Text = "Error";
                    break;
            }
        }
    }
}