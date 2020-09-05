using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Othmanadi.Model;

namespace Othmanadi
{
    public partial class UserQuiz : Form
    {
        string quizType;
        QuizAppEntities Entities = new QuizAppEntities();
        List<Quiz> quizzes = new List<Quiz>();
        int score, qNumber;
        Quiz quiz;
        private readonly Random _random = new Random();
        public UserQuiz(string QuizType)
        {
            InitializeComponent();
            quizType = QuizType;
            quizzes = Entities.Quizs.Where(x=>x.QuizType.Equals(quizType)).ToList();
            qNumber = 0;
            Reset();
            setQuestion();
            if(quizType=="Flag")
            {
                pictureBox1.Visible = true;
            }
        }
        void setQuestion()
        {
            Reset();
            
            lbscore.Text = score.ToString();
            if (quizzes.Count > 0)
            {
                qNumber++;
                lbnumber.Text = qNumber.ToString();
                
                int quizNumb = _random.Next(0, quizzes.Count);
                quiz = quizzes[quizNumb];
                lbquestion.Text = quiz.Question_Text;
                op1.Text = quiz.OptionA;
                op2.Text = quiz.OptionB;
                op3.Text = quiz.OptionC;
                op4.Text = quiz.OptionD;
                if (quizType == "Flag")
                {
                    pictureBox1.Image = Image.FromFile("flags/"+quiz.Answer+".png");
                }
            }
            else
            {
                MessageBox.Show("Thank you, Your score is : " + score + ". Your score has been saved..!");
                QuizScore qscore = new QuizScore();
                qscore.UserId = Global.LoggedInUserId;
                qscore.Score = score;
                qscore.QuizDate = DateTime.Now;
                Entities.QuizScores.Add(qscore);
                Entities.SaveChanges();
                btnMenu.Enabled = true;

            }
                
           
            
        }
        
        private void Submit_Click(object sender, EventArgs e)
        {
            string userAnswer = "";
            if (op1.Checked)
            {
                userAnswer = op1.Text;
            }
            else if (op2.Checked)
            {
                userAnswer = op2.Text;
            }
            else if (op3.Checked)
            {
                userAnswer = op3.Text;
            }
            else if (op4.Checked)
            {
                userAnswer = op4.Text;
            }
            else
                MessageBox.Show("Please select an Answer");

            if(!string.IsNullOrEmpty(userAnswer))
            {
                if(userAnswer.Equals(quiz.Answer))
                {
                    lbmsg.Text = "Your Answer is Correct..!";
                    score += 10;
                }
                else
                    lbmsg.Text = "Your Answer is Incorrect..!";
                quizzes.Remove(quiz);
                setQuestion();
                
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            QuizType quizType = new QuizType();
            quizType.Show();
            this.Close();
        }

        void Reset()
        {
            op1.Checked = false;
            op2.Checked = false;
            op3.Checked = false;
            op4.Checked = false;
            //lbmsg.Text = string.Empty;
        }
    }
}
