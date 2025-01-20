using ChatApp_SkoleProsjekt.Services;
using ChatApp_SkoleProsjekt.UI;

namespace ChatApp_SkoleProsjekt
{
    public partial class LoginForm : Form
    {

        private readonly AuthenticationHelper _authService;

        public LoginForm()
        {
            InitializeComponent();
            _authService = new AuthenticationHelper();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (_authService.AuthenticateUser(username, password))
            {
                var currentUser = _authService.GetUserByUsername(username); // Fetch the current user object
                if (currentUser != null)
                {
                    var chatForm = new ChatForm(); // Pass the User object
                    this.Hide();
                    chatForm.Show();
                }
                else
                {
                    MessageBox.Show("User not found.");
                }
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var recoveryForm = new PasswordRecoveryForm();
            recoveryForm.Show();
        }     

        private void btnRegister_Click(object sender, EventArgs e)
        {
            var registerForm = new RegisterForm();
            registerForm.Show();
        }
    }
}