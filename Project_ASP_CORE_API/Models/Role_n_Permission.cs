using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Project_ASP_CORE_API.Model
{
    public class Role_n_Permission
    {
        public Guid Role_id { get; set; }
        public Guid Permission_id { get; set; }
        public Role Role { get; set; }
        public Permission Permission { set; get; }
    }
}
