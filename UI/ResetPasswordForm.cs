using ChatApp_SkoleProsjekt.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ChatApp_SkoleProsjekt.UI
{
    public partial class ResetPasswordForm : Form
    {
        private readonly AuthenticationHelper _authService;
        private string _username;

        public ResetPasswordForm(string username)
        {
            InitializeComponent();
            _authService = new AuthenticationHelper();
            _username = username;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            string newPassword = txtNewPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            if (newPassword != confirmPassword)
            {
                lblStatus.Text = "Passwords do not match.";
                return;
            }

            if (!_authService.IsValidPassword(newPassword))
            {
                lblStatus.Text = "Password does not meet requirements.";
                return;
            }

            var users = _authService.LoadUsers();
            var user = users.Find(u => u.Username == _username);

            if (user == null)
            {
                lblStatus.Text = "User not found.";
                return;
            }

            string newSalt = _authService.GenerateSalt();
            user.Salt = newSalt;
            user.PasswordHash = _authService.HashPassword(newPassword, newSalt);

            _authService.SaveUsers(users);
            MessageBox.Show("Password reset successful!");
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }


}
