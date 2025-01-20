using ChatApp_SkoleProsjekt.Services;
using System;
using System.Drawing.Drawing2D;
using System.Windows.Forms;


namespace ChatApp_SkoleProsjekt.UI
{
    public partial class RegisterForm : Form
    {
        private readonly AuthenticationHelper _authService;

        public RegisterForm()
        {
            InitializeComponent();
            _authService = new AuthenticationHelper();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;
            string secretQuestion = txtSecretQuestion.Text;
            string secretAnswer = txtSecretAnswer.Text;

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            if (_authService.RegisterUser(username, password, secretQuestion, secretAnswer))
            {
                MessageBox.Show("Registration successful!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Registration failed. Username might already exist or requirements not met.");
            }

        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            using (LinearGradientBrush gradientBrush = new LinearGradientBrush(
                this.ClientRectangle,
                Color.Purple,  // Top color
                Color.DarkBlue,        // Bottom color
                LinearGradientMode.Vertical))
            {
                e.Graphics.FillRectangle(gradientBrush, this.ClientRectangle);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}