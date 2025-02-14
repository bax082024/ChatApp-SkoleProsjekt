using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApp_SkoleProsjekt.Models
{
  public class Friend
  {
    public string Username { get; set; } = string.Empty;
    public Guid ID { get; set; }
    public string IPAddress { get; set; } = string.Empty;
    public int Port { get; set; }

        public override string ToString()
        {
            return Username; // Display the friend's name in the FriendListBox
        }
    }
}
