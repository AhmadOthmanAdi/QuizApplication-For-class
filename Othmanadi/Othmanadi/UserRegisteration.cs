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
    public partial class UserRegisteration : Form
    {
        QuizAppEntities quizAppEntities = new QuizAppEntities();
        public UserRegisteration()
        {
            InitializeComponent();
        }

        private void LoginLink(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(tbFullName.Text) || string.IsNullOrEmpty(loginid.Text)
                || string.IsNullOrEmpty(password.Text))
            {
                MessageBox.Show("Please fill All Fields");
            }
            else
            {
                SysUser user = new SysUser();
                user.FullName = tbFullName.Text;
                user.Username = loginid.Text;
                user.Password = password.Text;
                quizAppEntities.SysUsers.Add(user);
                quizAppEntities.SaveChanges();
                MessageBox.Show("Registered Successfully..!");
                tbFullName.Text = string.Empty;
                loginid.Text = string.Empty;
                password.Text = string.Empty;
            }
        }
    }
}
