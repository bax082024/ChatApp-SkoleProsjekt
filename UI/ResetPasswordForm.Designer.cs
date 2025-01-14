namespace ChatApp_SkoleProsjekt.UI
{
    partial class ResetPasswordForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            bttnReset = new Button();
            textBox1 = new TextBox();
            txtSecretAnswer = new TextBox();
            label1 = new Label();
            lblSecretQuestion = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // bttnReset
            // 
            bttnReset.BackColor = Color.LightBlue;
            bttnReset.FlatStyle = FlatStyle.Popup;
            bttnReset.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bttnReset.Location = new Point(61, 122);
            bttnReset.Name = "bttnReset";
            bttnReset.Size = new Size(69, 26);
            bttnReset.TabIndex = 0;
            bttnReset.Text = "Reset";
            bttnReset.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(29, 35);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Username";
            textBox1.Size = new Size(139, 23);
            textBox1.TabIndex = 1;
            // 
            // txtSecretAnswer
            // 
            txtSecretAnswer.Location = new Point(29, 79);
            txtSecretAnswer.Name = "txtSecretAnswer";
            txtSecretAnswer.PlaceholderText = "Secret Answer";
            txtSecretAnswer.Size = new Size(139, 23);
            txtSecretAnswer.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Gold;
            label1.Location = new Point(42, 21);
            label1.Name = "label1";
            label1.Size = new Size(257, 32);
            label1.TabIndex = 3;
            label1.Text = "Reset Password";
            // 
            // lblSecretQuestion
            // 
            lblSecretQuestion.AutoSize = true;
            lblSecretQuestion.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSecretQuestion.ForeColor = Color.DarkOrange;
            lblSecretQuestion.Location = new Point(29, 15);
            lblSecretQuestion.Name = "lblSecretQuestion";
            lblSecretQuestion.Size = new Size(16, 17);
            lblSecretQuestion.TabIndex = 5;
            lblSecretQuestion.Text = "''";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Controls.Add(lblSecretQuestion);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(txtSecretAnswer);
            panel1.Controls.Add(bttnReset);
            panel1.Location = new Point(73, 56);
            panel1.Name = "panel1";
            panel1.Size = new Size(195, 213);
            panel1.TabIndex = 6;
            // 
            // ResetPasswordForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            ClientSize = new Size(340, 322);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "ResetPasswordForm";
            Text = "ResetPasswordForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bttnReset;
        private TextBox textBox1;
        private TextBox txtSecretAnswer;
        private Label label1;
        private Label lblSecretQuestion;
        private Panel panel1;
    }
}