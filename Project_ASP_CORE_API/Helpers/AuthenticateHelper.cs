using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Project_ASP_CORE_API.Connection;
using Project_ASP_CORE_API.JwtClass;
using Project_ASP_CORE_API.Model;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Project_ASP_CORE_API.Helpers
{
    public static class AuthenticateHelper
    {
        public static UserJwt AuthenticateUser(UserJwt loginCredentials)
        {
            using (var context = new Context())
            {
                User user1 = context.Users.SingleOrDefault(x => x.Username == loginCredentials.Username && x.Password == loginCredentials.Password);
                UserJwt user = new UserJwt
                {
                    Username = user1.Username,
                    Password = user1.Password,
                    UserRole = user1.Role.Role_name
                };
                return user;
            }
        }

        public static string GenerateJWTToken(UserJwt userInfo, IConfiguration _config)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt: SecretKey"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, userInfo.Username),
                new Claim("role",userInfo.UserRole),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
            };
            var token = new JwtSecurityToken(
            issuer: _config["Jwt: Issuer"],
            audience: _config["Jwt: Audience"],
            claims: claims,
            expires: DateTime.Now.AddMinutes(30),
            signingCredentials: credentials
            );
            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
