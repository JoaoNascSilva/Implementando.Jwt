using System.IO.Compression;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Implementando.Jwt
{
    public static class UserServices
    {
        private static readonly IEnumerable<User> _userList;

        static UserServices()
        {
            _userList = new List<User>()
            {
                new User("Roberto Mariano de Souza", "souzaroberto", "123456", (int)ERole.VENDEDOR),
                new User("Tauriel Gaus", "gaustauriel", "789456", (int)ERole.RECEPCIONISTA),
                new User("Maria Cristina", "cristinamaria", "147258", (int)ERole.DIRETOR),
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