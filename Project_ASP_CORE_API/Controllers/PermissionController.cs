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
    public class PermissionController : ControllerBase
    {
        //POST : api/CreatePermission
        [HttpPost]
        public async Task<JsonResult> CreatePermission([FromBody] Permission permission)
        {
            await using (var context = new Context())
            {
                context.Permissions.Add(permission);
                await context.SaveChangesAsync();
            }
            return new JsonResult(permission);
        }

        //PUT : api/UpdatePermission
        [HttpPut]
        public async Task<JsonResult> UpdatePermission([FromBody] Permission permission)
        {
            await using (var context = new Context())
            {
                context.Entry(permission).State = EntityState.Modified;
                /*foreach (var index in permission.ATTRIBUTE)
                {
                    context.Entry(permission).State = EntityState.Modified;
                }*/
                await context.SaveChangesAsync();
            }
            return new JsonResult(permission);
        }

        //DELETE : api/DeletePermission
        [HttpDelete("{id}")]
        public async Task<JsonResult> DeletePermission([FromBody] Permission permission)
        {
            await using (var context = new Context())
            {
                context.Entry(permission).State = EntityState.Deleted;
                /*foreach (var index in permission.ATTRIBUTE)
                {
                    context.Entry(permission).State = EntityState.Deleted;
                }*/
                await context.SaveChangesAsync();
            }
            return new JsonResult(permission);
        }
    }
}
