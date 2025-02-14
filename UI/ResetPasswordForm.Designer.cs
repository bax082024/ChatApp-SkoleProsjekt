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
            lblStatus = new Label();
            panel1 = new Panel();
            btnCancel = new Button();
            btnReset = new Button();
            txtConfirmPassword = new TextBox();
            txtNewPassword = new TextBox();
            panel2 = new Panel();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatus.Location = new Point(62, 8);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(149, 25);
            lblStatus.TabIndex = 1;
            lblStatus.Text = "Reset Password";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGray;
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(btnReset);
            panel1.Controls.Add(txtConfirmPassword);
            panel1.Controls.Add(txtNewPassword);
            panel1.Controls.Add(lblStatus);
            panel1.Location = new Point(7, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(276, 220);
            panel1.TabIndex = 2;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.LightBlue;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(91, 165);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(85, 27);
            btnCancel.TabIndex = 14;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.LightBlue;
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReset.Location = new Point(91, 125);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(85, 27);
            btnReset.TabIndex = 13;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.BackColor = SystemColors.Info;
            txtConfirmPassword.Location = new Point(72, 91);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PlaceholderText = "Confirm Password";
            txtConfirmPassword.Size = new Size(127, 23);
            txtConfirmPassword.TabIndex = 12;
            // 
            // txtNewPassword
            // 
            txtNewPassword.BackColor = SystemColors.Info;
            txtNewPassword.Location = new Point(72, 52);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.PlaceholderText = "New Password";
            txtNewPassword.Size = new Size(127, 23);
            txtNewPassword.TabIndex = 11;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DimGray;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(panel1);
            panel2.Location = new Point(56, 43);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(295, 234);
            panel2.TabIndex = 3;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(24, 24);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 321);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(410, 22);
            statusStrip1.TabIndex = 7;
            statusStrip1.Text = "Chat App";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.BackColor = Color.Transparent;
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(57, 17);
            toolStripStatusLabel1.Text = "Chat App";
            // 
            // ResetPasswordForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(410, 343);
            Controls.Add(statusStrip1);
            Controls.Add(panel2);
            Name = "ResetPasswordForm";
            Text = "ResetPasswordForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblStatus;
        private Panel panel1;
        private Panel panel2;
        private TextBox txtConfirmPassword;
        private TextBox txtNewPassword;
        private Button btnReset;
        private Button btnCancel;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
    }
}