using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Othmanadi
{
    public partial class QuizType : Form
    {
        public QuizType()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void btnCoutry_Click(object sender, EventArgs e)
        {
            UserQuiz quiz = new UserQuiz("Country");
            quiz.Show();
            this.Close();
        }

        private void btnFlag_Click(object sender, EventArgs e)
        {
            UserQuiz quiz = new UserQuiz("Flag");
            quiz.Show();
            this.Close();
        }

        private void btnCapitals_Click(object sender, EventArgs e)
        {
            UserQuiz quiz = new UserQuiz("Capital");
            quiz.Show();
            this.Close();
        }
    }
}
