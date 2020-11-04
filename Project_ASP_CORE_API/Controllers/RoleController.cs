using System;
using System.Collections.Generic;
using System.Linq;
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
    public class RoleController : ControllerBase
    {
        //POST : api/CreateRole
        [HttpPost]
        public async Task<JsonResult> CreateRole([FromBody] Role role)
        {
            await using (var context = new Context())
            {
                context.Roles.Add(role);
                await context.SaveChangesAsync();
            }
            return new JsonResult(role);
        }

        //PUT : api/UpdateRole
        [HttpPut]
        public async Task<JsonResult> UpdateRole([FromBody] Role role)
        {
            await using (var context = new Context())
            {
                context.Entry(role).State = EntityState.Modified;
                /*foreach (var index in role.ATTRIBUTE)
                {
                    context.Entry(role).State = EntityState.Modified;
                }*/
                await context.SaveChangesAsync();
            }
            return new JsonResult(role);
        }

        //DELETE : api/DeleteRole
        [HttpDelete("{id}")]
        public async Task<JsonResult> DeleteRole([FromBody] Role role)
        {
            await using (var context = new Context())
            {
                context.Entry(role).State = EntityState.Deleted;
                /*foreach (var index in role.ATTRIBUTE)
                {
                    context.Entry(role).State = EntityState.Deleted;
                }*/
                await context.SaveChangesAsync();
            }
            return new JsonResult(role);
        }
    }
}
