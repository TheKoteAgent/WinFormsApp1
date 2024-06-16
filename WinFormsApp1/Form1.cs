namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private string[] questions = new string[10]
      {
            "1. skilce hromosom v jirafa:",
            "2. skilce klavish na klave:",
            "3. che vidno negra v nochi:",
            "4. smert doza geroina:",
            "5. skilce error v etomy kodi:",
            "6. a i b sideli na trybe. a ypala\n b propala rto ostalsa?:",
            "7. kto ne sigma:",
            "8. koli maks drugiy zlamav mech vanuye pershomy:",
            "9. skilke zapitan:",
            "10. yake se zapitana:"
      };

        private string[] answers = new string[10]
        {
            "60",
            "104",
            "net",
            "100",
            "0",
            "i",
            "vanya",
            "7 chervna",
            "10",
            "10"
        };

        private string[] userAnswers = new string[10];
        private int current = 0;

        private Label questionLabel;
        private TextBox answerTextBox;
        private Button nextButton;
        private Button finishButton;

        public Form1()
        {
            InitializeComponent();
            Quiz();
        }

        private void Quiz()
        {
            questionLabel = new Label();
            questionLabel.Top = 20;
            questionLabel.Left = 10;
            questionLabel.Width = 400;
            this.Controls.Add(questionLabel);

            answerTextBox = new TextBox();
            answerTextBox.Top = 50;
            answerTextBox.Left = 10;
            answerTextBox.Width = 400;
            this.Controls.Add(answerTextBox);

            nextButton = new Button();
            nextButton.Text = "Next";
            nextButton.Top = 100;
            nextButton.Left = 10;
            nextButton.Click += NextButton;
            this.Controls.Add(nextButton);

            finishButton = new Button();
            finishButton.Text = "Finish";
            finishButton.Top = 100;
            finishButton.Left = 100;
            finishButton.Click += FinishButton;
            this.Controls.Add(finishButton);

            DisplayCurrent();
        }

        private void DisplayCurrent()
        {
            questionLabel.Text = questions[current];
            answerTextBox.Text = userAnswers[current];
        }

        private void NextButton(object sender, EventArgs e)
        {
            userAnswers[current] = answerTextBox.Text.Trim();
            current++;

            if (current >= questions.Length)
            {
                current = questions.Length - 1;
                MessageBox.Show("click finish");
            }
            else
            {
                DisplayCurrent();
            }
        }

        private void FinishButton(object sender, EventArgs e)
        {
            userAnswers[current] = answerTextBox.Text.Trim();
            int score = 0;
            string wrongAnswers = "Incorrect:\n";
            bool anyWrong = false;

            for (int i = 0; i < 10; i++)
            {
                if (userAnswers[i].Equals(answers[i], StringComparison.InvariantCultureIgnoreCase))
                {
                    score++;
                }
                else
                {
                    wrongAnswers += $"Question {i + 1}: {questions[i]}\nYour answer: {userAnswers[i]}\n\n";
                    anyWrong = true;
                }
            }

            string resultMessage = $"Mark: {score}/10\n";
            if (anyWrong)
            {
                resultMessage += wrongAnswers;
            }

            MessageBox.Show(resultMessage);
        }
        

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
