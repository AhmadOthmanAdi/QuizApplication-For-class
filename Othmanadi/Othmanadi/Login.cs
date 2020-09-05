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
    public partial class Login : Form
    {
        QuizAppEntities pe = new QuizAppEntities();
        public Login()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var usrLoginId = loginid.Text;
            var usrPassword = password.Text;
            var user = pe.SysUsers?.Where(x => x.Username.Equals(usrLoginId) && x.Password.Equals(usrPassword))?.FirstOrDefault();

            if (user != null)
            {
                Global.LoggedInUserId = user.Id;
                var mainMenu = new QuizType();
                mainMenu.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Login Failed, Please provide valid credentials..!");
            }
        }

        private void LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UserRegisteration userRegisteration = new UserRegisteration();
            userRegisteration.Show();
            Hide();
        }
    }
}
