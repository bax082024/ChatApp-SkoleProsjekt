using ChatApp_SkoleProsjekt.Models;
using ChatApp_SkoleProsjekt.Services;
using ChatApp_SkoleProsjekt.UI;
using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatApp_SkoleProsjekt.UI
{
    public partial class ChatForm : Form
    {
        private TcpClient? _client; // Nullable tTcpClient
        private TcpListener? _listener; // Nullable TcpListener
        private NetworkStream? _stream; // Nullable NetworkStream   
        private const int _port = 12345;
        private List<Friend> friendList;
        private Friend selectedFriend;
        private const string FriendFilePath = "FriendList.json";
        private readonly User _currentUser;

        private Dictionary<string, List<ChatMessage>> chatHistory;
        private readonly AuthenticationHelper _authenticationHelper;

        public ChatForm(User currentUser)
        {
            InitializeComponent();
            LoadChatHistory(currentUser.ID);

            _currentUser = currentUser;
            _authenticationHelper = new AuthenticationHelper();
            this.Load += ChatForm_Load;
           // this.FormClosing += ChatForm_OnFormClosing;
            //DisplayUserDetails();
        }

        private void SaveChatHistory()
        {
            try
            {
                string json = JsonConvert.SerializeObject(chatHistory, Newtonsoft.Json.Formatting.Indented);
                System.IO.File.WriteAllText("chatHistory.json", json);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while saving chat history: {ex.Message}");
            }
        }

        private void LoadChatHistory(Guid friendId)
        {
            messageRichTextBox.Clear();

            if (chatHistory.ContainsKey(friendId.ToString()))
            {
                foreach (var message in chatHistory[friendId.ToString()])
                {
                    messageRichTextBox.AppendText($"{message.TimeStamp:HH:mm} {message.Sender}: {message.Message}");
                }
            }
            try
            {
                if (System.IO.File.Exists("chatHistory.json"))
                {
                    string json = File.ReadAllText("chatHistory.json");
                    chatHistory = Newtonsoft.Json.JsonConvert.DeserializeObject<Dictionary<string, List<ChatMessage>>>(json)
                                  ?? new Dictionary<string, List<ChatMessage>>();
                }
                else
                {
                    chatHistory = new Dictionary<string, List<ChatMessage>>();
                }
                if (chatHistory.ContainsKey(friendId.ToString()))
                {
                    foreach (var message in chatHistory[friendId.ToString()])
                    {
                        messageRichTextBox.AppendText($"{selectedFriend.Username}: {message.Message}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading chat history: {ex.Message}");
                chatHistory = new Dictionary<string, List<ChatMessage>>();
            }
        }

        private void AppendMessage(ChatMessage message)
        {
            string TimeStamp = message.TimeStamp.ToString("HH:mm");
            string formattedMessage = $"{TimeStamp} {message.Sender}: {message.Message}";

            // Applying sender-specific color to the message
            if (message.Sender == _currentUser.Username)
            {
                messageRichTextBox.SelectionColor = Color.Green;
            }
            else
            {
                messageRichTextBox.SelectionColor = Color.Brown;
            }

            // Append the message to the RichTextBox
            messageRichTextBox.AppendText(formattedMessage + Environment.NewLine);

            // Reset the color to default
            messageRichTextBox.SelectionColor = messageRichTextBox.ForeColor;

            // Scroll to the end of the RichTextBox
            messageRichTextBox.ScrollToCaret();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            SaveChatHistory();
            base.OnFormClosing(e);
        }
        private void ChatForm_Load(object sender, EventArgs e)
        {

        }

        private void SendButton1_Click(object sender, EventArgs e)
        {
            if (selectedFriend == null)
            {
                MessageBox.Show("Please select a friend to chat with.");
                return;
            }

            string message = messageTextBox.Text.Trim();

            if (!string.IsNullOrWhiteSpace(message))
            {
                var chatMessage = new ChatMessage
                {
                    Sender = _currentUser.Username,
                    Message = message,
                    TimeStamp = DateTime.Now
                };

                // Add the message to the chat history
                messageRichTextBox.AppendText($"{chatMessage.TimeStamp: HH:mm} {chatMessage.Sender}: {chatMessage.Message}");

                if (chatHistory.ContainsKey(selectedFriend.ID.ToString()))
                {
                    chatHistory[selectedFriend.ID.ToString()].Add(chatMessage);
                }
                else
                {
                    chatHistory[selectedFriend.ID.ToString()] = new List<ChatMessage> { chatMessage };
                }

                // Append the message to the RichTextBox
                AppendMessage(chatMessage);
                SaveChatHistory();
                messageTextBox.Clear();
            }

        }

        private void FriendListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (File.Exists(FriendFilePath))
            {
                string jsonContent = File.ReadAllText(FriendFilePath);
                var friends = JsonConvert.DeserializeObject<List<Friend>>(jsonContent);
                if (friends != null)
                {
                    friendList = friends;
                    foreach (Friend f in friendList)
                    {
                        Console.WriteLine(f);
                    }
                }
                else
                {
                    MessageBox.Show("You don't have any friends yet. Try adding someone :)");
                }
            }

            selectedFriend = FriendListBox.SelectedItem as Friend;

            if (selectedFriend != null)
            {
                // LoadChatHistory(selectedFriend.Id);
            }
        }

        private void ClearHistorybutton_Click(object sender, EventArgs e)
        {
            if (selectedFriend == null)
            {
                MessageBox.Show("Please select a friend to clear chat history.");
                return;
            }

            var result = MessageBox.Show("Are you sure you want to clear chat history?", "Clear Chat History",
                         MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                if (chatHistory.ContainsKey(selectedFriend.ID.ToString()))
                {
                    chatHistory[selectedFriend.ID.ToString()].Clear();
                    messageRichTextBox.Clear();
                }

                MessageBox.Show($"Chat history with {selectedFriend.Username} has been cleared.");
            }

            SaveChatHistory();
        }
    }
}
