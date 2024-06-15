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

        private TextBox[] answerTextBoxes = new TextBox[10];
        public Form1()
        {
            InitializeComponent();
            InitializeQuiz();
        }

        private void InitializeQuiz()
        {
            for (int i = 0; i < 10; i++)
            {
                Label questionLabel = new Label();
                questionLabel.Text = questions[i];
                questionLabel.Top = 20 + i * 30;
                questionLabel.Left = 10;
                questionLabel.Width = 200;
                this.Controls.Add(questionLabel);

                TextBox answerTextBox = new TextBox();
                answerTextBox.Top = 20 + i * 30;
                answerTextBox.Left = 220;
                answerTextBox.Width = 100;
                this.Controls.Add(answerTextBox);
                answerTextBoxes[i] = answerTextBox;
            }

            Button checkButton = new Button();
            checkButton.Text = "Check Answers";
            checkButton.Top = 350;
            checkButton.Left = 10;
            checkButton.Click += CheckButton_Click;
            this.Controls.Add(checkButton);
        }

        private void CheckButton_Click(object sender, EventArgs e)
        {
            int score = 0;
            string wrongAnswers = "Incorrect answers:\n";
            bool anyWrong = false;

            for (int i = 0; i < 10; i++)
            {
                if (answerTextBoxes[i].Text.Trim().Equals(answers[i], StringComparison.InvariantCultureIgnoreCase))
                {
                    score++;
                }
                else
                {
                    wrongAnswers += $"Vo[ros {i + 1}: {questions[i]}\nanswer: {answers[i]}\n\n";
                    anyWrong = true;
                }
            }

            string resultMessage = $"mark: {score}/10\n";
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
