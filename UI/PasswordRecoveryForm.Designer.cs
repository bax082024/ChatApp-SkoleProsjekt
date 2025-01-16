namespace ChatApp_SkoleProsjekt.UI
{
    partial class PasswordRecoveryForm
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
            panel1 = new Panel();
            button3 = new Button();
            btnRecover = new Button();
            btnNext = new Button();
            lblSecretQuestion = new Label();
            label2 = new Label();
            lblStatus = new Label();
            txtSecretAnswer = new TextBox();
            txtUsername = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DimGray;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(button3);
            panel1.Controls.Add(btnRecover);
            panel1.Controls.Add(btnNext);
            panel1.Controls.Add(lblSecretQuestion);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(lblStatus);
            panel1.Controls.Add(txtSecretAnswer);
            panel1.Controls.Add(txtUsername);
            panel1.Location = new Point(50, 55);
            panel1.Name = "panel1";
            panel1.Size = new Size(358, 303);
            panel1.TabIndex = 0;
            // 
            // button3
            // 
            button3.Location = new Point(148, 225);
            button3.Name = "button3";
            button3.Size = new Size(62, 25);
            button3.TabIndex = 7;
            button3.Text = "cancel";
            button3.UseVisualStyleBackColor = true;
            // 
            // btnRecover
            // 
            btnRecover.Location = new Point(148, 194);
            btnRecover.Name = "btnRecover";
            btnRecover.Size = new Size(62, 25);
            btnRecover.TabIndex = 6;
            btnRecover.Text = "recover";
            btnRecover.UseVisualStyleBackColor = true;
            btnRecover.Click += button2_Click;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(132, 93);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(62, 25);
            btnNext.TabIndex = 5;
            btnNext.Text = "next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // lblSecretQuestion
            // 
            lblSecretQuestion.AutoSize = true;
            lblSecretQuestion.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSecretQuestion.Location = new Point(101, 136);
            lblSecretQuestion.Name = "lblSecretQuestion";
            lblSecretQuestion.Size = new Size(97, 15);
            lblSecretQuestion.TabIndex = 4;
            lblSecretQuestion.Text = "Secret Question";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(132, 46);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 3;
            label2.Text = "Username";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(122, 18);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(13, 15);
            lblStatus.TabIndex = 2;
            lblStatus.Text = "''";
            // 
            // txtSecretAnswer
            // 
            txtSecretAnswer.Location = new Point(101, 154);
            txtSecretAnswer.Name = "txtSecretAnswer";
            txtSecretAnswer.Size = new Size(141, 23);
            txtSecretAnswer.TabIndex = 1;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(101, 64);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(141, 23);
            txtUsername.TabIndex = 0;
            // 
            // PasswordRecoveryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(459, 407);
            Controls.Add(panel1);
            Name = "PasswordRecoveryForm";
            Text = "PasswordRecoveryForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button3;
        private Button btnRecover;
        private Button btnNext;
        private Label lblSecretQuestion;
        private Label label2;
        private Label lblStatus;
        private TextBox txtSecretAnswer;
        private TextBox txtUsername;
    }
}