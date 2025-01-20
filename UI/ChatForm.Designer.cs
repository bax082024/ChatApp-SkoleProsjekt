namespace ChatApp_SkoleProsjekt.UI
{
    partial class ChatForm
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
            sendButton = new Button();
            messageListBox = new ListBox();
            messageTextBox = new TextBox();
            SendButton1 = new Button();
            SuspendLayout();
            // 
            // sendButton
            // 
            sendButton.BackColor = SystemColors.Control;
            sendButton.Location = new Point(1054, 692);
            sendButton.Margin = new Padding(4, 5, 4, 5);
            sendButton.Name = "sendButton";
            sendButton.Size = new Size(71, 35);
            sendButton.TabIndex = 0;
            sendButton.Text = "Send";
            sendButton.UseVisualStyleBackColor = false;
            // 
            // messageListBox
            // 
            messageListBox.BackColor = SystemColors.ScrollBar;
            messageListBox.FormattingEnabled = true;
            messageListBox.ItemHeight = 25;
            messageListBox.Location = new Point(231, -1);
            messageListBox.Margin = new Padding(4, 5, 4, 5);
            messageListBox.Name = "messageListBox";
            messageListBox.Size = new Size(546, 479);
            messageListBox.TabIndex = 1;
            // 
            // messageTextBox
            // 
            messageTextBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            messageTextBox.Location = new Point(231, 488);
            messageTextBox.Margin = new Padding(4, 5, 4, 5);
            messageTextBox.Name = "messageTextBox";
            messageTextBox.Size = new Size(429, 31);
            messageTextBox.TabIndex = 2;
            // 
            // SendButton1
            // 
            SendButton1.Location = new Point(677, 488);
            SendButton1.Name = "SendButton1";
            SendButton1.Size = new Size(75, 31);
            SendButton1.TabIndex = 3;
            SendButton1.Text = "Send";
            SendButton1.UseVisualStyleBackColor = true;
            SendButton1.Click += SendButton1_Click;
            // 
            // ChatForm
            // 
            AcceptButton = SendButton1;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(778, 544);
            Controls.Add(SendButton1);
            Controls.Add(sendButton);
            Controls.Add(messageTextBox);
            Controls.Add(messageListBox);
            Margin = new Padding(4, 5, 4, 5);
            Name = "ChatForm";
            Text = "ChatForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button sendButton;
        private ListBox messageListBox;
        private TextBox messageTextBox;
        private Button SendButton1;
    }
}