using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project_ASP_CORE_API.Model
{
    public class Role
    {
        [Key]
        public string role_id { get; set; }
        public string role_name { get; set; }
        public string create_role_at { get; set; }
        public string update_role_at { get; set; }

    }
}
