using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApp_SkoleProsjekt.Models
{
  public class Friend
  {
    public string Username { get; } = string.Empty;
    public Guid ID { get; } = Guid.NewGuid();
  }
}