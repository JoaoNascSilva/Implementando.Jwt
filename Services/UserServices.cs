using Implementando.Jwt.Model.Enum;
using System.Collections.Generic;
using System.Linq;

namespace Implementando.Jwt.Services
{
    public static class UserServices
    {
        private static readonly IEnumerable<User> _userList;

        static UserServices()
        {
            _userList = new List<User>()
            {
                new User("Roberto Mariano de Souza", "souzaroberto", "123456", "salesman"),
                new User("Tauriel Gaus", "gaustauriel", "789456", "salesmanager"),
                new User("Maria Cristina", "cristinamaria", "147258", "director"),
            };
        }

        public static User GetUser(string username, string password)
        {
            var result = _userList
                            .Where(x => x.UserName.Equals(username) && x.Password.Equals(password))
                            .FirstOrDefault();
            return result;
        }
    }
}