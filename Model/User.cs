using System;

namespace Implementando.Jwt
{
    public class User
    {
        public User() { }
        public User(string name, string userName, string password, string role)
        {
            //this.Id = Guid.NewGuid();
            this.Name = name;
            this.UserName = userName;
            this.Password = password;
            this.Role = role;
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
    }
}