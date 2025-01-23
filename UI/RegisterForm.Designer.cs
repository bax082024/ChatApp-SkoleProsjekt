namespace ChatApp_SkoleProsjekt.UI
{
    partial class RegisterForm
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
            panel2 = new Panel();
            label1 = new Label();
            btnCancel = new Button();
            btnRegister = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            txtSecretAnswer = new TextBox();
            txtUsername = new TextBox();
            txtSecretQuestion = new TextBox();
            txtPassword = new TextBox();
            txtConfirmPassword = new TextBox();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DimGray;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(89, 59);
            panel1.Name = "panel1";
            panel1.Size = new Size(306, 334);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkGray;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(btnCancel);
            panel2.Controls.Add(btnRegister);
            panel2.Controls.Add(tableLayoutPanel1);
            panel2.Location = new Point(6, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(289, 319);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(76, 0);
            label1.Name = "label1";
            label1.Size = new Size(129, 25);
            label1.TabIndex = 5;
            label1.Text = "Register User";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.LightBlue;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(95, 278);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(85, 27);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.LightBlue;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegister.Location = new Point(95, 236);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(85, 27);
            btnRegister.TabIndex = 2;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(txtSecretAnswer, 0, 4);
            tableLayoutPanel1.Controls.Add(txtUsername, 0, 0);
            tableLayoutPanel1.Controls.Add(txtSecretQuestion, 0, 3);
            tableLayoutPanel1.Controls.Add(txtPassword, 0, 1);
            tableLayoutPanel1.Controls.Add(txtConfirmPassword, 0, 2);
            tableLayoutPanel1.Location = new Point(73, 43);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(138, 187);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // txtSecretAnswer
            // 
            txtSecretAnswer.BackColor = SystemColors.Info;
            txtSecretAnswer.Location = new Point(3, 151);
            txtSecretAnswer.Name = "txtSecretAnswer";
            txtSecretAnswer.PlaceholderText = "Question Answer";
            txtSecretAnswer.Size = new Size(126, 23);
            txtSecretAnswer.TabIndex = 4;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = SystemColors.Info;
            txtUsername.Location = new Point(3, 3);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Username";
            txtUsername.Size = new Size(126, 23);
            txtUsername.TabIndex = 0;
            // 
            // txtSecretQuestion
            // 
            txtSecretQuestion.BackColor = SystemColors.Info;
            txtSecretQuestion.Location = new Point(3, 114);
            txtSecretQuestion.Name = "txtSecretQuestion";
            txtSecretQuestion.PlaceholderText = "Secret Question";
            txtSecretQuestion.Size = new Size(126, 23);
            txtSecretQuestion.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = SystemColors.Info;
            txtPassword.Location = new Point(3, 40);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(126, 23);
            txtPassword.TabIndex = 1;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.BackColor = SystemColors.Info;
            txtConfirmPassword.Location = new Point(3, 77);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PlaceholderText = "Confirm Password";
            txtConfirmPassword.Size = new Size(126, 23);
            txtConfirmPassword.TabIndex = 2;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 449);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(480, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "Chat App";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.BackColor = Color.Transparent;
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(57, 17);
            toolStripStatusLabel1.Text = "Chat App";
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(480, 471);
            Controls.Add(statusStrip1);
            Controls.Add(panel1);
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterForm";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private TextBox txtSecretAnswer;
        private TextBox txtSecretQuestion;
        private TextBox txtConfirmPassword;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnCancel;
        private Button btnRegister;
        private Label label1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
    }
}