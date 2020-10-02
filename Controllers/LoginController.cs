using System;
using Implementando.Jwt.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Implementando.Jwt.Controllers
{
    [Route("v1/account")]
    public class LoginController : ControllerBase
    {
        [HttpPost]
        [Route("login")]
        public ActionResult<dynamic> Authenticate([FromBody] User user)
        {
            var userResult = UserServices.GetUser(user.UserName, user.Password);
            if (userResult == null)
                return NotFound(new { message = "Usuário não autorizado..."});

            var token = TokenService.GenerateToken(userResult);
            return Ok(new { username = userResult.UserName, userRole = userResult.Role, userToken = token, expire = DateTime.Now.AddSeconds(30).ToString("yyyy-MM-dd HH:mm:ss") });
        }

        [HttpGet]
        [Route("anonymous")]
        [AllowAnonymous]
        public string Anonymous() => "Anônimo";

        [HttpGet]
        [Route("authenticated")]
        [Authorize]
        public string Authenticated() => string.Format("Autenticado - {0}", User.Identity.Name);

        [HttpGet]
        [Route("sales")]
        [Authorize(Roles = "salesman, salesmanager, director" )]
        public string Employee() => "Setor de Vendas";

        [HttpGet]
        [Route("direction")]
        [Authorize(Roles = "direction")]
        public string Manager() => "Setor de Direção";
    }
}