using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OTFI1B_Parinas_MidtermMP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //quiz variables
        int correctAnswer;
        int QuestionNumber = 1;
        int Score;
        int Percentage;
        int TotalQuestions;

        private void Form1_Load(object sender, EventArgs e)
        {
            askQuestion(QuestionNumber);
            TotalQuestions = 5;
        }
        
        private void CheckAnswerEvent(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;
            int buttonTag = Convert.ToInt32(senderObject.Tag);

            if(buttonTag == correctAnswer)
            {
                Score = Score + 20;
            }

            if(QuestionNumber == TotalQuestions)
            {
                Percentage = (int)Math.Round((double)(Score * 100) / TotalQuestions);
                MessageBox.Show("Bam. Just like that, the quiz is over." + Environment.NewLine + "your total score is " + Score + " out of 100."
                + Environment.NewLine + "Click OK to play again");

                Score = 0;
                QuestionNumber = 0;
                askQuestion(QuestionNumber);

            }

            QuestionNumber++;
            askQuestion(QuestionNumber);

        }

        private void askQuestion(int qnum)
        {

            switch(qnum)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.gandalf;
                    lblQuestion.Text = "What's Gandalf's newest title?";
                    button1.Text = "Gandalf the White*";
                    button2.Text = "Gandalf the Grey";
                    button3.Text = "Gandalf the RGB";
                    button4.Text = "Yolanda Squatpump";

                    correctAnswer = 1;
                    break;

                case 2:
                    pictureBox1.Image = Properties.Resources._null;
                    lblQuestion.Text = "What's the real identity of the character known as gray fox?";
                    button1.Text = "Hot Coldman";
                    button2.Text = "Frank Jaeger*";
                    button3.Text = "Olga Gurlukovich";
                    button4.Text = "Steven Armstrong";

                    correctAnswer = 2;
                    break;

                case 3:
                    pictureBox1.Image = Properties.Resources.gaben;
                    lblQuestion.Text = "Who is the founder of Valve corporation?";
                    button1.Text = "Gabe Newell*";
                    button2.Text = "John Romero";
                    button3.Text = "Hideo Kojima";
                    button4.Text = "Saad Mann";

                    correctAnswer = 1;
                    break;

                case 4:
                    pictureBox1.Image = Properties.Resources.Baba_yaga;
                    lblQuestion.Text = "How many men did John Wick kill in a bar using only a pencil?";
                    button1.Text = "34";
                    button2.Text = "none";
                    button3.Text = "What's a pencil?";
                    button4.Text = "3*";

                    correctAnswer = 4;
                    break;

                case 5:
                    pictureBox1.Image = Properties.Resources.re_zero;
                    lblQuestion.Text = "What's my favourite anime?";
                    button1.Text = "JoJo's Bizzare Adventure";
                    button2.Text = "Ultraman 2019";
                    button3.Text = "Redo of healer ( ͡͡ ° ͜ ʖ ͡ °)";
                    button4.Text = "re zero*";

                    correctAnswer = 4;
                    break;
            }

        }

        private void lblQuestion_Click(object sender, EventArgs e)
        {

        }
    }
}
