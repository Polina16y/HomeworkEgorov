namespace Homework
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            RegistrationForm newForm = new RegistrationForm();
            newForm.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            AuthForm newForm = new AuthForm();
            newForm.Show();
            this.Hide();
        }
    }
}