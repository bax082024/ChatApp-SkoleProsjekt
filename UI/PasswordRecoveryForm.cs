using ChatApp_SkoleProsjekt.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatApp_SkoleProsjekt.UI
{
    public partial class PasswordRecoveryForm : Form
    {
        private readonly AuthenticationHelper _authService;
        private string _currentUsername;

        public PasswordRecoveryForm()
        {
            InitializeComponent();
            _authService = new AuthenticationHelper();
            lblSecretQuestion.Visible = false;
            txtSecretAnswer.Visible = false;
            btnRecover.Visible = false;
            lblStatus.Text = string.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string secretAnswer = txtSecretAnswer.Text;

            if (_authService.ValidateSecretAnswer(_currentUsername, secretAnswer))
            {
                lblStatus.Text = "Secret answer is correct! Please reset your password.";
                var resetForm = new ResetPasswordForm(_currentUsername);
                resetForm.Show();
                this.Close();
            }
            else
            {
                lblStatus.Text = "Invalid answer to the secret question.";
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;

            var users = _authService.LoadUsers();
            var user = users.FirstOrDefault(u => u.Username == username);

            if (user == null)
            {
                lblStatus.Text = "Username not found.";
                lblStatus.ForeColor = Color.Red;
                return;
            }

            _currentUsername = username;
            lblSecretQuestion.Text = $"Secret Question: {user.SecretQuestion}";
            lblSecretQuestion.Visible = true;
            txtSecretAnswer.Visible = true;
            btnRecover.Visible = true;

            lblStatus.Text = string.Empty;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRecover_Click(object sender, EventArgs e)
        {
            string secretAnswer = txtSecretAnswer.Text;

            if (_authService.ValidateSecretAnswer(_currentUsername, secretAnswer))
            {
                lblStatus.Text = "Secret answer is correct! Please reset your password.";
                var resetForm = new ResetPasswordForm(_currentUsername);
                resetForm.Show();
                this.Close();
            }
            else
            {
                lblStatus.Text = "Invalid answer to the secret question.";
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
