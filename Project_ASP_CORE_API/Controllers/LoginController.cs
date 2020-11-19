using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Project_ASP_CORE_API.Helpers;
using Project_ASP_CORE_API.JwtClass;

namespace Project_ASP_CORE_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IConfiguration _config;
        public LoginController(IConfiguration config)
        {
            _config = config;
        }

        [HttpPost]
        [AllowAnonymous]
        public IActionResult Login([FromBody] UserJwt login)
        {
            IActionResult response = Unauthorized();
            UserJwt user = AuthenticateHelper.AuthenticateUser(login);
            if (user != null)
            {
                var tokenString = AuthenticateHelper.GenerateJWTToken(user, _config);
                response = Ok(new
                {
                    token = tokenString,
                    userDetails = user,
                });
            }
            return response;
        }
    }
}
