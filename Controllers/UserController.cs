using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Implementando.Jwt.Controllers
{
    [Route("User")]
    public class UserController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public ActionResult<User> GetUser(string username, string password)
        {            
            var result = UserServices.GetUser(username, password);
            return result;
        }
    }
}