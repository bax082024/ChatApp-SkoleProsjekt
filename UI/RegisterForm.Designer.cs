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
            Register = new Button();
            checkBox1 = new CheckBox();
            CancelButton = new Button();
            SuspendLayout();
            // 
            // Register
            // 
            Register.Location = new Point(533, 34);
            Register.Name = "Register";
            Register.Size = new Size(94, 29);
            Register.TabIndex = 0;
            Register.Text = "Register";
            Register.UseVisualStyleBackColor = true;
            Register.Click += this.RegisterButton_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(533, 137);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(96, 24);
            checkBox1.TabIndex = 1;
            checkBox1.Text = "Complete";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(533, 87);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(94, 29);
            CancelButton.TabIndex = 2;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CancelButton);
            Controls.Add(checkBox1);
            Controls.Add(Register);
            Name = "RegisterForm";
            Text = "RegisterForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Register;
        private CheckBox checkBox1;
        private Button CancelButton;
    }
}