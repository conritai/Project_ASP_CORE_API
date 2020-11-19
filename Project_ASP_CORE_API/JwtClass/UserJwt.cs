using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_ASP_CORE_API.JwtClass
{
    public class UserJwt
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string UserRole { get; set; }
    }
}
