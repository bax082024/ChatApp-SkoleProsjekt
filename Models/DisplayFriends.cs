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
                    friendList = JsonSerializer.Deserialize<List<Friend>>(jsonContent);
                    if (friendList != null)
                    {
                        foreach (Friend f in friendList)
                        {
                            Console.WriteLine(f);
                        }
                    }
                    else 
                    {
                        Console.WriteLine("You don't have any friends yet. Try add adding someone.");
                    }

                    // Get List<Users>
                    // Output friendList
                }
            }
        }
    }
}