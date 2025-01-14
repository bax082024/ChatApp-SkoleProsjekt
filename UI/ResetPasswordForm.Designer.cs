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
            bttnSubmit = new Button();
            textBox1 = new TextBox();
            txtSecretAnswer = new TextBox();
            label1 = new Label();
            lblQuestion = new Label();
            lblSecretQuestion = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // bttnSubmit
            // 
            bttnSubmit.BackColor = Color.LightBlue;
            bttnSubmit.FlatStyle = FlatStyle.Popup;
            bttnSubmit.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bttnSubmit.Location = new Point(57, 130);
            bttnSubmit.Name = "bttnSubmit";
            bttnSubmit.Size = new Size(69, 26);
            bttnSubmit.TabIndex = 0;
            bttnSubmit.Text = "Submit";
            bttnSubmit.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(112, 93);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Username";
            textBox1.Size = new Size(139, 23);
            textBox1.TabIndex = 1;
            // 
            // txtSecretAnswer
            // 
            txtSecretAnswer.Location = new Point(29, 90);
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
            label1.Location = new Point(53, 21);
            label1.Name = "label1";
            label1.Size = new Size(257, 32);
            label1.TabIndex = 3;
            label1.Text = "Reset Password";
            // 
            // lblQuestion
            // 
            lblQuestion.AutoSize = true;
            lblQuestion.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuestion.ForeColor = Color.DarkOrange;
            lblQuestion.Location = new Point(40, 41);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(113, 17);
            lblQuestion.TabIndex = 4;
            lblQuestion.Text = "Secret Question :";
            // 
            // lblSecretQuestion
            // 
            lblSecretQuestion.AutoSize = true;
            lblSecretQuestion.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSecretQuestion.ForeColor = Color.DarkOrange;
            lblSecretQuestion.Location = new Point(40, 70);
            lblSecretQuestion.Name = "lblSecretQuestion";
            lblSecretQuestion.Size = new Size(16, 17);
            lblSecretQuestion.TabIndex = 5;
            lblSecretQuestion.Text = "''";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Controls.Add(lblQuestion);
            panel1.Controls.Add(lblSecretQuestion);
            panel1.Controls.Add(txtSecretAnswer);
            panel1.Controls.Add(bttnSubmit);
            panel1.Location = new Point(83, 139);
            panel1.Name = "panel1";
            panel1.Size = new Size(195, 187);
            panel1.TabIndex = 6;
            // 
            // ResetPasswordForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            ClientSize = new Size(367, 408);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "ResetPasswordForm";
            Text = "ResetPasswordForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bttnSubmit;
        private TextBox textBox1;
        private TextBox txtSecretAnswer;
        private Label label1;
        private Label lblQuestion;
        private Label lblSecretQuestion;
        private Panel panel1;
    }
}