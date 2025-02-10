using System.Xml.Linq;

namespace ChatApp_SkoleProsjekt.Models
{
  public class Friend
  {
    public string Username { get; set; } = string.Empty;
    public Guid ID { get; set; } = Guid.NewGuid();

    public override string ToString()
        {
            return Username; // Display the friend's name in the FriendListBox
        }
    }
}
