namespace Authorization
{
    public partial class AuthorizationForm : Form
    {
        public AuthorizationForm()
        {
            InitializeComponent();
        }
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            var login = textBoxLogin.Text;
            var password = textBoxPassword.Text;

            if (AuthorizationController.TryLogin(login, password))
            {
                MessageBox.Show($"Вы вошли", "Успех");
            }
            else
            {
                labelInfo.Visible = true;
            }
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            var registrationForm = new RegistrationForm();

            if (registrationForm.ShowDialog() == DialogResult.OK)
            {
                textBoxLogin.Text = registrationForm.Login;
            }
        }
    }
}
