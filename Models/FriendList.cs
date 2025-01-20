using System.Text.Json;

namespace ChatApp_SkoleProsjekt.Models
{
    public class FriendList
    {
        List<User>? UserList = new();
        List<Friend> friendList = new();
        public void AddFriend(Friend friend)
        {
            string path = "UserList.json";
            if (File.Exists(path))
            {
                string jsonContent = File.ReadAllText(path);
                UserList = JsonSerializer.Deserialize<List<User>>(jsonContent);
                if (UserList != null)
                {
                    User? user = UserList.FirstOrDefault(u => u.ID == friend.ID);
                    if (user != null)
                    {
                        user.Username = friend.Username;
                        user.ID = friend.ID;
                        friendList.Add(friend);
                    }
                    string updatedJson = JsonSerializer.Serialize(friendList, new JsonSerializerOptions { WriteIndented = true });
                    string pathNew = "FriendList.json";
                    File.WriteAllText(pathNew, updatedJson);
                }
                else
                {
                    Console.WriteLine("User does not exist");
                }
            }
        }

        public void RemoveFriend(Friend friend)
        {
            string path = "UserList.json";
            if (File.Exists(path))
            {
                string jsonContent = File.ReadAllText(path);
                UserList = JsonSerializer.Deserialize<List<User>>(jsonContent);
                if (UserList != null)
                {
                    User? user = UserList.FirstOrDefault(u => u.ID == friend.ID);
                    if (user != null)
                    {
                        user.Username = friend.Username;
                        user.ID = friend.ID;
                        friendList.Remove(friend);
                    }
                    string updatedJson = JsonSerializer.Serialize(friendList, new JsonSerializerOptions { WriteIndented = true });
                    string pathNew = "FriendList.json";
                    File.WriteAllText(pathNew, updatedJson);
                }
                else
                {
                    Console.WriteLine("User does not exist");
                }
            }
        }
    }
}