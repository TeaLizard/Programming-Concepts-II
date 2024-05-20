using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InClass_Asst5_PROG1965_W24
{
    public partial class FormPartTwo : Form
    {
        string _QuestionsPartTwo = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName + @"\IOFiles\PartTwoQuestions.txt";
        string _AnswersPartTwo = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName + @"\IOFiles\PartTwoAnswers.txt";
        private static int? CurrentQuestion = null;

        public FormPartTwo()
        {
            InitializeComponent();
        }

        private void FormPartTwo_Load(object sender, EventArgs e)
        {
            int buttonSize = 50;
            int horizontalSize = 4;
            int verticalSize = 5;
            for (int i = 0; i < horizontalSize; i++)
            {
                for (int j = 0; j < verticalSize; j++)
                {
                    int ind = (verticalSize * i + j);
                    Button button = new Button();
                    button.Location = new Point(10 + j * buttonSize, 10 + i * buttonSize);
                    button.Name = "buttonQuestion" + (ind + 1).ToString();
                    button.Size = new Size(buttonSize, buttonSize);
                    button.TabIndex = i * verticalSize + j;
                    button.Text = (ind + 1).ToString();
                    button.UseVisualStyleBackColor = true;
                    button.Visible = true;
                    button.BringToFront();
                    this.Controls.Add(button);

                    button.Click += QuestionButtonPress;
                }
            }
        }

        private void QuestionButtonPress(object? sender, EventArgs e)
        {
            Button button = (Button)sender;

            button.Enabled = false;
            button.BackgroundImage = Properties.Resources.buttBackG;

            int questionNumber = int.Parse(button.Text);
            CurrentQuestion = questionNumber;

            StreamReader reader = null;
            try
            {
                reader = new StreamReader(_QuestionsPartTwo);

                while (!reader.EndOfStream)
                {
                    string record = reader.ReadLine();
                    string[] fields = record.Split(",");

                    if (int.Parse(fields[0]) == questionNumber)
                    {
                        richTextBoxQuestion.Text = $"Question: {questionNumber}\n\n";
                        richTextBoxQuestion.Text += $"{fields[1]}\n\n";

                        int i = 0;
                        foreach (string field in fields)
                        {
                            if (i > 1)
                            {
                                richTextBoxQuestion.Text += $"({i - 1}) {field}\n";
                            }
                            i++;
                        }
                    }
                }
            }
            catch (FileNotFoundException) { MessageBox.Show("File not found"); }
            catch (DirectoryNotFoundException) { MessageBox.Show("Directory not found"); }
            catch (IOException) { MessageBox.Show("Invalid input!"); }
            catch (Exception a) { MessageBox.Show(a.ToString()); }
            finally
            {
                reader.Dispose();
                reader.Close();
            }
        }

        private void SubmitAnswer(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(listBoxAnswer.Text.Trim()) && CurrentQuestion != null)
            {
                SubmitLabel.Text = "Are you sure you you want to submit this answer?";
                SubmitPanel.Visible = true;
            }
        }

        private void SubmitMessageBoxClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            SubmitPanel.Visible = false;
            if (button.Text == "Submit")
            {
                StreamWriter writer = null;
                try
                {
                    writer = new StreamWriter(_AnswersPartTwo, true);

                    writer.WriteLine($"{CurrentQuestion},{listBoxAnswer.Text.Trim()}");
                }
                catch (FileNotFoundException) { MessageBox.Show("File not found"); }
                catch (DirectoryNotFoundException) { MessageBox.Show("Directory not found"); }
                catch (IOException) { MessageBox.Show("Problem with file data"); }
                catch (Exception excep) { MessageBox.Show(excep.ToString()); }
                finally { writer.Dispose(); }
            }
            //else if (button.Text == "Cancel")
            //{

            //}
        }
    }
}
