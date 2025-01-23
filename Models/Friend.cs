namespace ChatApp_SkoleProsjekt.Models
{
  public class Friend
  {
    public string Username { get; set; } = string.Empty;
    public Guid ID { get; set; } = Guid.NewGuid();
  }
}
