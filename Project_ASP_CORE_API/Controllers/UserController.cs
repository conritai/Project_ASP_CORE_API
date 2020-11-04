using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project_ASP_CORE_API.Connection;
using Project_ASP_CORE_API.Model;

namespace Project_ASP_CORE_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        //POST : api/CreateUser
        [HttpPost]
        public async Task<JsonResult> CreateUser([FromBody] User user)
        {
            await using (var context = new Context())
            {
                //Guid id = new Guid(user.User_id);
                context.Users.Add(user);
                await context.SaveChangesAsync();
            }
            //return CreatedAtAction("CreateUser", new { id = user.User_id.ToString() }, user);
            return new JsonResult(user);
        }

        //PUT : api/UpdateUser
        [HttpPut]
        public async Task<JsonResult> UpdateUser([FromBody] User user)
        {
            await using (var context = new Context())
            {
                context.Entry(user).State = EntityState.Modified;
                /*foreach (var index in user.ATTRIBUTE)
                {
                    context.Entry(user).State = EntityState.Modified;
                }*/
                await context.SaveChangesAsync();
            }
            return new JsonResult(user);
        }

        //DELETE : api/DeleteUser
        [HttpDelete("{id}")]
        public async Task<JsonResult> DeleteUser([FromBody] User user)
        {
            await using( var context = new Context())
            {
                context.Entry(user).State = EntityState.Deleted;
                /*foreach (var index in user.ATTRIBUTE)
                {
                    context.Entry(user).State = EntityState.Deleted;
                }*/
                await context.SaveChangesAsync();
            }
            return new JsonResult(user);
        }
    }
}
