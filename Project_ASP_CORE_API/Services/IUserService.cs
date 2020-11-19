using Microsoft.AspNetCore.Identity;
using Project_ASP_CORE_API.Connection;
using Project_ASP_CORE_API.Model;
using Project_ASP_CORE_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_ASP_CORE_API.Services
{
    public interface IUserService
    {
        //Task<bool> Authenticate(LoginRequest request);
    }

    public class UserService //: IUserService
    {
        /*private Context _context;
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly RoleManager<Role> _roleManager;

        public UserService(UserManager<User> userManager, SignInManager<User> signInManager, RoleManager<Role> roleManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }

        public UserService(Context context)
        {
            _context = context;
        }

        public Task<bool> Authenticate(LoginRequest request)
        {
            throw new NotImplementedException();
        }*/
    }
}
