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
    public class CustomerController : ControllerBase
    {
        //POST : AddCustomer
        [HttpPost]
        async public Task<JsonResult> CreateCustomer([FromBody] Customer customer)
        {
            await using (var context = new Context())
            {
                context.Customers.Add(customer);
                await context.SaveChangesAsync();
            }
            return new JsonResult(customer);
        }

        //PUT : UpdateCustomer
        [HttpPut]
        async public Task<JsonResult> UpdateCustomer([FromBody] Customer customer)
        {
            await using (var context = new Context())
            {
                context.Entry(customer).State = EntityState.Modified;
                /*foreach (var index in customer.ATTRIBUTE)
                {
                    context.Entry(customer).State = EntityState.Modified;
                }*/
                await context.SaveChangesAsync();
            }
            return new JsonResult(customer);
        }

        //DELETE : DeleteCustomer
        [HttpDelete]
        async public Task<JsonResult> DeleteCustomer([FromBody] Customer customer)
        {
            await using ( var context = new Context())
            {
                context.Entry(customer).State = EntityState.Deleted;
                /*foreach (var index in customer.ATTRIBUTE)
               {
                   context.Entry(customer).State = EntityState.Deleted;
               }*/
                await context.SaveChangesAsync();
            }
            return new JsonResult(customer);
        }
    }
}
