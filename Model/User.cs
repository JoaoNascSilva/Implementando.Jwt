using System;

namespace Implementando.Jwt
{
    public class User
    {
        
        public User(string name, string userName, string password, int role)
        {
            this.Id = Guid.NewGuid();
            this.Name = name;
            this.UserName = userName;
            this.Password = password;
            this.Role = role;

        }

        public User() { }

        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public string UserName { get; private set; }
        public string Password { get; private set; }
        public int Role { get; private set; }
    }
}