namespace ChatApp_SkoleProsjekt.UI
{
    public partial class RegisterForm : Form private void RegisterButton_Click(object sender, EventArgs e)
    {

    };
    
    using System;
    using System.Windows.Form;

    namespace RegistrationForm
    {
        // XFGDRYDR
        public partial class RegistrationForm : RegisterForm
        {

            InitializeComponent();
            private InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Get the user input
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;
            string secretQuestion = cmbSecretQuestion.SelectedItem?.ToString();
            string secretAnswer = txtSecretAnswer.Text;

            // Validate inputs
            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Please enter your Username.");
                return;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter your Password.");
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords and Username does not match.");
                return;
            }

            if (string.IsNullOrWhiteSpace(secretQuestion))
            {
                MessageBox.Show("Please select a secret question.");
                return;
            }

            if (string.IsNullOrWhiteSpace(secretAnswer))
            {
                MessageBox.Show("Secret answer is required.");
                return;
            }

            // Here, you could save the user data to a file or a database//
            string userData = $"{username},{password},{secretQuestion},{secretAnswer}";

            try
            {
                // Save the registration details to a file (you could use a database here)
                File.AppendAllText("users.txt", userData + Environment.NewLine);
                MessageBox.Show("Registration successful!");

                // Clear the registration form
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving user data: " + ex.Message);
            }
        }

        private void ClearForm()
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtConfirmPassword.Clear();
            cmbSecretQuestion.SelectedIndex = -1;
            txtSecretAnswer.Clear();
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            // Add some secret questions to the ComboBox (it is possible to add more questions if required)
            cmbSecretQuestion.Items.Add("What is your favorite color?");
            cmbSecretQuestion.Items.Add("What is your favortie animal?");
            cmbSecretQuestion.Items.Add("What was the name of your first pet?");
            cmbSecretQuestion.Items.Add("What is your favorite food?");
        }
    }
};