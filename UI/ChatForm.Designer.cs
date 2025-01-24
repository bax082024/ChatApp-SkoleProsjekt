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
            messageTextBox = new TextBox();
            SendButton1 = new Button();
            FriendListBox = new ListBox();
            ClearHistorybutton = new Button();
            messageRichTextBox = new RichTextBox();
            AddFriendButton = new Button();
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
            // messageTextBox
            // 
            messageTextBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            messageTextBox.Location = new Point(200, 480);
            messageTextBox.Margin = new Padding(4, 5, 4, 5);
            messageTextBox.Name = "messageTextBox";
            messageTextBox.Size = new Size(480, 31);
            messageTextBox.TabIndex = 2;
            // 
            // SendButton1
            // 
            SendButton1.Location = new Point(690, 480);
            SendButton1.Name = "SendButton1";
            SendButton1.Size = new Size(90, 30);
            SendButton1.TabIndex = 3;
            SendButton1.Text = "Send";
            SendButton1.UseVisualStyleBackColor = true;
            SendButton1.Click += SendButton1_Click;
            // 
            // FriendListBox
            // 
            FriendListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            FriendListBox.FormattingEnabled = true;
            FriendListBox.ItemHeight = 25;
            FriendListBox.Location = new Point(10, 10);
            FriendListBox.Name = "FriendListBox";
            FriendListBox.Size = new Size(180, 479);
            FriendListBox.TabIndex = 4;
            FriendListBox.SelectedIndexChanged += FriendListBox_SelectedIndexChanged;
            // 
            // ClearHistorybutton
            // 
            ClearHistorybutton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ClearHistorybutton.Location = new Point(220, 510);
            ClearHistorybutton.Name = "ClearHistorybutton";
            ClearHistorybutton.Size = new Size(120, 30);
            ClearHistorybutton.TabIndex = 5;
            ClearHistorybutton.Text = "ClearHistory";
            ClearHistorybutton.UseVisualStyleBackColor = true;
            ClearHistorybutton.Click += ClearHistorybutton_Click;
            // 
            // messageRichTextBox
            // 
            messageRichTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            messageRichTextBox.Location = new Point(220, 10);
            messageRichTextBox.Name = "messageRichTextBox";
            messageRichTextBox.ReadOnly = true;
            messageRichTextBox.ScrollBars = RichTextBoxScrollBars.Vertical;
            messageRichTextBox.Size = new Size(400, 480);
            messageRichTextBox.TabIndex = 6;
            messageRichTextBox.Text = "";
            // 
            // AddFriendButton
            // 
            AddFriendButton.Location = new Point(43, 495);
            AddFriendButton.Name = "AddFriendButton";
            AddFriendButton.Size = new Size(112, 34);
            AddFriendButton.TabIndex = 7;
            AddFriendButton.Text = "AddFriend ";
            AddFriendButton.UseVisualStyleBackColor = true;
            AddFriendButton.Click += AddFriendButton_Click;
            // 
            // ChatForm
            // 
            AcceptButton = SendButton1;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(778, 544);
            Controls.Add(AddFriendButton);
            Controls.Add(messageRichTextBox);
            Controls.Add(ClearHistorybutton);
            Controls.Add(FriendListBox);
            Controls.Add(SendButton1);
            Controls.Add(sendButton);
            Controls.Add(messageTextBox);
            Margin = new Padding(4, 5, 4, 5);
            Name = "ChatForm";
            ShowIcon = false;
            Text = "ChatForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button sendButton;
        private TextBox messageTextBox;
        private Button SendButton1;
        private ListBox FriendListBox;
        private Button ClearHistorybutton;
        private RichTextBox messageRichTextBox;
        private Button AddFriendButton;
    }
}