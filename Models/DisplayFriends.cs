using System.Text.Json;

namespace ChatApp_SkoleProsjekt.Models
{
    public class DisplayFriend
    {
        List<Friend> friendList;
        public void DisplayFriends(Friend friend)
        {
            {
                string path = "FriendList.json";
                if (File.Exists(path))
                {
                    string jsonContent = File.ReadAllText(path);
                    friendList = JsonSerializer.Deserialize<List<friend>>(jsonContent);
                    if (friendList != null)
                    {
                    }

                    // Get List<Users>
            // Output friendList
        }
    }
}