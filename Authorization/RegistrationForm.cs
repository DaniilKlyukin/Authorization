using System.Diagnostics;

namespace Authorization
{
    public partial class RegistrationForm : Form
    {
        public string Login { get; private set; } = string.Empty;

        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            var login = textBoxLogin.Text;
            var password = textBoxPassword.Text;
            var mail = textBoxMail.Text;

            if (!AuthorizationController.TryRegister(login, password, mail, out var message))
            {
                showErrorMessage(message);
                return;
            }

            Login = login;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void showErrorMessage(string message)
        {
            labelInfo.Text = message;
            labelInfo.Visible = true;
        }
    }
}
