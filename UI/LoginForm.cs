using ChatApp_SkoleProsjekt.Services;
using ChatApp_SkoleProsjekt.UI;
using System.Drawing.Drawing2D;

using NAudio.Wave; // lyd

namespace ChatApp_SkoleProsjekt
{
    public partial class LoginForm : Form
    {
        // Lyd
        private WaveOutEvent waveOut;
        private AudioFileReader audioFileReader;

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
                var currentUser = _authService.GetUserByUsername(username);
                if (currentUser != null)
                {
                    var chatForm = new ChatForm(currentUser);  
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



        private void btnRegister_Click(object sender, EventArgs e)
        {
            var registerForm = new RegisterForm();
            registerForm.Show();
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string soundFilePath = @"Sounds\Bax.m4a";

                waveOut?.Stop();
                waveOut?.Dispose();
                audioFileReader?.Dispose();

                audioFileReader = new AudioFileReader(soundFilePath);
                waveOut = new WaveOutEvent();
                waveOut.Init(audioFileReader);
                waveOut.Play();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error playing sound: {ex.Message}");
            }
        }

        private void linkRecovery_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var recoveryForm = new PasswordRecoveryForm();
            recoveryForm.Show();
        }
    }
}