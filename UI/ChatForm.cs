using ChatApp_SkoleProsjekt.Models;
using ChatApp_SkoleProsjekt.Services;
using ChatApp_SkoleProsjekt.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        private readonly User _currentUser;

        private readonly AuthenticationHelper _authenticationHelper;
        
        public ChatForm()
        {
            InitializeComponent();

            _currentUser = currentUser;
            _authenticationHelper = new AuthenticationHelper();
            this.Load += ChatForm_Load;
            //this.FormClosing += ChatForm_FormClosing;
            //DisplayUserDetails();
        }

        private void ChatForm_Load(object sender, EventArgs e)
        {
           
        }

        private void SendButton1_Click(object sender, EventArgs e)
        {
            string message = messageTextBox.Text.Trim();

            if (!string.IsNullOrWhiteSpace(message))
            {
                messageListBox.Items.Add($"You: {message}");

                messageTextBox.Clear();
            }

        }
    }
}
