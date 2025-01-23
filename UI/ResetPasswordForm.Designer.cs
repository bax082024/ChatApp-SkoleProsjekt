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
            panel2 = new Panel();
            txtNewPassword = new TextBox();
            txtConfirmPassword = new TextBox();
            btnReset = new Button();
            btnCancel = new Button();
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
            lblStatus.Location = new Point(88, 13);
            lblStatus.Margin = new Padding(4, 0, 4, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(217, 38);
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
            panel1.Location = new Point(10, 8);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(394, 366);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DimGray;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(panel1);
            panel2.Location = new Point(80, 71);
            panel2.Name = "panel2";
            panel2.Size = new Size(420, 388);
            panel2.TabIndex = 3;
            // 
            // txtNewPassword
            // 
            txtNewPassword.BackColor = SystemColors.Info;
            txtNewPassword.Location = new Point(103, 87);
            txtNewPassword.Margin = new Padding(4, 5, 4, 5);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.PlaceholderText = "Username";
            txtNewPassword.Size = new Size(180, 31);
            txtNewPassword.TabIndex = 11;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.BackColor = SystemColors.Info;
            txtConfirmPassword.Location = new Point(103, 151);
            txtConfirmPassword.Margin = new Padding(4, 5, 4, 5);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PlaceholderText = "Confirm Password";
            txtConfirmPassword.Size = new Size(180, 31);
            txtConfirmPassword.TabIndex = 12;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.LightBlue;
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReset.Location = new Point(130, 209);
            btnReset.Margin = new Padding(4, 5, 4, 5);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(121, 45);
            btnReset.TabIndex = 13;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.LightBlue;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(130, 275);
            btnCancel.Margin = new Padding(4, 5, 4, 5);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(121, 45);
            btnCancel.TabIndex = 14;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(24, 24);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 539);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 20, 0);
            statusStrip1.Size = new Size(585, 32);
            statusStrip1.TabIndex = 7;
            statusStrip1.Text = "Chat App";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.BackColor = Color.Transparent;
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(87, 25);
            toolStripStatusLabel1.Text = "Chat App";
            // 
            // ResetPasswordForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(585, 571);
            Controls.Add(statusStrip1);
            Controls.Add(panel2);
            Margin = new Padding(4, 5, 4, 5);
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