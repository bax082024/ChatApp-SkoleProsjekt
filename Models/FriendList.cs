using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ChatApp_SkoleProsjekt.Models
{
    public class FriendList
    {
        List<User> UserList { get; set; }
        List<Friend> friendList = new List<Friend>();
        public void AddFriend(Friend friend)
        {
            string path = "UserList.json";
            if (File.Exists(path))
            {
                string jsonContent = File.ReadAllText(path);
                UserList = JsonSerializer.Deserialize<List<User>>(jsonContent);
                User user = UserList.FirstOrDefault(u => u.ID == friend.ID);
                if (user != null)
                {
                    user.Username = friend.Username;
                    user.ID = friend.ID;
                    friendList.Add(friend);
                }
                string updatedJson = JsonSerializer.Serialize(friendList, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(path, updatedJson);
            }
            else
            {
                Console.WriteLine("User does not exist");
            }
        }

        public void DisplayFriends()
        {
            // display.friendList;

            // Get List<Users>
            // Output friendList
        }
    }
}