using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Drawing.Font;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Net.Mime.MediaTypeNames;
using System.Security.Cryptography.X509Certificates;

namespace FinalExamPROG1965W24
{
    public partial class FormPartTwo : Form
    {

        string _QuestionsPartTwo = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName +
                                @"\IOFiles\PartTwoQuestions.txt";
        string _AnswersPartTwo = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName +
                                @"\IOFiles\PartTwoAnswers.txt";
        string _ButtonImg = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName +
                                @"\IOFiles\buttBackG.png";

        Button selectedQuestion;
        string selectedAnswer;
        int answered = 0;


        public FormPartTwo()
        {
            InitializeComponent();
        }


        private void btnQuestion_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            listBox1.SelectedItem = null;
            selectedQuestion = (Button)sender;
            label1.Text = "You have selected Q: " + selectedQuestion.Text;
            StreamReader reader = null;
            try
            {
                reader = new StreamReader(_QuestionsPartTwo);
                while (!reader.EndOfStream)
                {
                    string record = reader.ReadLine();
                    string[] fields = record.Split("|");

                    if (fields[0] == selectedQuestion.Text)
                    {
                        richTextBox1.Text += "Question: " + fields[0] + "\n\n";
                        richTextBox1.Text += fields[1] + "\n\n";
                        for (int i = 2; i < fields.Length; i++)
                                richTextBox1.Text += "(" + (i-1) + ")  " + fields[i] + "\n\n";
                    }

                }

            }
            catch (FileNotFoundException) { MessageBox.Show("File with provinces name not found"); }
            catch (DirectoryNotFoundException) { MessageBox.Show("Directory not found"); }
            catch (IOException) { MessageBox.Show("Invalid input!"); }
            catch (Exception a) { MessageBox.Show(a.ToString()); }
            finally { reader.Dispose(); }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (selectedQuestion == null)
            {
                MessageBox.Show("Select a question.");
                return;
            }
            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("Select an answer.");
                return;
            }
            if (selectedAnswer == "")
            {
                MessageBox.Show("Select an answer.");
                return;
            }
            selectedAnswer = listBox1.SelectedItem.ToString();
            string record = selectedQuestion.Text + "," + selectedAnswer;
            //////////////////////////////
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult response = MessageBox.Show("You want to record ANSWER # " + selectedAnswer+" as your answer for QUESTION # "+ selectedQuestion.Text,
            "About to submit your answer", buttons, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            if (response == DialogResult.No)
            {
                //this.Close();
                return;
            }
            else
            {
                StreamWriter writer = null;
                try
                {
                    writer = new StreamWriter(_AnswersPartTwo, true);
                    writer.WriteLine(record);
                    answered++;
                    label3.Text=answered.ToString();
                }
                catch (FileNotFoundException) { MessageBox.Show("File not found"); }
                catch (DirectoryNotFoundException) { MessageBox.Show("Directory not found"); }
                catch (IOException) { MessageBox.Show("Problem with file data"); }
                catch (Exception excep) { MessageBox.Show(excep.ToString()); }
                finally { writer.Dispose(); }
                selectedQuestion.Enabled = false;
                selectedQuestion.BackgroundImage = System.Drawing.Image.FromFile(_ButtonImg);
                selectedQuestion = null;
                label1.Text = string.Empty;
                richTextBox1.Text = string.Empty;
            }
        }
        private List<string> CheckAnswers()
        {

            StreamReader reader = null;
            List<string> answers = new List<string>();
            try
            {
                reader = new StreamReader(_AnswersPartTwo);
                while (!reader.EndOfStream)
                {
                    string record = reader.ReadLine();
                    string[] fields = record.Split("|");

                    answers.Add(fields[0]);
                    answered++;
                }

            }
            catch (FileNotFoundException) { MessageBox.Show("File with provinces name not found"); }
            catch (DirectoryNotFoundException) { MessageBox.Show("Directory not found"); }
            catch (IOException) { MessageBox.Show("Invalid input!"); }
            catch (Exception a) { MessageBox.Show(a.ToString()); }
            finally { reader.Dispose(); }
            return answers;
        }
        private void FormPartTwo_Load_1(object sender, EventArgs e)
        {
            Button selectedQuestion = null;
            string selectedAnswer = "";
            List<string> answers = CheckAnswers();
            label3.Text = answered.ToString();
            int buttonSize = 50;
            int sizeCol = 5;
            int sizeRow = 2;
            for (int i = 0; i < sizeCol; i++)
            {
                for (int j = 0; j < sizeRow; j++)
                {
                    int ind = (sizeRow * i + j);
                    Button button = new Button();
                    button.Location = new Point(10 + i * buttonSize, 50 + j * buttonSize);
                    button.Name = "buttonQuestion" + (ind + 1).ToString();
                    button.Size = new Size(buttonSize, buttonSize);
                    button.TabIndex = i * 10 + j;
                    button.Text = (ind + 1).ToString();
                    button.UseVisualStyleBackColor = true;
                    button.Visible = true;
                    button.BringToFront();
                    button.Click += btnQuestion_Click;
                    this.Controls.Add(button);
                    foreach (string answer in answers)
                        if (answer == button.Text) {
                        button.Enabled = false;
                        button.BackgroundImage = System.Drawing.Image.FromFile(_ButtonImg);
                        }
                }
            }
        }
    }
}

