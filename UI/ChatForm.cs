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
        private const string ChatHistoryFilePath = "chatHistory.json";

        private Dictionary<string, List<ChatMessage>> chatHistory;
        private readonly AuthenticationHelper _authenticationHelper;

        public ChatForm(User currentUser)
        {
            InitializeComponent();
            chatHistory = new Dictionary<string, List<ChatMessage>>();
            LoadFriends();
            LoadChatHistory(currentUser.ID);

            // Add friends to the FriendListBox
            foreach (var friend in friendList)
            {
                FriendListBox.Items.Add(friend);
            }

            _currentUser = currentUser;
            _authenticationHelper = new AuthenticationHelper();
            this.Load += ChatForm_Load;
            this.FormClosing += ChatForm_FormClosing;
            //DisplayUserDetails();
            this.FriendListBox.SelectedIndexChanged += FriendListBox_SelectedIndexChanged;
        }

        private void SaveChatHistory(Guid friendID)
        {
            try
            {
                if (chatHistory.ContainsKey(friendID.ToString()))
                {
                    string json = Newtonsoft.Json.JsonConvert.SerializeObject(chatHistory[friendID.ToString()], Newtonsoft.Json.Formatting.Indented);
                    string fileName = $"{friendID}_chat.json";
                    System.IO.File.WriteAllText(fileName, json);


                    // Debugging: Show a confirmation message
                    Console.WriteLine($"Chat history with {selectedFriend.Username} has been saved.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while saving chat history: {ex.Message}");
            }
        }

        private void LoadChatHistory(Guid friendID)
        {
            messageRichTextBox.Clear();

            try
            {
                string fileName = $"{friendID}_chat.json";

                if (System.IO.File.Exists(fileName))
                {
                    string json = System.IO.File.ReadAllText(fileName);
                    var messages = Newtonsoft.Json.JsonConvert.DeserializeObject<List<ChatMessage>>(json);

                    if (messages != null)
                    {
                        chatHistory[friendID.ToString()] = messages;

                        Console.WriteLine($"Loaded chat history for {friendID}: {json}");

                        foreach (var message in messages)
                        {
                            AppendMessage(message);
                        }
                    }
                }
                else
                {
                    chatHistory[friendID.ToString()] = new List<ChatMessage>();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading chat history: {ex.Message}");
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

        private void SendMessage()
        {
            if (selectedFriend == null)
            {
                MessageBox.Show("Please select a friend to chat with.");
                return;
            }

            if (string.IsNullOrWhiteSpace(messageTextBox.Text))
            {
                MessageBox.Show("Cannot send an empty message.", "Empty message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ChatMessage newMessage = new ChatMessage
            {
                Sender = _currentUser.Username,
                Message = messageTextBox.Text.Trim(),
                TimeStamp = DateTime.Now
            };

            if (!chatHistory.ContainsKey(selectedFriend.ID.ToString()))
            {
                chatHistory[selectedFriend.ID.ToString()] = new List<ChatMessage>();
            }

            // Add new message to the chat history
            chatHistory[selectedFriend.ID.ToString()].Add(newMessage);

            // Append the message to the RichTextBox
            AppendMessage(newMessage);

            // Save the chat history
            SaveChatHistory(selectedFriend.ID);

            // Clear the message text box
            messageTextBox.Clear();
        }
        private void ChatForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveChatHistory(selectedFriend.ID);

            // Save the friends list before closing the form
            SaveFriends();
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
                SendMessage();
                SaveChatHistory(selectedFriend.ID);
                messageTextBox.Clear();
            }

        }

        private void FriendListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FriendListBox.SelectedItem is Friend selectedFriendItem)
            {
                selectedFriend = selectedFriendItem;

                if (selectedFriend != null)
                {
                    LoadChatHistory(selectedFriend.ID);
                    chatHeaderLabel.Text = $"Chatting with {selectedFriend.Username}";
                }
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

            SaveChatHistory(selectedFriend.ID);
        }

        private void AddFriendButton_Click(object sender, EventArgs e)
        {
            string friendName = PromptDialog.ShowDialog("Add Friend", "Enter your friend's name:");
            if (string.IsNullOrWhiteSpace(friendName))
            {
                MessageBox.Show("Please enter a valid friend name.");
                return;
            }

            // Generate a unique ID for the friend
            string friendID = Guid.NewGuid().ToString();

            // Add the friend to the FriendListBox
            var newFriend = new Friend
            {
                Username = friendName,
                ID = Guid.Parse(friendID)
            };

            FriendListBox.Items.Add(newFriend);

            MessageBox.Show($"{friendName} has been added to your friend list!");
        }

        private void SaveFriends()
        {
            try
            {
                string json = JsonConvert.SerializeObject(friendList, Newtonsoft.Json.Formatting.Indented);
                // Writing the JSON to output for debugging
                Console.WriteLine(json);
                System.IO.File.WriteAllText(FriendFilePath, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while saving friends: {ex.Message}");
            }
        }

        private void LoadFriends()
        {
            try
            {
                if (System.IO.File.Exists(FriendFilePath))
                {
                    string json = File.ReadAllText(FriendFilePath);
                    friendList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Friend>>(json)
                                  ?? new List<Friend>();
                }
                else
                {
                    friendList = new List<Friend>();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading friends: {ex.Message}");
                friendList = new List<Friend>();
            }
        }

        
    }
}
