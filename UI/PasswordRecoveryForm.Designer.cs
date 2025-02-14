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
            txtSecretAnswer = new TextBox();
            label1 = new Label();
            btnNext = new Button();
            txtUsername = new TextBox();
            btnCancel = new Button();
            btnRecover = new Button();
            lblSecretQuestion = new Label();
            label2 = new Label();
            lblStatus = new Label();
            panel2 = new Panel();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGray;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(txtSecretAnswer);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnNext);
            panel1.Controls.Add(txtUsername);
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(btnRecover);
            panel1.Controls.Add(lblSecretQuestion);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(lblStatus);
            panel1.Location = new Point(8, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(253, 249);
            panel1.TabIndex = 0;
            // 
            // txtSecretAnswer
            // 
            txtSecretAnswer.BackColor = SystemColors.Info;
            txtSecretAnswer.Location = new Point(61, 143);
            txtSecretAnswer.Name = "txtSecretAnswer";
            txtSecretAnswer.PlaceholderText = "Secret Answer";
            txtSecretAnswer.Size = new Size(127, 23);
            txtSecretAnswer.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(30, 6);
            label1.Name = "label1";
            label1.Size = new Size(184, 25);
            label1.TabIndex = 4;
            label1.Text = "Password Recovery";
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.LightBlue;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNext.Location = new Point(82, 85);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(85, 27);
            btnNext.TabIndex = 11;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = SystemColors.Info;
            txtUsername.Location = new Point(61, 60);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Username";
            txtUsername.Size = new Size(127, 23);
            txtUsername.TabIndex = 10;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.LightBlue;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(82, 211);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(85, 27);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnRecover
            // 
            btnRecover.BackColor = Color.LightBlue;
            btnRecover.FlatStyle = FlatStyle.Flat;
            btnRecover.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRecover.Location = new Point(82, 178);
            btnRecover.Name = "btnRecover";
            btnRecover.Size = new Size(85, 27);
            btnRecover.TabIndex = 8;
            btnRecover.Text = "Recover";
            btnRecover.UseVisualStyleBackColor = false;
            btnRecover.Click += btnRecover_Click;
            // 
            // lblSecretQuestion
            // 
            lblSecretQuestion.AutoSize = true;
            lblSecretQuestion.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSecretQuestion.Location = new Point(70, 117);
            lblSecretQuestion.Name = "lblSecretQuestion";
            lblSecretQuestion.Size = new Size(97, 15);
            lblSecretQuestion.TabIndex = 4;
            lblSecretQuestion.Text = "Secret Question";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(89, 42);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 3;
            label2.Text = "Username";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(125, 42);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(13, 15);
            lblStatus.TabIndex = 2;
            lblStatus.Text = "''";
            // 
            // panel2
            // 
            panel2.BackColor = Color.DimGray;
            panel2.Controls.Add(panel1);
            panel2.Location = new Point(48, 44);
            panel2.Margin = new Padding(2, 2, 2, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(269, 262);
            panel2.TabIndex = 5;
            panel2.Paint += panel2_Paint;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(24, 24);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 336);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(369, 22);
            statusStrip1.TabIndex = 6;
            statusStrip1.Text = "Chat App";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.BackColor = Color.Transparent;
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(57, 17);
            toolStripStatusLabel1.Text = "Chat App";
            // 
            // PasswordRecoveryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(369, 358);
            Controls.Add(statusStrip1);
            Controls.Add(panel2);
            Name = "PasswordRecoveryForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PasswordRecoveryForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lblSecretQuestion;
        private Label label2;
        private Label lblStatus;
        private Label label1;
        private Panel panel2;
        private Button btnCancel;
        private Button btnRecover;
        private Button btnNext;
        private TextBox txtUsername;
        private TextBox txtSecretAnswer;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
    }
}