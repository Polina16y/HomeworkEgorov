namespace Homework
{

    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            var login = textBox1.Text;
            var password = textBox2.Text;

            if (!RegisterUser(login, password))
                MessageBox.Show("Пользователь с таким логином уже существует!");
            else
                MessageBox.Show("Вы успешно зарегистрировались!");
            MainForm MainForm = new MainForm();
            this.Close();
            MainForm.Close();
        }
        public static bool RegisterUser(string login, string password)
        {
            using var context = new YourDbContext();

            var id = context.Users.Count() + 1;
            var user = new User()
            {
                UserId = id,
                Login = login,
                Password = password
            };
            var count = new Count()
            {
                UserId = id,
                Score = 0
            };

            if (context.Users.Count(x => x.Login.Equals(user.Login)) != 0)
                return false;

            context.Users.Add(user);
            context.Count.Add(count);
            context.SaveChanges();
            return true;
        }

        private void RegistrationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
