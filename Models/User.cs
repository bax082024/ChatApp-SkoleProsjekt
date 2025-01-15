using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApp_SkoleProsjekt.Models
{
    public class User
    {
        public string Username { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;
        public string Salt { get; set; } = string.Empty;
        public string SecretQuestion { get; set; } = string.Empty;
        public string SecretAnswerHash { get; set; } = string.Empty;
        public Guid ID { get; set; } = Guid.NewGuid();
    }
}
