using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework
{
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();
        }
        public static bool UserAuthorize(string login, string password)
        {
            try
            {
                using var context = new YourDbContext();

                var user = context.Users.FirstOrDefault(x => x.Login.Equals(login));
                if (user == null)
                    throw new Exception("Пользователя с таким логином не существует!");

                if (!user.Password.Equals(password))
                    throw new Exception("Неверный пароль!");
                Program.Session = user;
                Program.Click = context.Count.FirstOrDefault(x => x.UserId.Equals(user.UserId));
                return true;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return false;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var login = AuthLog.Text;
            var password = AuthPass.Text;

            if (UserAuthorize(login, password))
            {
                var Form1111 = new Clicker();
                Form1111.Show();
                this.Hide();
            }
        }

        private void AuthForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
