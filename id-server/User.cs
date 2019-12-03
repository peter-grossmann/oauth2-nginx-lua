
using System.Collections.Generic;
using System.Security.Claims;

namespace IdServer
{
    public class User
    {
        public User() { }
        public string SubjectId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
        public ICollection<Claim> Claims { get; set; }
    }
}