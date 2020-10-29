using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Project_ASP_CORE_API.Model
{
    public class Role_n_Permission
    {
        public string role_id { set; get; }
        public List<Permission> permission_id { set; get; }
    }
}
